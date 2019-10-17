using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDStockPso
    {
        public int Id { get; set; }
        public string IdCoulee { get; set; }
        public int NumeroLingot { get; set; }
        public DateTime? DateEntree { get; set; }
        public DateTime? DateSortie { get; set; }
        public int IdLieu { get; set; }
        public int StockageTemporaire { get; set; }
        public DateTime? DateStockageTemporaire { get; set; }

        public virtual LDCoulee IdCouleeNavigation { get; set; }
        public virtual LDPso LDPso { get; set; }
    }
}
