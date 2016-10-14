using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace chuongnh.Models
{
    [Table("Author")]
    public class Author
    {
        public Author()
        {
            Pots = new List<Post>();
        }
        [Display(Name="Mã tác giả")]
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tên tác giả")]
        public string Name { get; set; }

        public virtual List<Post> Pots { get; set; }
    }
}