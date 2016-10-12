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
        public string Guarantee { get; set; }

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

        [Display(Name = "Hiện lên trang chủ")]
        public bool ShowOnHome { get; set; }

        [Display(Name = "Mã loại sản phẩm")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}