using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LD1500tCamera
    {
        public int IdCamera { get; set; }
        public string Of { get; set; }
        public int NumeroLingot { get; set; }
        public int RangPassageLaminoir { get; set; }
        public int? ChutageTete { get; set; }
        public int? ChutagePied { get; set; }
        public int? ChutageTeteCalculer { get; set; }
        public int? ChutagePiedCalculer { get; set; }
        public int? NombreCoupe { get; set; }
        public DateTime? DatePassage1500T { get; set; }
        public string VideoCamera1 { get; set; }
        public string VideoCamera2 { get; set; }
        public DateTime? DateDebutVideo { get; set; }
        public DateTime? DateFinVideo { get; set; }
    }
}
