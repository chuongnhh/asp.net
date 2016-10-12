using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ledsangviet_chuongnh.Models
{
    [Table("Slide")]
    public class Slide
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Tên slide")]
        [StringLength(250)]
        public string Name { get; set; }

        [Display(Name = "Ảnh")]
        [StringLength(250)]
        public string Image { get; set; }

        [Display(Name = "Link")]
        [StringLength(250)]
        public string Link { get; set; }
    }
}