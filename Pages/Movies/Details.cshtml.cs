using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplicationMoviesSpring2021.Data;
using WebApplicationMoviesSpring2021.Models;

namespace WebApplicationMoviesSpring2021.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplicationMoviesSpring2021.Data.WebApplicationMoviesSpring2021Context _context;

        public DetailsModel(WebApplicationMoviesSpring2021.Data.WebApplicationMoviesSpring2021Context context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
