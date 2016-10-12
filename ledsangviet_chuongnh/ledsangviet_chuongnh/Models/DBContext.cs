using ledsangviet_chuongnh.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ledsangviet_chuongnh.Models
{
    public class DBContext : DbContext
    {
        public DBContext() : base("name = ledsangviet")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DBContext, Configuration>("ledsangviet"));
        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<SystemConfig> SystemConfigs { get; set; }
    }
}