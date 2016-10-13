using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ledsangviet_chuongnh.Models
{
    [Table("Product")]
    public class Product
    {
        public Product()
        {
            CreateDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
            ShowOnHome = false;
            Status = true;
            DisplayOrder = 1;
        }
        [Key]
        public int Id { get; set; }

        [Display(Name = "Mã sản phẩm")]
        [StringLength(10)]
        public string Code { get; set; }

        [Display(Name = "Tên sản phẩm")]
        [StringLength(250)]
        public string Name { get; set; }

        [Display(Name = "Giá bán")]
        [DataType(DataType.Currency)]
        public string Price { get; set; }

        [Display(Name = "Chip Led")]
        [StringLength(250)]
        public string ChipLed { get; set; }

        [Display(Name = "Bảo hành")]
        [StringLength(50)]
        public string Waranty { get; set; }

        [AllowHtml]
        [Display(Name = "Mô tả")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [AllowHtml]
        [Display(Name = "Ghi chú")]
        [DataType(DataType.MultilineText)]
        public string Note { get; set; }

        [Display(Name = "Hình ảnh")]
        [StringLength(250)]
        public string Image { get; set; }

        [Display(Name = "Hãng sản xuất")]
        [StringLength(100)]
        public string Manufacturer { get; set; }

        [Display(Name = "Hiện thị trên trang chủ")]
        public bool ShowOnHome { get; set; }

        [Display(Name = "Thứ tự hiện thị")]
        public int DisplayOrder { get; set; }

        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }


        [Display(Name = "Mã loại sản phẩm")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        //============================================
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

        // author
        [Display(Name = "Ngày khởi tạo")]
        [DataType(DataType.DateTime)]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Người khởi tạo")]
        [StringLength(100)]
        public string CreateBy { get; set; }

        [Display(Name = "Ngày chỉnh sửa")]
        [DataType(DataType.DateTime)]
        public DateTime ModifiedDate { get; set; }

        [Display(Name = "Người chỉnh sửa")]
        [StringLength(100)]
        public string ModifiedBy { get; set; }
        //============================================

        public virtual Category Category { get; set; }
    }
}