using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_COMMANDES")]
    public partial class LDCommandes
    {
        public LDCommandes()
        {
            LDRoles = new HashSet<LDRoles>();
        }

        [Key]
        [StringLength(8)]
        public string Code { get; set; }
        [Required]
        public string Libelle { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
        [Column("CRB")]
        public bool? Crb { get; set; }
        public bool? Log { get; set; }
        [Required]
        public bool? Administration { get; set; }

        [InverseProperty("TransactionCodeNavigation")]
        public virtual ICollection<LDRoles> LDRoles { get; set; }
    }
}