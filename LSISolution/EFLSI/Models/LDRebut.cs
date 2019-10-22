using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_REBUT")]
    public partial class LDRebut
    {
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        public int RangLingotPassageAuLaminoir { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateRebut { get; set; }
        public int Nombre { get; set; }
        [Required]
        public string CodeRebut { get; set; }
        [Required]
        [StringLength(250)]
        public string Commentaire { get; set; }
        public int Poids { get; set; }
        public int Poste { get; set; }
        [Required]
        [StringLength(10)]
        public string Monture { get; set; }
        public int TypeCage { get; set; }
        [StringLength(10)]
        public string Cage { get; set; }
        [StringLength(25)]
        public string IdEquipe { get; set; }
        [Column("PDF")]
        [StringLength(10)]
        public string Pdf { get; set; }

        [ForeignKey("Of")]
        [InverseProperty("LDRebut")]
        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}