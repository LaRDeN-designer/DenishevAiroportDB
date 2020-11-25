using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AirportDateBase.Data;
using AirportDateBase.Models;

namespace AirportDateBase.Pages.Tickets
{
    public class IndexModel : PageModel
    {
        private readonly AirportDateBase.Data.AirportDateBaseContext _context;

        public IndexModel(AirportDateBase.Data.AirportDateBaseContext context)
        {
            _context = context;
        }

        public IList<Models.Tickets> Tickets { get;set; }
        public IList<Models.Flight> Flight { get; set; }

        public async Task OnGetAsync()
        {
            Tickets = await _context.Tickets.ToListAsync();
            Flight = await _context.Flight.ToListAsync();
        }
    }
}
