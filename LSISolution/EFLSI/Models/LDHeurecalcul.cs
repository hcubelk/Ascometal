using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_HEURECALCUL")]
    public partial class LDHeurecalcul
    {
        public long Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
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
    }
}