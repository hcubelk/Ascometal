using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LSINetCore.Models
{
    public partial class LDEtatStock
    {
        [Key]
        public string Lieu { get; set; }
        public DateTime? DatePremiereEntree { get; set; }
        public string Coulee { get; set; }
        public DateTime? DateDerniereSortie { get; set; }
        public int? NbStock { get; set; }
        public DateTime DateMaj { get; set; }
        public string Pso { get; set; }
        public int? PoidsTotal { get; set; }
        public int PoidsUnitaire { get; set; }
    }
}
