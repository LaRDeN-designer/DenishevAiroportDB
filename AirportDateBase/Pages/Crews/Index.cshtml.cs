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
    public class IndexModel : PageModel
    {
        private readonly AirportDateBase.Data.AirportDateBaseContext _context;

        public IndexModel(AirportDateBase.Data.AirportDateBaseContext context)
        {
            _context = context;
        }

        public IList<Models.Crew> Crew { get;set; }
        public IList<Models.Employee> Employee { get; set; }
        public IList<Models.Posts> Posts { get; set; }

        public async Task OnGetAsync()
        {
            Crew = await _context.Crew.ToListAsync();
            Employee = await _context.Employee.ToListAsync();
            Posts = await _context.Posts.ToListAsync();
        }
    }
}
