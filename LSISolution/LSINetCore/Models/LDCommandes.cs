using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSINetCore.Models
{
    public partial class LDCommandes
    {
        public LDCommandes()
        {
            LDRoles = new HashSet<LDRoles>();
        }
        [Key]
        public string Code { get; set; }
        public string Libelle { get; set; }
        public DateTime? DateMaj { get; set; }
        public bool? Crb { get; set; }
        public bool? Log { get; set; }
        public bool? Administration { get; set; }

        public virtual ICollection<LDRoles> LDRoles { get; set; }
    }
}
