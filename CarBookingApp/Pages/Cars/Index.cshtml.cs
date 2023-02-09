using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarBookingApp.Data.Data;
using CarBookingApp.Data.Model;

namespace CarBookingApp.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly CarBookingApp.Data.Data.CarBookDbContext _context;

        public IndexModel(CarBookingApp.Data.Data.CarBookDbContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Cars != null)
            {
                Car = await _context.Cars.ToListAsync();
            }
            else
            {
                NotFound();
            }
        }
    }
}
