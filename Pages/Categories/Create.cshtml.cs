using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Neag_Andreea_Lab8.Data;
using Neag_Andreea_Lab8.Models;

namespace Neag_Andreea_Lab8.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Neag_Andreea_Lab8.Data.Neag_Andreea_Lab8Context _context;

        public CreateModel(Neag_Andreea_Lab8.Data.Neag_Andreea_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BookID"] = new SelectList(_context.Books, "ID", "ID");
        ViewData["CategoryID"] = new SelectList(_context.Set<Category>(), "ID", "ID");
            return Page();
        }

        [BindProperty]
        public BookCategory BookCategory { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BookCategory.Add(BookCategory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
