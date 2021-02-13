using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Models
{
    public class BlDbContext:DbContext
    {
        public BlDbContext(DbContextOptions<BlDbContext>options):base(options)
        {

        }
        public DbSet<Book> Book { get; set; }

        internal Task<Book> FindAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
