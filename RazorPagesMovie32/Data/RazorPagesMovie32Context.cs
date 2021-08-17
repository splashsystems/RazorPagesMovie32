using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie32.Models;

namespace RazorPagesMovie32.Data
{
    public class RazorPagesMovie32Context : DbContext
    {
        public RazorPagesMovie32Context (DbContextOptions<RazorPagesMovie32Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie32.Models.Movie> Movie { get; set; }
    }
}
