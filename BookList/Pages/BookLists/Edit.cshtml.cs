using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList.Pages.BookLists
{
    public class EditModel : PageModel
    {
        private BlDbContext _db;

        public EditModel(BlDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Book book { get; set; }
        public async Task OnGet(int id)
        {
            book = await _db.Book.FindAsync(id);
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var DBComingBook = await _db.Book.FindAsync(book.Id);
                DBComingBook.BookName = book.BookName;
                DBComingBook.Author = book.Author;
                DBComingBook.ISBN = book.ISBN;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");


                    }
             return RedirectToPage();
            
        }
    }
}
