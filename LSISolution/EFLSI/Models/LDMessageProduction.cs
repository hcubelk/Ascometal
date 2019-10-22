using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_MESSAGE_PRODUCTION")]
    public partial class LDMessageProduction
    {
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(50)]
        public string NomUtilisateur { get; set; }
        [Required]
        [StringLength(50)]
        public string NomTerminal { get; set; }
        [Required]
        public string Message { get; set; }
        public int TypeMessage { get; set; }
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
    }
}