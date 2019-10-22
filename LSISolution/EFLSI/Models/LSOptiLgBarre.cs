using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_S_OPTI_LG_BARRE")]
    public partial class LSOptiLgBarre
    {
        public int Id { get; set; }
        [Required]
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        [StringLength(2)]
        public string Rang { get; set; }
        [Column("PDF")]
        [StringLength(8)]
        public string Pdf { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal PositionButee { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal PositionScieFixe { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal PositionScieMobile { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal LgSecurite { get; set; }
        public int NbBrTotal { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal LgBrCourte { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal LgChutage { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal LgTot { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal LgCoupe { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal LgBrMini { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal LgOpti { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal LgBrMaxi { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal LgRestante { get; set; }
        public int NbBrCourte { get; set; }
        public int NbBrMax { get; set; }
        public int NbBrMin { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal LgUtil { get; set; }
        public int NbOpti { get; set; }
    }
}