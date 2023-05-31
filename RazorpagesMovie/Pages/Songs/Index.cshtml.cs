using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using RazorpagesMovie.Data;

namespace RazorpagesMovie.Pages.Songs
{
    public class IndexModel : PageModel
    {
        private readonly RazorpagesMovie.Data.RazorpagesMovieContext _context;

        public IndexModel(RazorpagesMovie.Data.RazorpagesMovieContext context)
        {
            _context = context;
        }

        public IList<Song> Song { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Song != null)
            {
                Song = await _context.Song.ToListAsync();
            }
        }
    }
}
