using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LSINetCore.Models;

namespace LSINetCore.Pages.EtatStocks
{
    public class CreateModel : PageModel
    {
        private readonly LSINetCore.Models.AscoLSIContext _context;

        public CreateModel(LSINetCore.Models.AscoLSIContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public LDEtatStock LDEtatStock { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.LDEtatStock.Add(LDEtatStock);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
