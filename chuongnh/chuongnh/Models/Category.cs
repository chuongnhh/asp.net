using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace chuongnh.Models
{
    [Table("Category")]
    public class Category
    {
        public Category()
        {
            Posts = new List<Post>();
        }
        [Display(Name = "Mã loại bài viết")]
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tên loại bài viết")]
        [StringLength(250)]
        public string Name { get; set; }

        [Display(Name = "Trạng thái loại bài viết")]
        public bool Status { get; set; }

        [Display(Name = "Thời gian khởi tạo")]
        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }

        public virtual List<Post> Posts { get; set; }
    }
}