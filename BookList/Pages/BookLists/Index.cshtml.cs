
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookList.Pages.BookLists
{
    public class IndexModel : PageModel
    {
        private readonly BlDbContext _db;

        public IndexModel(BlDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Book>
    Books
        { get; set; }

        public async Task OnGet()
        {
            Books = await _db.Book.ToListAsync();
        }
    }
}