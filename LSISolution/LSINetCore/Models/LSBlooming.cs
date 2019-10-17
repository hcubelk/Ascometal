using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LSBlooming
    {
        public int Id { get; set; }
        public string Of { get; set; }
        public string NumLingot { get; set; }
        public string Profil { get; set; }
        public decimal? Section { get; set; }
        public string Montage { get; set; }
        public DateTime? TopDebutLaminage { get; set; }
        public DateTime? TopFinLaminage { get; set; }
        public int? CadenceT { get; set; }
        public decimal? Poids { get; set; }
        public string Scarfing { get; set; }
        public string LaminageControle { get; set; }
        public bool? IsOfessai { get; set; }
        public bool? IsCouleeChaude { get; set; }
    }
}
