using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_LIEUX_STOCK_LAMINOIR")]
    public partial class LPLieuxStockLaminoir
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(15)]
        public string Lieu { get; set; }
        [Required]
        [StringLength(25)]
        public string Libelle { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
        [Column("IDZone")]
        public int? Idzone { get; set; }

        [ForeignKey("Idzone")]
        [InverseProperty("LPLieuxStockLaminoir")]
        public virtual LPZoneStockLaminoir IdzoneNavigation { get; set; }
    }
}