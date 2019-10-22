using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_RELEVE_TEMPERATURE")]
    public partial class LDReleveTemperature
    {
        [Column("ID")]
        public int Id { get; set; }
        public int Temperature { get; set; }
        [Column("AdressesTemperatureID")]
        public int AdressesTemperatureId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }

        [ForeignKey("AdressesTemperatureId")]
        [InverseProperty("LDReleveTemperature")]
        public virtual LPAdressesTemperature AdressesTemperature { get; set; }
    }
}