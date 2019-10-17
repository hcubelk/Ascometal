using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPTypeConsigne
    {
        public LPTypeConsigne()
        {
            LPConsignesChutage = new HashSet<LPConsignesChutage>();
            LPConsignesCodeoutilCoupe = new HashSet<LPConsignesCodeoutilCoupe>();
            LPConsignesDecoupe = new HashSet<LPConsignesDecoupe>();
            LPConsignesLingot = new HashSet<LPConsignesLingot>();
            LPConsignesMarquage = new HashSet<LPConsignesMarquage>();
            LPConsignesPits = new HashSet<LPConsignesPits>();
            LPConsignesPoidsmetrique = new HashSet<LPConsignesPoidsmetrique>();
            LPConsignesRefroidissoirs = new HashSet<LPConsignesRefroidissoirs>();
        }

        public int Id { get; set; }
        public string Libelle { get; set; }

        public virtual ICollection<LPConsignesChutage> LPConsignesChutage { get; set; }
        public virtual ICollection<LPConsignesCodeoutilCoupe> LPConsignesCodeoutilCoupe { get; set; }
        public virtual ICollection<LPConsignesDecoupe> LPConsignesDecoupe { get; set; }
        public virtual ICollection<LPConsignesLingot> LPConsignesLingot { get; set; }
        public virtual ICollection<LPConsignesMarquage> LPConsignesMarquage { get; set; }
        public virtual ICollection<LPConsignesPits> LPConsignesPits { get; set; }
        public virtual ICollection<LPConsignesPoidsmetrique> LPConsignesPoidsmetrique { get; set; }
        public virtual ICollection<LPConsignesRefroidissoirs> LPConsignesRefroidissoirs { get; set; }
    }
}
