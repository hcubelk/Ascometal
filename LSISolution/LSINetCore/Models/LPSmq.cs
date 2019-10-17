using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPSmq
    {
        public int Id { get; set; }
        public string StandardM { get; set; }
        public string Action { get; set; }
        public DateTime DateMaj { get; set; }
    }
}
