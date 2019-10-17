using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDRoles
    {
        public string Utilisateur { get; set; }
        public string TransactionCode { get; set; }
        public int Mode { get; set; }
        public DateTime DateMaj { get; set; }

        public virtual LDCommandes TransactionCodeNavigation { get; set; }
    }
}
