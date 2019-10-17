using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPPredecesseurZone
    {
        public int Id { get; set; }
        public string Zone { get; set; }
        public string Libelle { get; set; }
        public string Destination1 { get; set; }
        public string Destination2 { get; set; }
        public string Destination3 { get; set; }
    }
}
