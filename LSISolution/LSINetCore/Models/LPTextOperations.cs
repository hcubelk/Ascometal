using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
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

        public string CodeOperation { get; set; }
        public string LibelleConsigne { get; set; }

        public virtual ICollection<LDSectionchargeChutage> LDSectionchargeChutage { get; set; }
        public virtual ICollection<LDSectionchargeDecoupe> LDSectionchargeDecoupe { get; set; }
        public virtual ICollection<LDSectionchargeLingot> LDSectionchargeLingot { get; set; }
        public virtual ICollection<LDSectionchargePits> LDSectionchargePits { get; set; }
        public virtual ICollection<LDSectionchargePoidsmetrique> LDSectionchargePoidsmetrique { get; set; }
        public virtual ICollection<LDSectionchargeRefroidissoirs> LDSectionchargeRefroidissoirs { get; set; }
        public virtual ICollection<LDSectionchargeSvt> LDSectionchargeSvt { get; set; }
    }
}
