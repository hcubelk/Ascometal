using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDFileQueue
    {
        public int Id { get; set; }
        public string PathName { get; set; }
        public int Status { get; set; }
        public string ServeurMac { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime? DateUpdate { get; set; }
        public int? Ofcount { get; set; }
        public int? Oftotal { get; set; }
        public string CodeEmetteur { get; set; }
        public string Type { get; set; }
    }
}
