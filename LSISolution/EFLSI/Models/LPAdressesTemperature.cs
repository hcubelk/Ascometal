using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_ADRESSES_TEMPERATURE")]
    public partial class LPAdressesTemperature
    {
        public LPAdressesTemperature()
        {
            LDReleveTemperature = new HashSet<LDReleveTemperature>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [StringLength(25)]
        public string Outil { get; set; }
        [Required]
        [StringLength(50)]
        public string Libelle { get; set; }
        [Required]
        [Column("AdresseIP")]
        [StringLength(15)]
        public string AdresseIp { get; set; }
        public int Esclave { get; set; }
        [Required]
        [StringLength(5)]
        public string Modbus { get; set; }
        public int? ValeurMini { get; set; }
        public int? ValeurMax { get; set; }
        public int? ValeurAlarme { get; set; }
        public int? ValeurSeuil { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        [InverseProperty("AdressesTemperature")]
        public virtual ICollection<LDReleveTemperature> LDReleveTemperature { get; set; }
    }
}