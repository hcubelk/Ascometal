using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_FILE_QUEUE")]
    public partial class LDFileQueue
    {
        public int Id { get; set; }
        [Required]
        public string PathName { get; set; }
        public int Status { get; set; }
        [Required]
        [Column("ServeurMAC")]
        public string ServeurMac { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateUpdate { get; set; }
        [Column("OFCount")]
        public int? Ofcount { get; set; }
        [Column("OFTotal")]
        public int? Oftotal { get; set; }
        [Required]
        [StringLength(5)]
        public string CodeEmetteur { get; set; }
        [Required]
        [StringLength(15)]
        public string Type { get; set; }
    }
}