using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LSINetCore.Models;

namespace LSINetCore.Pages.EtatStocks
{
    public class DetailsModel : PageModel
    {
        private readonly LSINetCore.Models.AscoLSIContext _context;

        public DetailsModel(LSINetCore.Models.AscoLSIContext context)
        {
            _context = context;
        }

        public LDEtatStock LDEtatStock { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LDEtatStock = await _context.LDEtatStock.FirstOrDefaultAsync(m => m.Lieu == id);

            if (LDEtatStock == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
