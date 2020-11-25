using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AirportDateBase.Pages.FilReq
{
    public class IndexModel : PageModel
    {
        private readonly AirportDateBase.Data.AirportDateBaseContext _context;
        public IndexModel(AirportDateBase.Data.AirportDateBaseContext context)
        {
            _context = context;
        }
        public IList<SelectListItem> SelPost { get; set; }
        public IList<SelectListItem> PlaneType { get; set; }
        public IList<SelectListItem> TicketsType { get; set; }
        public IActionResult OnGet()
        {
            SelPost = _context.Posts.Select(p =>
            new SelectListItem
            {
                Value = p.ID.ToString(),
                Text = p.Name_Post
            }).ToList();

            PlaneType = _context.Type_plane.Select(p =>
            new SelectListItem
            {
                Value = p.ID.ToString(),
                Text = p.Name_plane
            }).ToList();

            TicketsType = _context.Flight.Select(p =>
            new SelectListItem
            {
                Value = p.ID.ToString(),
                Text = p.Arrival
            }).ToList();
            return Page();
        }
    }
}
