using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseOfBurt.Models
{
    public partial class Article
    {
        public string getArticleSummary(int wordCount)
        {
            return this.Content;
        }

    }
}