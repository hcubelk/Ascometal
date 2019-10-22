using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_ANOMALIES")]
    public partial class LDAnomalies
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(6)]
        public string IdCoulee { get; set; }
        [StringLength(50)]
        public string Reperage { get; set; }
        [StringLength(250)]
        public string Lingots { get; set; }
        [StringLength(100)]
        public string Action { get; set; }
        [StringLength(100)]
        public string Detail { get; set; }
        public bool? Anomalie { get; set; }
        public bool? PriseEnCompte { get; set; }
        public bool? Visualiser { get; set; }
        [StringLength(3)]
        public string Enregistrement { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DerniereModif { get; set; }

        [ForeignKey("IdCoulee")]
        [InverseProperty("LDAnomalies")]
        public virtual LDCoulee IdCouleeNavigation { get; set; }
        [ForeignKey("Id")]
        [InverseProperty("LDAnomalies")]
        public virtual LPAnomalies IdNavigation { get; set; }
    }
}