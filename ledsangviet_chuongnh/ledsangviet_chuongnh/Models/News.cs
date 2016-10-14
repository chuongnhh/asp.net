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
            DisplayOrder = 1;
            ShowOnHome = false;
        }
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tiêu đề bài viết")]
        [StringLength(250)]
        public string Title { get; set; }

        [Display(Name = "Mô tả ngắn")]
        [StringLength(500)]
        public string Description { get; set; }

        [AllowHtml]
        [Display(Name = "Nội dung bài viết")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        [Display(Name = "Ngày đăng")]
        [DataType(DataType.DateTime)]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Người đăng")]
        [StringLength(50)]
        public string CreateBy { get; set; }

        [Display(Name = "Hình ảnh")]
        [StringLength(250)]
        public string Image { get; set; }

        [Display(Name = "Hiện thị trên trang chủ")]
        public bool ShowOnHome { get; set; }

        [Display(Name ="Thứ tự hiện thị")]
        public int DisplayOrder { get; set; }

        // seo suport
        [Display(Name = "Meta title")]
        [StringLength(250)]
        public string MetaTitle { get; set; }

        [Display(Name = "Seo title")]
        [StringLength(250)]
        public string SeoTitle { get; set; }

        [Display(Name = "Meta keywords")]
        [StringLength(250)]
        public string MetaKeywords { get; set; }


        [Display(Name = "Meta description")]
        [StringLength(250)]
        public string MetaDescription { get; set; }
    }
}