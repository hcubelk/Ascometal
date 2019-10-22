using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_ROULEAUX")]
    public partial class LDRouleaux
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string NomTable { get; set; }
        public int? Etat { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
    }
}