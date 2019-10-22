using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_MAM_QUAL")]
    public partial class LDMamQual
    {
        [Key]
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        [Column("MMGOF")]
        public int? Mmgof { get; set; }
        [Column("MMTROF")]
        public int? Mmtrof { get; set; }
        [Column("MMTTOF")]
        public int? Mmttof { get; set; }
        [Column("DateIPL", TypeName = "datetime")]
        public DateTime? DateIpl { get; set; }
        public int? PoidsRebute { get; set; }
        public int? PoidsChuteTheorique { get; set; }
        public int? PoidsEnfourne { get; set; }
        public int? NbBarresCellules { get; set; }
        [Column("NbBarresEVC")]
        public int? NbBarresEvc { get; set; }
        public int? ChutagePied { get; set; }
        [StringLength(3)]
        public string NumeroMontage { get; set; }
        [StringLength(25)]
        public string IdEquipe { get; set; }
        public int? PoidsMise { get; set; }
        public int? TempsChauffe { get; set; }
        public int? TempsLaminage { get; set; }
        public int? PoidsEvacue { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal? LgDeveloppee { get; set; }
        [StringLength(1)]
        public string ConsigneScarfing { get; set; }
        public int? ChutageTete { get; set; }
        public int? NbBarresCourtes { get; set; }
        [StringLength(1)]
        public string CodePesee { get; set; }
    }
}