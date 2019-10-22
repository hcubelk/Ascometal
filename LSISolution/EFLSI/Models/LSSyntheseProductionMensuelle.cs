using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_S_SYNTHESE_PRODUCTION_MENSUELLE")]
    public partial class LSSyntheseProductionMensuelle
    {
        public long Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCloture { get; set; }
        [Column("HJ")]
        public int? Hj { get; set; }
        [Column("HO")]
        public int? Ho { get; set; }
        [Column("HTA")]
        public int? Hta { get; set; }
        [Column("HTC")]
        public int? Htc { get; set; }
        [Column("HTP")]
        public int? Htp { get; set; }
        [Column("HTH")]
        public int? Hth { get; set; }
        [Column("HTI")]
        public int? Hti { get; set; }
        [Column("HTR")]
        public int? Htr { get; set; }
        [Column("HTM")]
        public int? Htm { get; set; }
        [Column("HTQ")]
        public int? Htq { get; set; }
        [Column("HTD")]
        public int? Htd { get; set; }
        [Column("HTT")]
        public int? Htt { get; set; }
        [Column("HTG")]
        public int? Htg { get; set; }
        [Column("HMB")]
        public int? Hmb { get; set; }
        [Column("HMN")]
        public int? Hmn { get; set; }
        [Column("HMM")]
        public int? Hmm { get; set; }
        public int JalLamT { get; set; }
        public int JalLamR { get; set; }
        public int NbTotalLgtPrevu { get; set; }
        public int NbTotalLgtLam { get; set; }
        public int DureeTotalLamPrevu { get; set; }
        public int DureeTotalLamReel { get; set; }
        public int TonChauf { get; set; }
        public int TonChaud { get; set; }
        public int TonFroid { get; set; }
        public int TonLam { get; set; }
        public int TonReb { get; set; }
        public int TonEss { get; set; }
        public int? CadenceT { get; set; }
    }
}