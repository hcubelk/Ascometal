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
    public class IndexModel : PageModel
    {
        private readonly LSINetCoreContext _context;

        public IndexModel(LSINetCoreContext context)
        {
            _context = context;
        }

        public IList<LDEtatStock> LDEtatStock { get;set; }

        public async Task OnGetAsync()
        {
            LDEtatStock = await _context.L_D_ETAT_STOCK.ToListAsync();
        }
    }
}
