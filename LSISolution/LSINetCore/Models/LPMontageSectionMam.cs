using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPMontageSectionMam
    {
        public int Id { get; set; }
        public int Montage { get; set; }
        public string Profil { get; set; }
        public int SectionMin { get; set; }
        public int SectionMax { get; set; }
        public int? Rendement1 { get; set; }
        public int? Rendement2 { get; set; }
        public int? Rendement3 { get; set; }
        public string Cannelure { get; set; }
        public int? MaM1 { get; set; }
        public int? MaM2 { get; set; }
        public int? Jalon { get; set; }
        public DateTime? DateMaj { get; set; }
        public decimal? RayonChutage { get; set; }
        public int? DureeMontage { get; set; }
        public int? DureeReglage { get; set; }
    }
}
