using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using HouseOfBurt.Controllers;

namespace HouseOfBurt.Tests.Controllers
{
    public class StringUtilityTest
    {
       

        //[Fact]
        //public void ToDelimitedStringTest()
        //{
        //    (new string[] { }).ToDelimitedString(",").Should().Be(string.Empty);
        //    ((string[])null).ToDelimitedString(",").Should().Be(string.Empty);
        //    (new string[] { "one" }).ToDelimitedString(", ").Should().Be("one");
        //    (new string[] { "one", "two" }).ToDelimitedString(", ").Should().Be("one, two");
        //    (new string[] { "one", "two" }).ToDelimitedString(",").Should().Be("one,two");
        //}

        [Fact]
        public void StripHtmlTest()
        {
            ((string)null).StripHtml().Should().BeNull();

            "hello".StripHtml().Should().Be("hello");

            "he<b>ll</b>o".StripHtml().Should().Be("hello");
        }

        [Fact]
        public void TruncateTextTest()
        {
            ((string)null).StripHtml().Should().BeNull();

            string test = "1234567890";
            test.Truncate(5, null).Should().Be("12345");
            test.Truncate(5, "...").Should().Be("12345...");
            string.Empty.Truncate(5, null).Should().Be(string.Empty);
            "12".Truncate(5).Should().Be("12");
        }

        [Fact]
        public void TruncateHtmlEmptyTest()
        {
            ((string)null).TruncateHtml(100).Should().BeNull();
            string.Empty.TruncateHtml(100).Should().Be(string.Empty);
        }

        [Fact]
        public void TruncateHtmlTextTest()
        {
            // no html test
            "abc".TruncateHtml(10).Should().Be( "abc");
            "abc".TruncateHtml(2).Should().Be("ab");
        }

        [Fact]
        public void TruncateHtmlTest()
        {
            var html = @"<p>aaa <b>bbb</b>ccc<br> ddd</p>";

            html.TruncateHtml(100, "no trailing text").Should().Be(@"<p>aaa <b>bbb</b>ccc<br> ddd</p>"); // it ignores unclosed tags

            html.TruncateHtml(14, "...").Should().Be(@"<p>aaa <b>bbb</b>ccc<br>...</br></p>");

            html.TruncateHtml(10).Should().Be(@"<p>aaa <b>bbb</b></p>");

            // self closing test
            html = @"<p>hello<br/>there</p>";
            html.TruncateHtml(7).Should().Be(@"<p>hello<br/>th</p>");

            "<b>i'm awesome</b>".TruncateHtml(8).Should().Be("<b>i'm</b>");
            "<b>i'm awesome</b>".TruncateHtml(8, "...").Should().Be("<b>i'm...</b>");
        }

        [Fact]
        public void TruncateWordsTest()
        {
            ((string)null).TruncateWords(100).Should().BeNull();
            string.Empty.TruncateWords(100).Should().Be(string.Empty);

            "big brown beaver".TruncateWords(12).Should().Be("big brown");
            "big brown beaver".TruncateWords(5, "...").Should().Be("big...");
        }

        [Fact]
        public void TruncateWordsBreakingHtmlTagTest()
        {
            // truncates in the middle of a tag
            "<b>i'm awesome</b>".TruncateWords(16).Should().Be("<b>i'm");
        }
    }
}
