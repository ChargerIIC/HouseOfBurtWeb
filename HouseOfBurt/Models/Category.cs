using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HouseOfBurt.Models
{
    public class Category
    {
        private ICollection<Article> articleList;

        [Key]
        public int CategoryId { get; set; }

        public string Caption { get; set; }

        public virtual ICollection<Article> ArticleList
        {
            get { return articleList = articleList ?? new HashSet<Article>(); }
            set { articleList = value; }
        }
    }
}