using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_TEXT_OPERATIONS")]
    public partial class LPTextOperations
    {
        public LPTextOperations()
        {
            LDSectionchargeChutage = new HashSet<LDSectionchargeChutage>();
            LDSectionchargeDecoupe = new HashSet<LDSectionchargeDecoupe>();
            LDSectionchargeLingot = new HashSet<LDSectionchargeLingot>();
            LDSectionchargePits = new HashSet<LDSectionchargePits>();
            LDSectionchargePoidsmetrique = new HashSet<LDSectionchargePoidsmetrique>();
            LDSectionchargeRefroidissoirs = new HashSet<LDSectionchargeRefroidissoirs>();
            LDSectionchargeSvt = new HashSet<LDSectionchargeSvt>();
        }

        [Key]
        [StringLength(3)]
        public string CodeOperation { get; set; }
        [Required]
        public string LibelleConsigne { get; set; }

        [InverseProperty("CodeOperationNavigation")]
        public virtual ICollection<LDSectionchargeChutage> LDSectionchargeChutage { get; set; }
        [InverseProperty("CodeOperationNavigation")]
        public virtual ICollection<LDSectionchargeDecoupe> LDSectionchargeDecoupe { get; set; }
        [InverseProperty("CodeOperationNavigation")]
        public virtual ICollection<LDSectionchargeLingot> LDSectionchargeLingot { get; set; }
        [InverseProperty("CodeOperationNavigation")]
        public virtual ICollection<LDSectionchargePits> LDSectionchargePits { get; set; }
        [InverseProperty("CodeOperationNavigation")]
        public virtual ICollection<LDSectionchargePoidsmetrique> LDSectionchargePoidsmetrique { get; set; }
        [InverseProperty("CodeOperationNavigation")]
        public virtual ICollection<LDSectionchargeRefroidissoirs> LDSectionchargeRefroidissoirs { get; set; }
        [InverseProperty("CodeOperationNavigation")]
        public virtual ICollection<LDSectionchargeSvt> LDSectionchargeSvt { get; set; }
    }
}