using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AirportDateBase.Data;
using AirportDateBase.Models;

namespace AirportDateBase.Pages.Flight
{
    public class DetailsModel : PageModel
    {
        private readonly AirportDateBase.Data.AirportDateBaseContext _context;

        public DetailsModel(AirportDateBase.Data.AirportDateBaseContext context)
        {
            _context = context;
        }

        public Models.Flight Flight { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Flight = await _context.Flight.FirstOrDefaultAsync(m => m.ID == id);

            if (Flight == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
