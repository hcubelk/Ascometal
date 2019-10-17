using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDReleveTemperature
    {
        public int Id { get; set; }
        public int Temperature { get; set; }
        public int AdressesTemperatureId { get; set; }
        public DateTime? DateMaj { get; set; }

        public virtual LPAdressesTemperature AdressesTemperature { get; set; }
    }
}
