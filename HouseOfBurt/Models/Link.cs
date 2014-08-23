using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HouseOfBurt.Models
{
    public class Link
    {
        [Key]
        public int LinkId { get; set; }

        public string Caption { get; set; }

        public string URL { get; set; }
    }
}