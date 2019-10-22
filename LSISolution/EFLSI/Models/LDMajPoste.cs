using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_MAJ_POSTE")]
    public partial class LDMajPoste
    {
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        public int Poste { get; set; }
    }
}