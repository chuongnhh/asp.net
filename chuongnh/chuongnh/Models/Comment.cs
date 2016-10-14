using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace chuongnh.Models
{
    [Table("Comment")]
    public class Comment
    {
        [Display(Name ="Mã comment")]
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nội dung comment")]
        [DataType(DataType.Text)]
        public string Content { get; set; }

        [Display(Name = "Thời gian comment")]
        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }

        [Display(Name = "Mã vài viết")]
        [ForeignKey("Post")]
        public int PostId { get; set; }

        [Display(Name = "Mã người dùng")]
        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual Post Posts { get; set; }

    }
}