using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MoviePraci.Models;

namespace MoviePraci.Models
{
    public class DbCon: DbContext
    {
        public DbCon() : base()
        {

        }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Genre> Genre { get; set; }
    }
}