using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AirportDateBase.Data;
using AirportDateBase.Models;

namespace AirportDateBase.Pages.Posts
{
    public class DeleteModel : PageModel
    {
        private readonly AirportDateBase.Data.AirportDateBaseContext _context;

        public DeleteModel(AirportDateBase.Data.AirportDateBaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Posts Posts { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Posts = await _context.Posts.FirstOrDefaultAsync(m => m.ID == id);

            if (Posts == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Posts = await _context.Posts.FindAsync(id);

            if (Posts != null)
            {
                _context.Posts.Remove(Posts);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
