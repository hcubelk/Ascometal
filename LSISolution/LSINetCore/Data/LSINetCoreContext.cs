using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LSINetCore.Models
{
    public class LSINetCoreContext : DbContext
    {
        public LSINetCoreContext(DbContextOptions<LSINetCoreContext> options) : base(options) { }

        //public DbSet<LSINetCore.Models.Movie> Movie { get; set; }
        public DbSet<LDEtatStock> L_D_ETAT_STOCK { get; set; }
    }
}
