using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ledsangviet_chuongnh.Areas.Admin.Models
{
    [Serializable]
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
    }
}