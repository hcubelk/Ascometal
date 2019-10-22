using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_CONSIGNES_PRECHAUFFAGE_PARTICULIER")]
    public partial class LPConsignesPrechauffageParticulier
    {
        [Key]
        public int Code { get; set; }
        [Required]
        [StringLength(30)]
        public string Libelle { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
    }
}