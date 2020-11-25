using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AirportDateBase.Data;
using AirportDateBase.Models;

namespace AirportDateBase.Pages.Plane
{
    public class CreateModel : PageModel
    {
        private readonly AirportDateBase.Data.AirportDateBaseContext _context;

        public CreateModel(AirportDateBase.Data.AirportDateBaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Plane Plane { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Plane.Add(Plane);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
