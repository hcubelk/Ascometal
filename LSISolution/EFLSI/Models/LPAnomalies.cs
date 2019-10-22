using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_ANOMALIES")]
    public partial class LPAnomalies
    {
        public LPAnomalies()
        {
            LDAnomalies = new HashSet<LDAnomalies>();
        }

        [Column("ID")]
        public int Id { get; set; }
        public int Parent { get; set; }
        [Required]
        [StringLength(50)]
        public string Libelle { get; set; }

        [InverseProperty("IdNavigation")]
        public virtual ICollection<LDAnomalies> LDAnomalies { get; set; }
    }
}