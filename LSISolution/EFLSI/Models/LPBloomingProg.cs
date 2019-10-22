using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_BLOOMING_PROG")]
    public partial class LPBloomingProg
    {
        [Key]
        [Column("IdBloPProg")]
        public int IdBloPprog { get; set; }
        [Column("BloPDateCre", TypeName = "datetime")]
        public DateTime BloPdateCre { get; set; }
        [Column("BloPDateMdf", TypeName = "datetime")]
        public DateTime BloPdateMdf { get; set; }
        [Required]
        [Column("BloPMontage")]
        [StringLength(1)]
        public string BloPmontage { get; set; }
        [Column("BloPProg")]
        public int? BloPprog { get; set; }
        [Column("BloPSection")]
        public double? BloPsection { get; set; }
        [Column("BloPLargeur")]
        public double? BloPlargeur { get; set; }
        [Column("BloPNbPasse")]
        public int? BloPnbPasse { get; set; }
        [Column("BloPPasse1")]
        public int? BloPpasse1 { get; set; }
        [Column("BloPCannelure1")]
        [StringLength(5)]
        public string BloPcannelure1 { get; set; }
        [Column("BloPPasse2")]
        public int? BloPpasse2 { get; set; }
        [Column("BloPCannelure2")]
        [StringLength(5)]
        public string BloPcannelure2 { get; set; }
        [Column("BloPPasse3")]
        public int? BloPpasse3 { get; set; }
        [Column("BloPCannelure3")]
        [StringLength(5)]
        public string BloPcannelure3 { get; set; }
        [Column("BloPPasse4")]
        public int? BloPpasse4 { get; set; }
        [Column("BloPCannelure4")]
        [StringLength(5)]
        public string BloPcannelure4 { get; set; }
        [Column("BloPPasse5")]
        public int? BloPpasse5 { get; set; }
        [Column("BloPCannelure5")]
        [StringLength(5)]
        public string BloPcannelure5 { get; set; }
        [Column("BloPPasse6")]
        public int? BloPpasse6 { get; set; }
        [Column("BloPCannelure6")]
        [StringLength(5)]
        public string BloPcannelure6 { get; set; }
        [Column("BloPPasse7")]
        public int? BloPpasse7 { get; set; }
        [Column("BloPCannelure7")]
        [StringLength(5)]
        public string BloPcannelure7 { get; set; }
        [Column("BloPPasse8")]
        public int? BloPpasse8 { get; set; }
        [Column("BloPCannelure8")]
        [StringLength(5)]
        public string BloPcannelure8 { get; set; }
        [Column("BloPPasse9")]
        public int? BloPpasse9 { get; set; }
        [Column("BloPCannelure9")]
        [StringLength(5)]
        public string BloPcannelure9 { get; set; }
        [Column("BloPPasse10")]
        public int? BloPpasse10 { get; set; }
        [Column("BloPCannelure10")]
        [StringLength(5)]
        public string BloPcannelure10 { get; set; }
        [Column("BloPPasse11")]
        public int? BloPpasse11 { get; set; }
        [Column("BloPCannelure11")]
        [StringLength(5)]
        public string BloPcannelure11 { get; set; }
        [Column("BloPPasse12")]
        public int? BloPpasse12 { get; set; }
        [Column("BloPCannelure12")]
        [StringLength(5)]
        public string BloPcannelure12 { get; set; }
        [Column("BloPPasse13")]
        public int? BloPpasse13 { get; set; }
        [Column("BloPCannelure13")]
        [StringLength(5)]
        public string BloPcannelure13 { get; set; }
        [Column("BloPPasse14")]
        public int? BloPpasse14 { get; set; }
        [Column("BloPCannelure14")]
        [StringLength(5)]
        public string BloPcannelure14 { get; set; }
        [Column("BloPPasse15")]
        public int? BloPpasse15 { get; set; }
        [Column("BloPCannelure15")]
        [StringLength(5)]
        public string BloPcannelure15 { get; set; }
        [Column("BloPPasse16")]
        public int? BloPpasse16 { get; set; }
        [Column("BloPCannelure16")]
        [StringLength(5)]
        public string BloPcannelure16 { get; set; }
        [Column("BloPPasse17")]
        public int? BloPpasse17 { get; set; }
        [Column("BloPCannelure17")]
        [StringLength(5)]
        public string BloPcannelure17 { get; set; }
        [Column("BloPPasse18")]
        public int? BloPpasse18 { get; set; }
        [Column("BloPCannelure18")]
        [StringLength(5)]
        public string BloPcannelure18 { get; set; }
        [Column("BloPPasse19")]
        public int? BloPpasse19 { get; set; }
        [Column("BloPCannelure19")]
        [StringLength(5)]
        public string BloPcannelure19 { get; set; }
        [Column("BloPPasse20")]
        public int? BloPpasse20 { get; set; }
        [Column("BloPCannelure20")]
        [StringLength(5)]
        public string BloPcannelure20 { get; set; }
        [Column("BloPPasse21")]
        public int? BloPpasse21 { get; set; }
        [Column("BloPCannelure21")]
        [StringLength(5)]
        public string BloPcannelure21 { get; set; }
        [Column("BloPPasse22")]
        public int? BloPpasse22 { get; set; }
        [Column("BloPCannelure22")]
        [StringLength(5)]
        public string BloPcannelure22 { get; set; }
        [Column("BloPPasse23")]
        public int? BloPpasse23 { get; set; }
        [Column("BloPCannelure23")]
        [StringLength(5)]
        public string BloPcannelure23 { get; set; }
        [Column("BloPPasse24")]
        public int? BloPpasse24 { get; set; }
        [Column("BloPCannelure24")]
        [StringLength(5)]
        public string BloPcannelure24 { get; set; }
        [Column("BloPPasse25")]
        public int? BloPpasse25 { get; set; }
        [Column("BloPCannelure25")]
        [StringLength(5)]
        public string BloPcannelure25 { get; set; }
        [Column("BloPPasse26")]
        public int? BloPpasse26 { get; set; }
        [Column("BloPCannelure26")]
        [StringLength(5)]
        public string BloPcannelure26 { get; set; }
        [Column("BloPPasse27")]
        public int? BloPpasse27 { get; set; }
        [Column("BloPCannelure27")]
        [StringLength(5)]
        public string BloPcannelure27 { get; set; }
        [Column("BloPPasse28")]
        public int? BloPpasse28 { get; set; }
        [Column("BloPCannelure28")]
        [StringLength(5)]
        public string BloPcannelure28 { get; set; }
        [Column("BloPPasse29")]
        public int? BloPpasse29 { get; set; }
        [Column("BloPCannelure29")]
        [StringLength(5)]
        public string BloPcannelure29 { get; set; }
        [Column("BloPPasse30")]
        public int? BloPpasse30 { get; set; }
        [Column("BloPCannelure30")]
        [StringLength(5)]
        public string BloPcannelure30 { get; set; }
        [Column("BloPPasse31")]
        public int? BloPpasse31 { get; set; }
        [Column("BloPCannelure31")]
        [StringLength(5)]
        public string BloPcannelure31 { get; set; }
        [Column("BloPPasse32")]
        public int? BloPpasse32 { get; set; }
        [Column("BloPCannelure32")]
        [StringLength(5)]
        public string BloPcannelure32 { get; set; }
        [Column("BloPPasse33")]
        public int? BloPpasse33 { get; set; }
        [Column("BloPCannelure33")]
        [StringLength(5)]
        public string BloPcannelure33 { get; set; }
        [Column("BloPPasse34")]
        public int? BloPpasse34 { get; set; }
        [Column("BloPCannelure34")]
        [StringLength(5)]
        public string BloPcannelure34 { get; set; }
        [Column("BloPPasse35")]
        public int? BloPpasse35 { get; set; }
        [Column("BloPCannelure35")]
        [StringLength(5)]
        public string BloPcannelure35 { get; set; }
        [Column("BloPPasse36")]
        public int? BloPpasse36 { get; set; }
        [Column("BloPCannelure36")]
        [StringLength(5)]
        public string BloPcannelure36 { get; set; }
        [Column("BloPPasse37")]
        public int? BloPpasse37 { get; set; }
        [Column("BloPCannelure37")]
        [StringLength(5)]
        public string BloPcannelure37 { get; set; }
        [Column("BloPPasse38")]
        public int? BloPpasse38 { get; set; }
        [Column("BloPCannelure38")]
        [StringLength(5)]
        public string BloPcannelure38 { get; set; }
        [Column("BloPPasse39")]
        public int? BloPpasse39 { get; set; }
        [Column("BloPCannelure39")]
        [StringLength(5)]
        public string BloPcannelure39 { get; set; }
        [Column("BloPPasse40")]
        public int? BloPpasse40 { get; set; }
        [Column("BloPCannelure40")]
        [StringLength(5)]
        public string BloPcannelure40 { get; set; }
        [Column("BloPPasse41")]
        public int? BloPpasse41 { get; set; }
        [Column("BloPCannelure41")]
        [StringLength(5)]
        public string BloPcannelure41 { get; set; }
        [Column("BloPPasse42")]
        public int? BloPpasse42 { get; set; }
        [Column("BloPCannelure42")]
        [StringLength(5)]
        public string BloPcannelure42 { get; set; }
        [Column("BloPPasse43")]
        public int? BloPpasse43 { get; set; }
        [Column("BloPCannelure43")]
        [StringLength(5)]
        public string BloPcannelure43 { get; set; }
        [Column("BloPPasse44")]
        public int? BloPpasse44 { get; set; }
        [Column("BloPCannelure44")]
        [StringLength(5)]
        public string BloPcannelure44 { get; set; }
        [Column("BloPPasse45")]
        public int? BloPpasse45 { get; set; }
        [Column("BloPCannelure45")]
        [StringLength(5)]
        public string BloPcannelure45 { get; set; }
        [Column("BloPPasse46")]
        public int? BloPpasse46 { get; set; }
        [Column("BloPCannelure46")]
        [StringLength(5)]
        public string BloPcannelure46 { get; set; }
        [Column("BloPPasse47")]
        public int? BloPpasse47 { get; set; }
        [Column("BloPCannelure47")]
        [StringLength(5)]
        public string BloPcannelure47 { get; set; }
        [Column("BloPPasse48")]
        public int? BloPpasse48 { get; set; }
        [Column("BloPCannelure48")]
        [StringLength(5)]
        public string BloPcannelure48 { get; set; }
        [Column("BloPPasse49")]
        public int? BloPpasse49 { get; set; }
        [Column("BloPCannelure49")]
        [StringLength(5)]
        public string BloPcannelure49 { get; set; }
        [Column("BloPPasse50")]
        public int? BloPpasse50 { get; set; }
        [Column("BloPCannelure50")]
        [StringLength(5)]
        public string BloPcannelure50 { get; set; }
    }
}