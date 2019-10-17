using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPEquipes
    {
        public int Id { get; set; }
        public string Contremaitre { get; set; }
        public string IdEquipe { get; set; }
        public DateTime DateMaj { get; set; }
    }
}
