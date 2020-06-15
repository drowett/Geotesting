using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using GeographyTesting.web;

namespace GeographyTesting.web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly LocationsContext _context;

        public IndexModel(LocationsContext context)
        {
            _context = context;
        }

        public IList<Location> Locations;

        public void OnGet()
        {
            Locations = _context.Locations.ToList();
        }
    }
}
