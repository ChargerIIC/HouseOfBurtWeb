using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public string Title
        {
            get { return Slug.Replace('-', ' '); }
        }

        public string Content { get; set; }

        public DateTime CreationDate { get; set; }

        [StringLength(128)]
        public string PictureUrl { get; set; }

        //SEO friendly url: only lowercase, number and dash (-) character allowed
        [Index("Idx_Article_Slug"), StringLength(255)]
        public string Slug { get; set; }
         
        //Comma seperated list of Seo search keywords
        [StringLength(120)]
        public string Keywords { get; set; }

        //To add my pic as the author of the article in google search results
        [StringLength(30)]
        public string GooglePlusId { get { return "110470725147694451935"; } }

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