using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages2.Models;
using RazorPages2.Services;
using System.Collections.Generic;

namespace RazorPages2.Pages
{
    public class LibraryModel : PageModel
    {
        [BindProperty]
        public Book NewBook { get; set; }

        public List<Book> Books { get; private set; }

        public LibraryModel()
        {
            Books = BookServices.GetAll();
            NewBook = new Book();
        }

        public void OnGet()
        {
            Books = BookServices.GetAll();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Books = BookServices.GetAll();
                return Page();
            }

            BookServices.Add(NewBook);
            return RedirectToPage();
        }

        public IActionResult OnPostDelete(int id)
        {
            BookServices.Delete(id);
            return RedirectToPage();
        }
    }
}
