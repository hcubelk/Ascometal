using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPProgBillette
    {
        public int Id { get; set; }
        public int Programme { get; set; }
        public decimal Section { get; set; }
        public decimal? Largeur { get; set; }
        public string Profile { get; set; }
        public string Monture { get; set; }
        public string Observations { get; set; }
        public decimal? CoteBouchon { get; set; }
        public decimal? CalibrageOvale { get; set; }
        public decimal? CalibrageRond { get; set; }
        public string OuverturePov { get; set; }
        public string OuvertureOv { get; set; }
        public string OuvertureRond { get; set; }
        public int NombrePasse { get; set; }
        public string CanelurePasse1 { get; set; }
        public string ElevationPasse1 { get; set; }
        public bool QuartierPasse1 { get; set; }
        public string CanelurePasse2 { get; set; }
        public string ElevationPasse2 { get; set; }
        public bool QuartierPasse2 { get; set; }
        public string CanelurePasse3 { get; set; }
        public string ElevationPasse3 { get; set; }
        public bool QuartierPasse3 { get; set; }
        public string CanelurePasse4 { get; set; }
        public string ElevationPasse4 { get; set; }
        public bool QuartierPasse4 { get; set; }
        public string CanelurePasse5 { get; set; }
        public string ElevationPasse5 { get; set; }
        public bool QuartierPasse5 { get; set; }
        public string CanelurePasse6 { get; set; }
        public string ElevationPasse6 { get; set; }
        public bool QuartierPasse6 { get; set; }
        public string CanelurePasse7 { get; set; }
        public string ElevationPasse7 { get; set; }
        public bool QuartierPasse7 { get; set; }
        public string CanelurePasse8 { get; set; }
        public string ElevationPasse8 { get; set; }
        public bool QuartierPasse8 { get; set; }
        public string CanelurePasse9 { get; set; }
        public string ElevationPasse9 { get; set; }
        public bool QuartierPasse9 { get; set; }
        public string CanelurePasse10 { get; set; }
        public string ElevationPasse10 { get; set; }
        public bool QuartierPasse10 { get; set; }
        public string CanelurePasse11 { get; set; }
        public string ElevationPasse11 { get; set; }
        public bool QuartierPasse11 { get; set; }
        public string CanelurePasse12 { get; set; }
        public string ElevationPasse12 { get; set; }
        public bool QuartierPasse12 { get; set; }
        public string CanelurePasse13 { get; set; }
        public string ElevationPasse13 { get; set; }
        public bool QuartierPasse13 { get; set; }
        public string CanelurePasse14 { get; set; }
        public string ElevationPasse14 { get; set; }
        public bool QuartierPasse14 { get; set; }
        public string CanelurePasse15 { get; set; }
        public string ElevationPasse15 { get; set; }
        public bool QuartierPasse15 { get; set; }
        public DateTime DateMaj { get; set; }
        public DateTime DateCreation { get; set; }
        public decimal? SectionMin { get; set; }
        public decimal? SectionMax { get; set; }
        public decimal? PriseDeFerHauteur { get; set; }
        public decimal? PriseDeFerLargeur { get; set; }
    }
}
