using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AirportDateBase.Pages.FilReq.Filter
{
    public class FilterTicketsModel : PageModel
    {
            private readonly AirportDateBase.Data.AirportDateBaseContext _context;

            public FilterTicketsModel(AirportDateBase.Data.AirportDateBaseContext context)
            {
                _context = context;
            }

            public IList<Models.Tickets> Tickets { get; set; }
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
                Tickets = await _context.Tickets.Where(m => m.Flight_ID == Flight.ID).ToListAsync();
            return Page();
            }
        }
    }

