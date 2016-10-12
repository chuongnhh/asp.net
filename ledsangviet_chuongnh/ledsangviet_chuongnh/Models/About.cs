using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ledsangviet_chuongnh.Models
{
    [Table("About")]
    public class About
    {
        public About()
        {

        }
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tên công ty")]
        [StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "Địa chỉ")]
        [StringLength(250)]
        public string Address { get; set; }

        [Display(Name = "Địa chỉ email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Đường dây nóng")]
        [StringLength(100)]
        public string Hotline { get; set; }

        [Display(Name = "Địa chỉ website")]
        [StringLength(100)]
        public string Website { get; set; }

        [Display(Name = "Fanpage")]
        [StringLength(100)]
        public string Fanpage { get; set; }

        [AllowHtml]
        [Display(Name = "Mô tả công ty")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Hình ảnh công ty")]
        [StringLength(250)]
        public string Image { get; set; }

        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }
    }
}