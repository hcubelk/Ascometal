using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_MESURE")]
    public partial class LDMesure
    {
        public int Id { get; set; }
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        [Column("PDF")]
        [StringLength(10)]
        public string Pdf { get; set; }
        public long? LongueurBarre { get; set; }
        [Column("CompteurDD8")]
        public long? CompteurDd8 { get; set; }
        [Column("CompteurDD9")]
        public long? CompteurDd9 { get; set; }
        [Column("CompteurDD9B")]
        public long? CompteurDd9b { get; set; }
        [Column("CompteurDD10")]
        public long? CompteurDd10 { get; set; }
        [Column("CompteurDD11A")]
        public long? CompteurDd11a { get; set; }
        [Column("CompteurDD11B")]
        public long? CompteurDd11b { get; set; }
        [Column("CompteurDD12")]
        public long? CompteurDd12 { get; set; }
        [Column("CompteurDD12B")]
        public long? CompteurDd12b { get; set; }
        [Column("CompteurDD13")]
        public long? CompteurDd13 { get; set; }
        [Column("CompteurDD14")]
        public long? CompteurDd14 { get; set; }
        [Column("CompteurDE1")]
        public long? CompteurDe1 { get; set; }
        [Column("CompteurDD15")]
        public long? CompteurDd15 { get; set; }
        [Column("CompteurDE2A")]
        public long? CompteurDe2a { get; set; }
        [Column("CompteurDE2B")]
        public long? CompteurDe2b { get; set; }
        public long? CompteurTotal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
    }
}