﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_BLOOMING_LAMINAGE")]
    public partial class LDBloomingLaminage
    {
        public int IdBloLaminage { get; set; }
        [Required]
        [Column("BloOFInterne")]
        [StringLength(16)]
        public string BloOfinterne { get; set; }
        public int BloNumLingot { get; set; }
        public int BloProg { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime BloDateLaminage { get; set; }
        [Required]
        [StringLength(1)]
        public string BloMontage { get; set; }
        public int? BloProgEtat { get; set; }
        public double? BloSection { get; set; }
        public double? BloLargeur { get; set; }
        public int? BloNbPasse { get; set; }
        public int? BloPasse1 { get; set; }
        [StringLength(5)]
        public string BloCannelure1 { get; set; }
        public int? BloPasse2 { get; set; }
        [StringLength(5)]
        public string BloCannelure2 { get; set; }
        public int? BloPasse3 { get; set; }
        [StringLength(5)]
        public string BloCannelure3 { get; set; }
        public int? BloPasse4 { get; set; }
        [StringLength(5)]
        public string BloCannelure4 { get; set; }
        public int? BloPasse5 { get; set; }
        [StringLength(5)]
        public string BloCannelure5 { get; set; }
        public int? BloPasse6 { get; set; }
        [StringLength(5)]
        public string BloCannelure6 { get; set; }
        public int? BloPasse7 { get; set; }
        [StringLength(5)]
        public string BloCannelure7 { get; set; }
        public int? BloPasse8 { get; set; }
        [StringLength(5)]
        public string BloCannelure8 { get; set; }
        public int? BloPasse9 { get; set; }
        [StringLength(5)]
        public string BloCannelure9 { get; set; }
        public int? BloPasse10 { get; set; }
        [StringLength(5)]
        public string BloCannelure10 { get; set; }
        public int? BloPasse11 { get; set; }
        [StringLength(5)]
        public string BloCannelure11 { get; set; }
        public int? BloPasse12 { get; set; }
        [StringLength(5)]
        public string BloCannelure12 { get; set; }
        public int? BloPasse13 { get; set; }
        [StringLength(5)]
        public string BloCannelure13 { get; set; }
        public int? BloPasse14 { get; set; }
        [StringLength(5)]
        public string BloCannelure14 { get; set; }
        public int? BloPasse15 { get; set; }
        [StringLength(5)]
        public string BloCannelure15 { get; set; }
        public int? BloPasse16 { get; set; }
        [StringLength(5)]
        public string BloCannelure16 { get; set; }
        public int? BloPasse17 { get; set; }
        [StringLength(5)]
        public string BloCannelure17 { get; set; }
        public int? BloPasse18 { get; set; }
        [StringLength(5)]
        public string BloCannelure18 { get; set; }
        public int? BloPasse19 { get; set; }
        [StringLength(5)]
        public string BloCannelure19 { get; set; }
        public int? BloPasse20 { get; set; }
        [StringLength(5)]
        public string BloCannelure20 { get; set; }
        public int? BloPasse21 { get; set; }
        [StringLength(5)]
        public string BloCannelure21 { get; set; }
        public int? BloPasse22 { get; set; }
        [StringLength(5)]
        public string BloCannelure22 { get; set; }
        public int? BloPasse23 { get; set; }
        [StringLength(5)]
        public string BloCannelure23 { get; set; }
        public int? BloPasse24 { get; set; }
        [StringLength(5)]
        public string BloCannelure24 { get; set; }
        public int? BloPasse25 { get; set; }
        [StringLength(5)]
        public string BloCannelure25 { get; set; }
        public int? BloPasse26 { get; set; }
        [StringLength(5)]
        public string BloCannelure26 { get; set; }
        public int? BloPasse27 { get; set; }
        [StringLength(5)]
        public string BloCannelure27 { get; set; }
        public int? BloPasse28 { get; set; }
        [StringLength(5)]
        public string BloCannelure28 { get; set; }
        public int? BloPasse29 { get; set; }
        [StringLength(5)]
        public string BloCannelure29 { get; set; }
        public int? BloPasse30 { get; set; }
        [StringLength(5)]
        public string BloCannelure30 { get; set; }
        public int? BloPasse31 { get; set; }
        [StringLength(5)]
        public string BloCannelure31 { get; set; }
        public int? BloPasse32 { get; set; }
        [StringLength(5)]
        public string BloCannelure32 { get; set; }
        public int? BloPasse33 { get; set; }
        [StringLength(5)]
        public string BloCannelure33 { get; set; }
        public int? BloPasse34 { get; set; }
        [StringLength(5)]
        public string BloCannelure34 { get; set; }
        public int? BloPasse35 { get; set; }
        [StringLength(5)]
        public string BloCannelure35 { get; set; }
        public int? BloPasse36 { get; set; }
        [StringLength(5)]
        public string BloCannelure36 { get; set; }
        public int? BloPasse37 { get; set; }
        [StringLength(5)]
        public string BloCannelure37 { get; set; }
        public int? BloPasse38 { get; set; }
        [StringLength(5)]
        public string BloCannelure38 { get; set; }
        public int? BloPasse39 { get; set; }
        [StringLength(5)]
        public string BloCannelure39 { get; set; }
        public int? BloPasse40 { get; set; }
        [StringLength(5)]
        public string BloCannelure40 { get; set; }
        public int? BloPasse41 { get; set; }
        [StringLength(5)]
        public string BloCannelure41 { get; set; }
        public int? BloPasse42 { get; set; }
        [StringLength(5)]
        public string BloCannelure42 { get; set; }
        public int? BloPasse43 { get; set; }
        [StringLength(5)]
        public string BloCannelure43 { get; set; }
        public int? BloPasse44 { get; set; }
        [StringLength(5)]
        public string BloCannelure44 { get; set; }
        public int? BloPasse45 { get; set; }
        [StringLength(5)]
        public string BloCannelure45 { get; set; }
        public int? BloPasse46 { get; set; }
        [StringLength(5)]
        public string BloCannelure46 { get; set; }
        public int? BloPasse47 { get; set; }
        [StringLength(5)]
        public string BloCannelure47 { get; set; }
        public int? BloPasse48 { get; set; }
        [StringLength(5)]
        public string BloCannelure48 { get; set; }
        public int? BloPasse49 { get; set; }
        [StringLength(5)]
        public string BloCannelure49 { get; set; }
        public int? BloPasse50 { get; set; }
        [StringLength(5)]
        public string BloCannelure50 { get; set; }
    }
}