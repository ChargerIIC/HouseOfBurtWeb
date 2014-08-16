using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HouseOfBurt.Utilities;

namespace HouseOfBurt.Models
{
    public partial class Article
    {
        #region Raw Properties

        public int ArticleId { get; set;}
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public string PictureUrl { get; set; }
        #endregion Raw Properties

        #region Linking Properties

        public List<Link> Links { get; set; }
        public List<Category> Tags { get; set; }

        #endregion Linking Properties

        #region Public Methods

        public string getArticleSummary(int wordCount)
        {
            return this.Content.TruncateHtml(wordCount);
        }

        #endregion Public Methods
    }
}