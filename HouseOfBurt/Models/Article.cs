using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HouseOfBurt.Utilities;

namespace HouseOfBurt.Models
{
    public partial class Article
    {
        private ICollection<Category> tagList;
        private ICollection<Link> linkList;

            #region Raw Properties
        [Key]
        public int ArticleId { get; set;}

        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public string PictureUrl { get; set; }
        #endregion Raw Properties

        #region Linking Properties

        public virtual ICollection<Link> Links
        {
            get
            {
                return linkList = linkList ?? new HashSet<Link>();
            }
            set { linkList = value; }
        }
        public virtual ICollection<Category> Tags
        {
            get
            {
                return tagList = tagList ?? new HashSet<Category>();
            }
            set { tagList = value; }
        }

        #endregion Linking Properties

        #region Public Methods

        public string getArticleSummary(int wordCount)
        {
            return this.Content.TruncateHtml(wordCount);
        }

        #endregion Public Methods
    }
}