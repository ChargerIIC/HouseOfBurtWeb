using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HouseOfBurt.Models
{
    public class ContextIsNeeded_Question
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionId { get; set; }

        public string Caption { get; set; }

        public string Url { get; set; }
    }
}