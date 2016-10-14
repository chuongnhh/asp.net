using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chuongnh.Models
{
    [Table("Post")]
    public class Post
    {
        public Post()
        {
            Categories = new List<Category>();
            Comments = new List<Comment>();
            Relateds = new List<Related>();
            Tags = new List<Tag>();
        }
        [Display(Name = "Mã bài viết")]
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tiêu đề bài viết")]
        [StringLength(250)]
        public string Title { get; set; }

        [Display(Name = "Nội dung bài biết")]
        [AllowHtml]
        [DataType(DataType.MultilineText)]
        public string Article { get; set; }

        [Display(Name = "Đường dẫn file")]
        [StringLength(250)]
        public string File { get; set; }

        [Display(Name = "Thời gian publish")]
        [DataType(DataType.DateTime)]
        public DateTime Publish { get; set; }

        [Display(Name = "Ảnh bài viết")]
        [StringLength(250)]
        public string Banner { get; set; }

        [Display(Name = "Trạng thái hiện thị")]
        public bool Status { get; set; }

        [Display(Name = "Cho phép comment")]
        public bool Comment { get; set; }

        [Display(Name = "Số lượt xem")]
        public int Views { get; set; }

        [Display(Name = "Mã người viết")]
        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }
        public virtual List<Category> Categories { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Tag> Tags { get; set; }
        public virtual List<Related> Relateds { get; set; }
    }
}