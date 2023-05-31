using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorpagesMovie.Data
{
    public class RazorpagesMovieContext : DbContext
    {
        public RazorpagesMovieContext (DbContextOptions<RazorpagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; } = default!;

        public DbSet<RazorPagesMovie.Models.Song> Song { get; set; } = default!;
    }
}
