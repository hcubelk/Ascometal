using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LSINetCore.Models;

namespace LSINetCore.Pages.Pits
{
    public class IndexModel : PageModel
    {
        private readonly LSINetCoreContext _context;

        public IndexModel(LSINetCoreContext context)
        {
            _context = context;
        }

        public IList<LDOrdreFabrication> OrdreFabrications { get;set; }
        //public IList<Pits> Pits { get; set; }

        public async Task OnGetAsync()
        {
            //Pits = await    (
            //                from of     in _context.L_D_ORDRE_FABRICATION
            //                join cs     in _context.L_D_CONSIGNES                       on of.Of equals cs.Of 
            //                join cp     in _context.L_D_CONSIGNES                       on of.Of equals cp.Of
            //                where of.Etat == 1 || of.Etat == 5
            //                && cs.TypeConsigne == 7
            //                && cp.TypeConsigne == 3
            //                select new Pits(of, cs, cp)
            //                )
            //                .ToListAsync();

            OrdreFabrications = await   (
                                        from of in _context.L_D_ORDRE_FABRICATION
                                        where of.Etat == 1 || of.Etat == 5
                                        select of
                                        )
                                        .ToListAsync();
        }
    }
}
