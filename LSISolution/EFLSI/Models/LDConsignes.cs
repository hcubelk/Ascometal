using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_CONSIGNES")]
    public partial class LDConsignes
    {
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        [StringLength(3)]
        public string CodeOperation { get; set; }
        [Required]
        [StringLength(18)]
        public string CodeConsigne { get; set; }
        public string LibelleConsigne { get; set; }
        public int TypeConsigne { get; set; }
        public int SizeCodeConsigne { get; set; }
        [Column("ConsigneGPAO")]
        public bool ConsigneGpao { get; set; }
    }
}