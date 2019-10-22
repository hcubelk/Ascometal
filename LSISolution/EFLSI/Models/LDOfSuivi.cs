using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_OF_SUIVI")]
    public partial class LDOfSuivi
    {
        [Key]
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        public int Rang { get; set; }

        [ForeignKey("Of")]
        [InverseProperty("LDOfSuivi")]
        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}