using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDConsignes
    {
        public string Of { get; set; }
        public string CodeOperation { get; set; }
        public string CodeConsigne { get; set; }
        public string LibelleConsigne { get; set; }
        public int TypeConsigne { get; set; }
        public int SizeCodeConsigne { get; set; }
        public bool ConsigneGpao { get; set; }
    }
}
