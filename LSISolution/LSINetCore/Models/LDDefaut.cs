using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDDefaut
    {
        public int Id { get; set; }
        public int NumeroLingot { get; set; }
        public string Coulee { get; set; }
        public int ParamDefautId { get; set; }

        public virtual LDPso LDPso { get; set; }
    }
}
