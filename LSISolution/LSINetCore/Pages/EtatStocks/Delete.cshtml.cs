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
    public class DeleteModel : PageModel
    {
        private readonly LSINetCore.Models.AscoLSIContext _context;

        public DeleteModel(LSINetCore.Models.AscoLSIContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LDEtatStock = await _context.LDEtatStock.FindAsync(id);

            if (LDEtatStock != null)
            {
                _context.LDEtatStock.Remove(LDEtatStock);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
