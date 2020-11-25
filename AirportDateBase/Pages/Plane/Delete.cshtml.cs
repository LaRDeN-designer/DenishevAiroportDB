using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AirportDateBase.Data;
using AirportDateBase.Models;

namespace AirportDateBase.Pages.Plane
{
    public class DeleteModel : PageModel
    {
        private readonly AirportDateBase.Data.AirportDateBaseContext _context;

        public DeleteModel(AirportDateBase.Data.AirportDateBaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Plane Plane { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Plane = await _context.Plane.FirstOrDefaultAsync(m => m.ID == id);

            if (Plane == null)
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

            Plane = await _context.Plane.FindAsync(id);

            if (Plane != null)
            {
                _context.Plane.Remove(Plane);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
