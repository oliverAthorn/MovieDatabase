#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieDatabase.Web.Models;

namespace MovieDatabase.Web.Data
{
    public class MovieDatabaseWebContext : DbContext
    {
        public MovieDatabaseWebContext (DbContextOptions<MovieDatabaseWebContext> options)
            : base(options)
        {
        }

        public DbSet<MovieDatabase.Web.Models.Movie> Movie { get; set; }
    }
}
