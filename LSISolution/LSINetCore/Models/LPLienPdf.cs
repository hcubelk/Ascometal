using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPLienPdf
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Lien { get; set; }
        public DateTime DateMaj { get; set; }
    }
}
