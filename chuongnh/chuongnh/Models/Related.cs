using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace chuongnh.Models
{
    [Table("Related")]
    public class Related
    {
        [Display(Name ="Mã bài viết")]
        [Column(Order = 1)]
        [Key]
        [ForeignKey("Post")]
        public int PostId { get; set; }

        [Display(Name = "Mã bài viết liên quan")]
        [Column(Order = 2)]
        [Key]
        [ForeignKey("Post")]
        public int RelatedId { get; set; }

        public Post Post { get; set; }
        public Post Relate { get; set; }
    }
}