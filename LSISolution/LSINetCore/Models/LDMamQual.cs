using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSINetCore.Models
{
    public partial class LDMamQual
    {
        [Key]
        public string Of { get; set; }
        public int? Mmgof { get; set; }
        public int? Mmtrof { get; set; }
        public int? Mmttof { get; set; }
        public DateTime? DateIpl { get; set; }
        public int? PoidsRebute { get; set; }
        public int? PoidsChuteTheorique { get; set; }
        public int? PoidsEnfourne { get; set; }
        public int? NbBarresCellules { get; set; }
        public int? NbBarresEvc { get; set; }
        public int? ChutagePied { get; set; }
        public string NumeroMontage { get; set; }
        public string IdEquipe { get; set; }
        public int? PoidsMise { get; set; }
        public int? TempsChauffe { get; set; }
        public int? TempsLaminage { get; set; }
        public int? PoidsEvacue { get; set; }
        public decimal? LgDeveloppee { get; set; }
        public string ConsigneScarfing { get; set; }
        public int? ChutageTete { get; set; }
        public int? NbBarresCourtes { get; set; }
        public string CodePesee { get; set; }
    }
}
