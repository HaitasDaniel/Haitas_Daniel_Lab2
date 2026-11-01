using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Haitas_Daniel_Lab2.Models;

namespace Haitas_Daniel_Lab2.Pages.PublisherPages;

public class IndexModel : PageModel
{
    private readonly Haitas_Daniel_Lab2Context _context;

    public IndexModel(Haitas_Daniel_Lab2Context context)
    {
        _context = context;
    }

    public IList<Publisher> Publisher { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Publisher = await _context.Publisher.ToListAsync();
    }
}
