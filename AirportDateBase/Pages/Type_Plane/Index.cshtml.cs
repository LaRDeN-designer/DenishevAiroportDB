using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AirportDateBase.Data;
using AirportDateBase.Models;

namespace AirportDateBase.Pages.Type_Plane
{
    public class IndexModel : PageModel
    {
        private readonly AirportDateBase.Data.AirportDateBaseContext _context;

        public IndexModel(AirportDateBase.Data.AirportDateBaseContext context)
        {
            _context = context;
        }

        public IList<Models.Type_plane> Type_plane { get;set; }

        public async Task OnGetAsync()
        {
            Type_plane = await _context.Type_plane.ToListAsync();
        }
    }
}
