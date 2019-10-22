using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_STOCK_PSO")]
    public partial class LDStockPso
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(6)]
        public string IdCoulee { get; set; }
        public int NumeroLingot { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateEntree { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateSortie { get; set; }
        public int IdLieu { get; set; }
        public int StockageTemporaire { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateStockageTemporaire { get; set; }

        [ForeignKey("IdCoulee")]
        [InverseProperty("LDStockPso")]
        public virtual LDCoulee IdCouleeNavigation { get; set; }
        [ForeignKey("NumeroLingot,IdCoulee")]
        [InverseProperty("LDStockPso")]
        public virtual LDPso LDPso { get; set; }
    }
}