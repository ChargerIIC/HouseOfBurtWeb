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
        public string Name { get; set; }

        public int SourceLinkId { get; set; }
        public virtual Link SourceLink { get; set;}
        public string IconUrl { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }

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