using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace chuongnh.Models
{
    [Table("User")]
    public class User
    {
        public User()
        {
            Comments = new List<Comment>();
        }
        [Display(Name = "Mã người dùng")]
        [Key]
        public int Id { get; set; }

        [Display(Name="Tên người dùng")]
        [StringLength(250)]
        public string Name { get; set; }

        [Display(Name = "Địa chỉ email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}