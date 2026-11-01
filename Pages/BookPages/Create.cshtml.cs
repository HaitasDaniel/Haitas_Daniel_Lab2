using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Haitas_Daniel_Lab2.Models;

namespace Haitas_Daniel_Lab2.Pages.BookPages;

public class CreateModel : PageModel
{
    private readonly Haitas_Daniel_Lab2Context _context;

    public CreateModel(Haitas_Daniel_Lab2Context context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        PopulateLists();
        return Page();
    }

    [BindProperty]
    public Book Book { get; set; } = default!;

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            PopulateLists();
            return Page();
        }

        _context.Book.Add(Book);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }

    // umple listele derulante (dropdown) cu edituri si autori
    private void PopulateLists()
    {
        ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID", "PublisherName");
        ViewData["AuthorID"] = new SelectList(
            _context.Set<Author>().Select(a => new { a.ID, FullName = a.FirstName + " " + a.LastName }),
            "ID", "FullName");
    }
}
