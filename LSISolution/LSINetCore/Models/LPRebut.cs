using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPRebut
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public DateTime? DateMaj { get; set; }
    }
}
