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
    public class DetailsModel : PageModel
    {
        private readonly AirportDateBase.Data.AirportDateBaseContext _context;

        public DetailsModel(AirportDateBase.Data.AirportDateBaseContext context)
        {
            _context = context;
        }

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
    }
}
