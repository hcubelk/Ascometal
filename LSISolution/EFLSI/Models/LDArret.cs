using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_ARRET")]
    public partial class LDArret
    {
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateDebut { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateFin { get; set; }
        public string Commentaire { get; set; }
        [Required]
        [StringLength(3)]
        public string CodeArretReference { get; set; }
        public int Poste { get; set; }
        [StringLength(25)]
        public string OtCode { get; set; }
        public string OtObservation { get; set; }
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
    }
}