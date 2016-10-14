using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace chuongnh.Models
{
    public class chuongnhContext:DbContext
    {
        public chuongnhContext():base("name = chuongnh")
        {

        }
    }
}