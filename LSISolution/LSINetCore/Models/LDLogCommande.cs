using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDLogCommande
    {
        public int Id { get; set; }
        public string Commande { get; set; }
        public string Message { get; set; }
        public string Of { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public int NumLingot { get; set; }
        public bool? Trace { get; set; }
    }
}
