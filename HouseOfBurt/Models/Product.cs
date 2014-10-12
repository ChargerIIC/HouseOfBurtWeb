using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HouseOfBurt.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string Name
        {
            get { return Slug.Replace('-', ' '); }
        }

        public int SourceLinkId
        {
            get { return SourceLink.LinkId; }
        }

        public virtual Link SourceLink { get; set;}

        [StringLength(255)]
        public string IconUrl { get; set; }

        [StringLength(255)]
        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public string ShortDescription { get; set; }

        //SEO friendly url: only lowercase, number and dash (-) character allowed
        [Index("Idx_Article_Slug"), StringLength(255)]
        public string Slug { get; set; }

        //Comma seperated list of Seo search keywords
        [StringLength(120)]
        public string Keywords { get; set; }

        ICollection<Version> versions;
        public virtual ICollection<Version> Versions
        {
            get
            {
                return versions = versions ?? new HashSet<Version>();
            }
            set { versions = value; }
        }
    }
}