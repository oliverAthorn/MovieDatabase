#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieDatabase.Web.Data;
using MovieDatabase.Web.Models;

namespace MovieDatabase.Web.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieDatabase.Web.Data.MovieDatabaseWebContext _context;

        public IndexModel(MovieDatabase.Web.Data.MovieDatabaseWebContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
