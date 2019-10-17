using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDAsiSuivi
    {
        public int Id { get; set; }
        public string Coulee { get; set; }
        public string Of { get; set; }
        public string NoEnregistrement { get; set; }
        public DateTime DateMaj { get; set; }
        public string Commande { get; set; }
        public string Message { get; set; }
    }
}
