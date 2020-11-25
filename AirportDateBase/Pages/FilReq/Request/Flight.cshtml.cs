using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AirportDateBase.Pages.FilReq.Request
{
    public class FlightModel : PageModel
    {
            private readonly AirportDateBase.Data.AirportDateBaseContext _context;

            public FlightModel(AirportDateBase.Data.AirportDateBaseContext context)
            {
                _context = context;
            }

            public IList<Models.Flight> Flight { get; set; }
            public IList<Models.Plane> Plane { get; set; }
            public IList<Models.Crew> Crew { get; set; }

            public async Task OnGetAsync()
            {
                Flight = await _context.Flight.ToListAsync();
                Plane = await _context.Plane.ToListAsync();
                Crew = await _context.Crew.ToListAsync();
            }
        }
    }
