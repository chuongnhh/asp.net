using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ledsangviet_chuongnh.Models
{
    [Table("News")]
    public class News
    {
        public News()
        {
            CreateDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
            DisplayOrder = 1;
        }
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tiêu đề")]
        [StringLength(250)]
        public string Title { get; set; }

        [Display(Name = "Mô tả ngắn")]
        [StringLength(500)]
        public string Description { get; set; }

        [AllowHtml]
        [Display(Name = "Nội dung")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        [Display(Name = "Ngày đăng")]
        [DataType(DataType.DateTime)]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Ngày sửa")]
        [DataType(DataType.DateTime)]
        public DateTime ModifiedDate { get; set; }

        [Display(Name = "Người đăng")]
        [StringLength(50)]
        public string CreateBy { get; set; }

        [Display(Name = "Người sửa")]
        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [Display(Name = "Hình ảnh")]
        [StringLength(250)]
        public string Image { get; set; }

        [Display(Name ="Thứ tự hiện thị")]
        public int DisplayOrder { get; set; }
    }
}