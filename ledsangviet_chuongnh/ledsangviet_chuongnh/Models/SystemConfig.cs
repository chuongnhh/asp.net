using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ledsangviet_chuongnh.Models
{
    [Table("SystemConfig")]
    public class SystemConfig
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tên thiết lập")]
        public string Name { get; set; }

        [Display(Name = "Loại thiết lập")]
        public string Type { get; set; }

        [Display(Name = "Giá trị thiết lập")]
        public string Value { get; set; }

        [Display(Name = "Trạng thái thiết lập")]
        public bool Status { get; set; }
    }
}