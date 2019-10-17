using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LSOptiLgBarre
    {
        public int Id { get; set; }
        public string Of { get; set; }
        public string Rang { get; set; }
        public string Pdf { get; set; }
        public DateTime Date { get; set; }
        public decimal PositionButee { get; set; }
        public decimal PositionScieFixe { get; set; }
        public decimal PositionScieMobile { get; set; }
        public decimal LgSecurite { get; set; }
        public int NbBrTotal { get; set; }
        public decimal LgBrCourte { get; set; }
        public decimal LgChutage { get; set; }
        public decimal LgTot { get; set; }
        public decimal LgCoupe { get; set; }
        public decimal LgBrMini { get; set; }
        public decimal LgOpti { get; set; }
        public decimal LgBrMaxi { get; set; }
        public decimal LgRestante { get; set; }
        public int NbBrCourte { get; set; }
        public int NbBrMax { get; set; }
        public int NbBrMin { get; set; }
        public decimal LgUtil { get; set; }
        public int NbOpti { get; set; }
    }
}
