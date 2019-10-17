using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPAdressesTemperature
    {
        public LPAdressesTemperature()
        {
            LDReleveTemperature = new HashSet<LDReleveTemperature>();
        }

        public int Id { get; set; }
        public string Outil { get; set; }
        public string Libelle { get; set; }
        public string AdresseIp { get; set; }
        public int Esclave { get; set; }
        public string Modbus { get; set; }
        public int? ValeurMini { get; set; }
        public int? ValeurMax { get; set; }
        public int? ValeurAlarme { get; set; }
        public int? ValeurSeuil { get; set; }
        public DateTime? DateMaj { get; set; }
        public string Code { get; set; }

        public virtual ICollection<LDReleveTemperature> LDReleveTemperature { get; set; }
    }
}
