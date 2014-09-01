using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HouseOfBurt.Models
{
    public class ContextIsNeeded_Question
    {
        [Key]
        public int QuestionId { get; set; }

        public string Caption { get; set; }

        public string Url { get; set; }
    }
}