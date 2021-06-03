using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationMoviesSpring2021.Models;

namespace WebApplicationMoviesSpring2021.Data
{
    public class WebApplicationMoviesSpring2021Context : DbContext
    {
        public WebApplicationMoviesSpring2021Context (DbContextOptions<WebApplicationMoviesSpring2021Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationMoviesSpring2021.Models.Movie> Movie { get; set; }
    }
}
