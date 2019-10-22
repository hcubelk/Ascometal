using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_PARAMETRES_GENERAUX")]
    public partial class LPParametresGeneraux
    {
        [Key]
        [StringLength(10)]
        public string Code { get; set; }
        public string Libelle { get; set; }
        [Required]
        [StringLength(50)]
        public string TypeData { get; set; }
        [Required]
        [StringLength(50)]
        public string Valeur { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
        [StringLength(8)]
        public string Display { get; set; }
    }
}