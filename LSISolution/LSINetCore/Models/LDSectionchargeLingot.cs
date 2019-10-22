using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSINetCore.Models
{
    public partial class LDSectionchargeLingot
    {
        [Key]
        public string Of { get; set; }
        [Key]
        public string CodeOperation { get; set; }
        public string RangOperation { get; set; }
        public string ProfileLamine { get; set; }
        public decimal? SectionLaminage { get; set; }
        public decimal? ToleranceMaxSection { get; set; }
        public decimal? ToleranceMinSection { get; set; }
        public decimal? EpaisseurEnLaminage { get; set; }
        public decimal? ToleranceMaxEpaisseur { get; set; }
        public decimal? ToleranceMinEpaisseur { get; set; }
        public int? PriseDeFer { get; set; }
        public int? Programme { get; set; }
        public decimal? PriseDeFerHauteur { get; set; }
        public int? PriseDeFerSection { get; set; }
        public decimal? PriseDeFerEpaisseur { get; set; }
        public int? ProgrammeGpao { get; set; }
        public decimal? PriseDeFerHauteurGpao { get; set; }
        public int? PriseDeFerSectionGpao { get; set; }
        public decimal? PriseDeFerEpaisseurGpao { get; set; }

        public virtual LPTextOperations CodeOperationNavigation { get; set; }
        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}
