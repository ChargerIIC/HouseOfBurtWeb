using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HouseOfBurt.Models
{
    public class Application
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicationId { get; set; }

        public string Name { get; set; }

        public string IconUrl { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public string Action { get; set; }
    }
}