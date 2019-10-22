using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_PROFIL_PRODUIT")]
    public partial class LPProfilProduit
    {
        public LPProfilProduit()
        {
            LDOrdreFabrication = new HashSet<LDOrdreFabrication>();
        }

        [Column("ID")]
        [StringLength(3)]
        public string Id { get; set; }
        [Required]
        public string Libelle { get; set; }

        [InverseProperty("ProfilProduitNavigation")]
        public virtual ICollection<LDOrdreFabrication> LDOrdreFabrication { get; set; }
    }
}