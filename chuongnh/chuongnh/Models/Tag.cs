using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace chuongnh.Models
{
    [Table("Tag")]
    public class Tag
    {
        [Display(Name ="Mã đánh dấu")]
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tên đánh dấu")]
        [StringLength(250)]
        public string Name { get; set; }

        [Display(Name = "Mã bài viết")]
        [ForeignKey("Post")]
        public int PostId { get; set; }

        public virtual Post Post { get; set; }
    }
}