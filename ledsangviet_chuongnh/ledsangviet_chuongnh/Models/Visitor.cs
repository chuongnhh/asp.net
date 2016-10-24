using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ledsangviet_chuongnh.Models
{
    [Table("Visitor")]
    public class Visitor
    {
        public Visitor()
        {
            this.DateTime = DateTime.Now;
        }
        [Display(Name = "Visitor Id")]
        [Key]
        public int Id { get; set; }

        [Display(Name = "Date time")]
        public DateTime DateTime { get; set; }

        [Display(Name = "Browser")]
        public string Browser { get; set; }

        [Display(Name = "Browser version")]
        public string Version { get; set; }

        [Display(Name = "Browser type")]
        public string Type { get; set; }

        [Display(Name = "Browser platform")]
        public string Platform { get; set; }

        [Display(Name = "User agent")]
        public string UserAgent { get; set; }

        [Display(Name = "User languages")]
        public string UserLanguages { get; set; }

        [Display(Name = "User host address")]
        public string UserHostAddress { get; set; }
    }
}