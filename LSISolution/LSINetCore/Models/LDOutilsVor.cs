using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSINetCore.Models
{
    public partial class LDOutilsVor
    {
        [Key]
        public string Zone { get; set; }
        public DateTime DateEnvoi { get; set; }
        public string Code { get; set; }
        public int Vor { get; set; }
        public string Commentaires { get; set; }
        public string Of { get; set; }
    }
}
