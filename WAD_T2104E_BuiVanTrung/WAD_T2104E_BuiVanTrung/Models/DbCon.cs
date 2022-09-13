using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WAD_T2104E_BuiVanTrung.Models
{
    public class DbCon: DbContext
    {
        public DbCon() : base()
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}