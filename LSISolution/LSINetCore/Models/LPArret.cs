using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSINetCore.Models
{
    public partial class LPArret
    {
        [Key]
        public int IdArret { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string Affectation { get; set; }
        public string Type { get; set; }
        public string Categorie { get; set; }
        public int Priorite { get; set; }
        public DateTime DateMaj { get; set; }
    }
}
