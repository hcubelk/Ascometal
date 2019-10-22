using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_ROLES")]
    public partial class LDRoles
    {
        [StringLength(30)]
        public string Utilisateur { get; set; }
        [StringLength(8)]
        public string TransactionCode { get; set; }
        public int Mode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateMaj { get; set; }

        [ForeignKey("TransactionCode")]
        [InverseProperty("LDRoles")]
        public virtual LDCommandes TransactionCodeNavigation { get; set; }
    }
}