using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HouseOfBurt.Models
{
    public class DataContext : DbContext
    {
        #region Tables

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Version> Versions { get; set; }

        #endregion Tables

        #region Public Methods

        #endregion Public Methods

    }
}