using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AirportDateBase.Models;

namespace AirportDateBase.Pages.FilReq.Filter
{
    public class FilterPersDepModel : PageModel
    {
            private readonly AirportDateBase.Data.AirportDateBaseContext _context;

            public FilterPersDepModel(AirportDateBase.Data.AirportDateBaseContext context)
            {
                _context = context;
            }

            public IList<Models.Employee> Employee { get; set; }
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

                Employee = await _context.Employee.Where(m => m.Posts_ID == Posts.ID).ToListAsync();
                return Page();
            }
    }
}
