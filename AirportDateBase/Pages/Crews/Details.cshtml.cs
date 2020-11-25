using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AirportDateBase.Data;
using AirportDateBase.Models;

namespace AirportDateBase.Pages.Crews
{
    public class DetailsModel : PageModel
    {
        private readonly AirportDateBase.Data.AirportDateBaseContext _context;

        public DetailsModel(AirportDateBase.Data.AirportDateBaseContext context)
        {
            _context = context;
        }

        public Models.Crew Crew { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Crew = await _context.Crew.FirstOrDefaultAsync(m => m.ID == id);

            if (Crew == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
