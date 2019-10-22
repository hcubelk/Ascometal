using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_ZONE_STOCK_LAMINOIR")]
    public partial class LPZoneStockLaminoir
    {
        public LPZoneStockLaminoir()
        {
            LPLieuxStockLaminoir = new HashSet<LPLieuxStockLaminoir>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Libelle { get; set; }

        [InverseProperty("IdzoneNavigation")]
        public virtual ICollection<LPLieuxStockLaminoir> LPLieuxStockLaminoir { get; set; }
    }
}