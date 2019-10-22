using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_PSO")]
    public partial class LDPso
    {
        public LDPso()
        {
            LDDefaut = new HashSet<LDDefaut>();
            LDSousProduits = new HashSet<LDSousProduits>();
            LDStockPso = new HashSet<LDStockPso>();
        }

        [StringLength(6)]
        public string Coulee { get; set; }
        public int NumeroLingot { get; set; }
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        public int NumeroWagon { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal? CoteBloomingHauteur { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal? CoteBloomingLargeur { get; set; }
        [StringLength(250)]
        public string CoteBloomingCommentaire { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal? CoteCage900Hauteur { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal? CoteCage900Largeur { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal? CoteCage900Epaulement1 { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal? CoteCage900Epaulement2 { get; set; }
        [StringLength(250)]
        public string CoteCage900Commentaire { get; set; }
        [Column("ARefroidir")]
        public bool Arefroidir { get; set; }
        public int Etat { get; set; }
        public bool DefautsTete { get; set; }
        public bool DefautsPied { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateEnfournement { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateDefournement { get; set; }
        public int? RangPassageAuLaminoir { get; set; }
        public int PoidsTheorique { get; set; }
        public int Poids { get; set; }
        [StringLength(8)]
        public string Reperage { get; set; }
        public int? TemperatureScarfing { get; set; }
        public int? TemperatureT07 { get; set; }
        public int? TemperatureT03 { get; set; }
        public int Operation { get; set; }
        [StringLength(8)]
        public string Action { get; set; }
        public int? ChutageTete { get; set; }
        public int? ChutagePied { get; set; }
        public int? EboutageTete { get; set; }
        public int? EboutagePied { get; set; }
        [StringLength(1)]
        public string ConsigneScarfing { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal? LgDeveloppee { get; set; }
        [Column(TypeName = "decimal(5, 3)")]
        public decimal? Densite { get; set; }
        [Column(TypeName = "decimal(7, 3)")]
        public decimal? PoidsChuteTete { get; set; }
        [Column(TypeName = "decimal(7, 3)")]
        public decimal? PoidsChutePied { get; set; }
        [Column(TypeName = "decimal(7, 3)")]
        public decimal? PoidsEboutagePied { get; set; }
        [Column(TypeName = "decimal(7, 3)")]
        public decimal? PoidsEboutageTete { get; set; }
        [Required]
        public bool? Externe { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateRefroidissement { get; set; }

        [ForeignKey("Coulee")]
        [InverseProperty("LDPso")]
        public virtual LDCoulee CouleeNavigation { get; set; }
        [ForeignKey("Of")]
        [InverseProperty("LDPso")]
        public virtual LDOrdreFabrication OfNavigation { get; set; }
        [InverseProperty("LDPso")]
        public virtual ICollection<LDDefaut> LDDefaut { get; set; }
        [InverseProperty("LDPso")]
        public virtual ICollection<LDSousProduits> LDSousProduits { get; set; }
        [InverseProperty("LDPso")]
        public virtual ICollection<LDStockPso> LDStockPso { get; set; }
    }
}