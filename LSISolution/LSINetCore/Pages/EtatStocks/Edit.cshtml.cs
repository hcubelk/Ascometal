using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LSINetCore.Models;

namespace LSINetCore.Pages.EtatStocks
{
    public class EditModel : PageModel
    {
        private readonly LSINetCore.Models.AscoLSIContext _context;

        public EditModel(LSINetCore.Models.AscoLSIContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(LDEtatStock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LDEtatStockExists(LDEtatStock.Lieu))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LDEtatStockExists(string id)
        {
            return _context.LDEtatStock.Any(e => e.Lieu == id);
        }
    }
}
