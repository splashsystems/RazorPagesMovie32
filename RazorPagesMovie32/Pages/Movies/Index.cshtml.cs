using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie32.Data;
using RazorPagesMovie32.Models;

namespace RazorPagesMovie32.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie32.Data.RazorPagesMovie32Context _context;

        public IndexModel(RazorPagesMovie32.Data.RazorPagesMovie32Context context)
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
