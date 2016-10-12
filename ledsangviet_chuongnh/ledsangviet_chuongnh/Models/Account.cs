using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ledsangviet_chuongnh.Models
{
    [Table("Account")]
    public class Account
    {
        [Display(Name="Tên tài khoản")]
        [Key]
        public string Username { get; set; }

        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [Display(Name = "Địa chỉ email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Tên người dùng")]
        [StringLength(250)]
        public string Name { get; set; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.DateTime)]
        public DateTime Birthday { get; set; }

        [Display(Name = "Giới tính")]
        [StringLength(10)]
        public string Gender { get; set; }

        [Display(Name = "Địa chỉ")]
        [StringLength(500)]
        public string Address { get; set; }

        [Display(Name = "Ảnh đại diện")]
        [StringLength(250)]
        public string Image { get; set; }
    }
}