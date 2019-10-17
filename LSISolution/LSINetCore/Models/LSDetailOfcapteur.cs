using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LSDetailOfcapteur
    {
        public string Capteur { get; set; }
        public DateTime PremiereActivation { get; set; }
        public DateTime DerniereActivation { get; set; }
        public int? NbOk { get; set; }
        public int? NbDef { get; set; }
    }
}
