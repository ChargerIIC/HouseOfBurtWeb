using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseOfBurt.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public Link SourceLink { get; set; }
        public string IconUrl { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public List<Version> Versions { get; set; }
    }
}