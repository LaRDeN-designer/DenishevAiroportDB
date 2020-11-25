using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AirportDateBase.Pages.FilReq.Filter
{
    public class FilterTypePlaneModel : PageModel
    {
            private readonly AirportDateBase.Data.AirportDateBaseContext _context;

            public FilterTypePlaneModel(AirportDateBase.Data.AirportDateBaseContext context)
            {
                _context = context;
            }

            public IList<Models.Plane> Plane { get; set; }
            public Models.Type_plane Type_plane { get; set; }
            public IList<Models.Employee> Employee { get; set; }

            public async Task<IActionResult> OnGetAsync(long? id)
            {
            if (id == null)
                {
                return NotFound();
                }
                Type_plane = await _context.Type_plane.FirstOrDefaultAsync(m => m.ID == id);
                
            if (Type_plane == null)
                {
                    return NotFound();
                }
                Plane = await _context.Plane.Where(m => m.Type_ID == Type_plane.ID).ToListAsync();
                Employee = await _context.Employee.ToListAsync();
            return Page();
            }
        }
    }
