using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSINetCore.Models
{
    public partial class LDConsignes
    {
        [Key]
        public string Of { get; set; }
        [Key]
        public string CodeOperation { get; set; }
        public string CodeConsigne { get; set; }
        public string LibelleConsigne { get; set; }
        [Key]
        public int TypeConsigne { get; set; }
        public int SizeCodeConsigne { get; set; }
        [Key]
        public bool ConsigneGpao { get; set; }
    }
}
