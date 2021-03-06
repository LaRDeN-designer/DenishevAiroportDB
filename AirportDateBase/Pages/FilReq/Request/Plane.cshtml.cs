using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AirportDateBase.Pages.FilReq.Request
{
    public class PlaneModel : PageModel
    {
            private readonly AirportDateBase.Data.AirportDateBaseContext _context;

            public PlaneModel(AirportDateBase.Data.AirportDateBaseContext context)
            {
                _context = context;
            }

            public IList<Models.Plane> Plane { get; set; }
            public IList<Models.Type_plane> Type_plane { get; set; }
            public IList<Models.Employee> Employee { get; set; }

            public async Task OnGetAsync()
            {
                Plane = await _context.Plane.ToListAsync();
                Type_plane = await _context.Type_plane.ToListAsync();
                Employee = await _context.Employee.ToListAsync();
            }
        }
    }
