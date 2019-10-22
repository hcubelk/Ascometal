using System;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFLSI.Models
{
    public partial class AscolsiContext : DbContext
    {
        public AscolsiContext()
        {
        }

        public AscolsiContext(DbContextOptions<AscolsiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LDAnomalies> LDAnomalies { get; set; }
        public virtual DbSet<LDArret> LDArret { get; set; }
        public virtual DbSet<LDAsiSuivi> LDAsiSuivi { get; set; }
        public virtual DbSet<LDBilletteLaminage> LDBilletteLaminage { get; set; }
        public virtual DbSet<LDBloomingLaminage> LDBloomingLaminage { get; set; }
        public virtual DbSet<LDCages> LDCages { get; set; }
        public virtual DbSet<LDCapteur> LDCapteur { get; set; }
        public virtual DbSet<LDCapteurSuivi> LDCapteurSuivi { get; set; }
        public virtual DbSet<LDChronologieAcierie> LDChronologieAcierie { get; set; }
        public virtual DbSet<LDCommandes> LDCommandes { get; set; }
        public virtual DbSet<LDConsignes> LDConsignes { get; set; }
        public virtual DbSet<LDCoulee> LDCoulee { get; set; }
        public virtual DbSet<LDCouleeSuivi> LDCouleeSuivi { get; set; }
        public virtual DbSet<LDDefaut> LDDefaut { get; set; }
        public virtual DbSet<LDEtatLiaison> LDEtatLiaison { get; set; }
        public virtual DbSet<LDEtatStock> LDEtatStock { get; set; }
        public virtual DbSet<LDFileQueue> LDFileQueue { get; set; }
        public virtual DbSet<LDFonctions> LDFonctions { get; set; }
        public virtual DbSet<LDFonctionsN2> LDFonctionsN2 { get; set; }
        public virtual DbSet<LDFourAcier> LDFourAcier { get; set; }
        public virtual DbSet<LDFours> LDFours { get; set; }
        public virtual DbSet<LDHeurecalcul> LDHeurecalcul { get; set; }
        public virtual DbSet<LDHistoCages> LDHistoCages { get; set; }
        public virtual DbSet<LDJalondeproduction> LDJalondeproduction { get; set; }
        public virtual DbSet<LDJalondeproductionprev> LDJalondeproductionprev { get; set; }
        public virtual DbSet<LDKape22> LDKape22 { get; set; }
        public virtual DbSet<LDKeycompteur> LDKeycompteur { get; set; }
        public virtual DbSet<LDKla1> LDKla1 { get; set; }
        public virtual DbSet<LDLogCommande> LDLogCommande { get; set; }
        public virtual DbSet<LDMajDateChecker> LDMajDateChecker { get; set; }
        public virtual DbSet<LDMajPoste> LDMajPoste { get; set; }
        public virtual DbSet<LDMamQual> LDMamQual { get; set; }
        public virtual DbSet<LDMessageProduction> LDMessageProduction { get; set; }
        public virtual DbSet<LDMesure> LDMesure { get; set; }
        public virtual DbSet<LDMouvementStock> LDMouvementStock { get; set; }
        public virtual DbSet<LDOfSuivi> LDOfSuivi { get; set; }
        public virtual DbSet<LDOrdreFabrication> LDOrdreFabrication { get; set; }
        public virtual DbSet<LDOutilsVor> LDOutilsVor { get; set; }
        public virtual DbSet<LDPanne> LDPanne { get; set; }
        public virtual DbSet<LDPesage> LDPesage { get; set; }
        public virtual DbSet<LDPlansFours> LDPlansFours { get; set; }
        public virtual DbSet<LDProduitsOutil> LDProduitsOutil { get; set; }
        public virtual DbSet<LDPso> LDPso { get; set; }
        public virtual DbSet<LDPsoComplement> LDPsoComplement { get; set; }
        public virtual DbSet<LDRebut> LDRebut { get; set; }
        public virtual DbSet<LDReleveTemperature> LDReleveTemperature { get; set; }
        public virtual DbSet<LDRoles> LDRoles { get; set; }
        public virtual DbSet<LDRouleaux> LDRouleaux { get; set; }
        public virtual DbSet<LDSectionchargeChutage> LDSectionchargeChutage { get; set; }
        public virtual DbSet<LDSectionchargeDecoupe> LDSectionchargeDecoupe { get; set; }
        public virtual DbSet<LDSectionchargeLingot> LDSectionchargeLingot { get; set; }
        public virtual DbSet<LDSectionchargePits> LDSectionchargePits { get; set; }
        public virtual DbSet<LDSectionchargePoidsmetrique> LDSectionchargePoidsmetrique { get; set; }
        public virtual DbSet<LDSectionchargeRefroidissoirs> LDSectionchargeRefroidissoirs { get; set; }
        public virtual DbSet<LDSectionchargeSvt> LDSectionchargeSvt { get; set; }
        public virtual DbSet<LDSousProduits> LDSousProduits { get; set; }
        public virtual DbSet<LDStockPso> LDStockPso { get; set; }
        public virtual DbSet<LDVersion> LDVersion { get; set; }
        public virtual DbSet<LDWatchdog> LDWatchdog { get; set; }
        public virtual DbSet<LDZone> LDZone { get; set; }
        public virtual DbSet<LDZoneSuivi> LDZoneSuivi { get; set; }
        public virtual DbSet<LPAdressesTemperature> LPAdressesTemperature { get; set; }
        public virtual DbSet<LPAnomalies> LPAnomalies { get; set; }
        public virtual DbSet<LPArret> LPArret { get; set; }
        public virtual DbSet<LPBloomingProg> LPBloomingProg { get; set; }
        public virtual DbSet<LPCellulesMesureLongueur> LPCellulesMesureLongueur { get; set; }
        public virtual DbSet<LPCodeoutilDecoupe> LPCodeoutilDecoupe { get; set; }
        public virtual DbSet<LPCoeffdilatation> LPCoeffdilatation { get; set; }
        public virtual DbSet<LPConsignesChutage> LPConsignesChutage { get; set; }
        public virtual DbSet<LPConsignesCodeoutilCoupe> LPConsignesCodeoutilCoupe { get; set; }
        public virtual DbSet<LPConsignesDecoupe> LPConsignesDecoupe { get; set; }
        public virtual DbSet<LPConsignesDegazageDetail> LPConsignesDegazageDetail { get; set; }
        public virtual DbSet<LPConsignesDegazageGlobal> LPConsignesDegazageGlobal { get; set; }
        public virtual DbSet<LPConsignesLingot> LPConsignesLingot { get; set; }
        public virtual DbSet<LPConsignesMarquage> LPConsignesMarquage { get; set; }
        public virtual DbSet<LPConsignesPits> LPConsignesPits { get; set; }
        public virtual DbSet<LPConsignesPoidsmetrique> LPConsignesPoidsmetrique { get; set; }
        public virtual DbSet<LPConsignesPrechauffageModification> LPConsignesPrechauffageModification { get; set; }
        public virtual DbSet<LPConsignesPrechauffageParticulier> LPConsignesPrechauffageParticulier { get; set; }
        public virtual DbSet<LPConsignesRefroidissement> LPConsignesRefroidissement { get; set; }
        public virtual DbSet<LPConsignesRefroidissementBloom> LPConsignesRefroidissementBloom { get; set; }
        public virtual DbSet<LPConsignesRefroidissementLingot> LPConsignesRefroidissementLingot { get; set; }
        public virtual DbSet<LPConsignesRefroidissoirs> LPConsignesRefroidissoirs { get; set; }
        public virtual DbSet<LPConsignesScarfing> LPConsignesScarfing { get; set; }
        public virtual DbSet<LPConsignesSmq> LPConsignesSmq { get; set; }
        public virtual DbSet<LPDefaut> LPDefaut { get; set; }
        public virtual DbSet<LPDelaisLivraison> LPDelaisLivraison { get; set; }
        public virtual DbSet<LPDestination> LPDestination { get; set; }
        public virtual DbSet<LPEquipes> LPEquipes { get; set; }
        public virtual DbSet<LPJalonActiviteProfil> LPJalonActiviteProfil { get; set; }
        public virtual DbSet<LPJalonMotif> LPJalonMotif { get; set; }
        public virtual DbSet<LPLienPdf> LPLienPdf { get; set; }
        public virtual DbSet<LPLieuxStockLaminoir> LPLieuxStockLaminoir { get; set; }
        public virtual DbSet<LPLieuxStockPaquetsPesee> LPLieuxStockPaquetsPesee { get; set; }
        public virtual DbSet<LPMontageSectionMam> LPMontageSectionMam { get; set; }
        public virtual DbSet<LPParametresGeneraux> LPParametresGeneraux { get; set; }
        public virtual DbSet<LPPredecesseurZone> LPPredecesseurZone { get; set; }
        public virtual DbSet<LPPriseDeFer> LPPriseDeFer { get; set; }
        public virtual DbSet<LPProfilProduit> LPProfilProduit { get; set; }
        public virtual DbSet<LPProgBillette> LPProgBillette { get; set; }
        public virtual DbSet<LPPso> LPPso { get; set; }
        public virtual DbSet<LPRebut> LPRebut { get; set; }
        public virtual DbSet<LPRepere> LPRepere { get; set; }
        public virtual DbSet<LPRepereAutoLingot> LPRepereAutoLingot { get; set; }
        public virtual DbSet<LPSmq> LPSmq { get; set; }
        public virtual DbSet<LPTextOperations> LPTextOperations { get; set; }
        public virtual DbSet<LPTypeConsigne> LPTypeConsigne { get; set; }
        public virtual DbSet<LPZoneStockLaminoir> LPZoneStockLaminoir { get; set; }
        public virtual DbSet<LSBlooming> LSBlooming { get; set; }
        public virtual DbSet<LSLaminoir> LSLaminoir { get; set; }
        public virtual DbSet<LSOptiLgBarre> LSOptiLgBarre { get; set; }
        public virtual DbSet<LSProduction> LSProduction { get; set; }
        public virtual DbSet<LSRapportSyntheseMensuelle> LSRapportSyntheseMensuelle { get; set; }
        public virtual DbSet<LSSyntheseProductionMensuelle> LSSyntheseProductionMensuelle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<LDAnomalies>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdCoulee });

                entity.HasIndex(e => e.IdCoulee)
                    .HasName("IX_FK_AnomaliesCoulee");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.LDAnomalies)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParamAnomaliesAnomalies");

                entity.HasOne(d => d.IdCouleeNavigation)
                    .WithMany(p => p.LDAnomalies)
                    .HasForeignKey(d => d.IdCoulee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnomaliesCoulee");
            });

            modelBuilder.Entity<LDBloomingLaminage>(entity =>
            {
                entity.HasKey(e => e.IdBloLaminage)
                    .HasName("PK_L_BLOOMING_LAMINAGE");

                entity.Property(e => e.BloCannelure1).IsUnicode(false);

                entity.Property(e => e.BloCannelure10).IsUnicode(false);

                entity.Property(e => e.BloCannelure11).IsUnicode(false);

                entity.Property(e => e.BloCannelure12).IsUnicode(false);

                entity.Property(e => e.BloCannelure13).IsUnicode(false);

                entity.Property(e => e.BloCannelure14).IsUnicode(false);

                entity.Property(e => e.BloCannelure15).IsUnicode(false);

                entity.Property(e => e.BloCannelure16).IsUnicode(false);

                entity.Property(e => e.BloCannelure17).IsUnicode(false);

                entity.Property(e => e.BloCannelure18).IsUnicode(false);

                entity.Property(e => e.BloCannelure19).IsUnicode(false);

                entity.Property(e => e.BloCannelure2).IsUnicode(false);

                entity.Property(e => e.BloCannelure20).IsUnicode(false);

                entity.Property(e => e.BloCannelure21).IsUnicode(false);

                entity.Property(e => e.BloCannelure22).IsUnicode(false);

                entity.Property(e => e.BloCannelure23).IsUnicode(false);

                entity.Property(e => e.BloCannelure24).IsUnicode(false);

                entity.Property(e => e.BloCannelure25).IsUnicode(false);

                entity.Property(e => e.BloCannelure26).IsUnicode(false);

                entity.Property(e => e.BloCannelure27).IsUnicode(false);

                entity.Property(e => e.BloCannelure28).IsUnicode(false);

                entity.Property(e => e.BloCannelure29).IsUnicode(false);

                entity.Property(e => e.BloCannelure3).IsUnicode(false);

                entity.Property(e => e.BloCannelure30).IsUnicode(false);

                entity.Property(e => e.BloCannelure31).IsUnicode(false);

                entity.Property(e => e.BloCannelure32).IsUnicode(false);

                entity.Property(e => e.BloCannelure33).IsUnicode(false);

                entity.Property(e => e.BloCannelure34).IsUnicode(false);

                entity.Property(e => e.BloCannelure35).IsUnicode(false);

                entity.Property(e => e.BloCannelure36).IsUnicode(false);

                entity.Property(e => e.BloCannelure37).IsUnicode(false);

                entity.Property(e => e.BloCannelure38).IsUnicode(false);

                entity.Property(e => e.BloCannelure39).IsUnicode(false);

                entity.Property(e => e.BloCannelure4).IsUnicode(false);

                entity.Property(e => e.BloCannelure40).IsUnicode(false);

                entity.Property(e => e.BloCannelure41).IsUnicode(false);

                entity.Property(e => e.BloCannelure42).IsUnicode(false);

                entity.Property(e => e.BloCannelure43).IsUnicode(false);

                entity.Property(e => e.BloCannelure44).IsUnicode(false);

                entity.Property(e => e.BloCannelure45).IsUnicode(false);

                entity.Property(e => e.BloCannelure46).IsUnicode(false);

                entity.Property(e => e.BloCannelure47).IsUnicode(false);

                entity.Property(e => e.BloCannelure48).IsUnicode(false);

                entity.Property(e => e.BloCannelure49).IsUnicode(false);

                entity.Property(e => e.BloCannelure5).IsUnicode(false);

                entity.Property(e => e.BloCannelure50).IsUnicode(false);

                entity.Property(e => e.BloCannelure6).IsUnicode(false);

                entity.Property(e => e.BloCannelure7).IsUnicode(false);

                entity.Property(e => e.BloCannelure8).IsUnicode(false);

                entity.Property(e => e.BloCannelure9).IsUnicode(false);

                entity.Property(e => e.BloMontage).IsUnicode(false);

                entity.Property(e => e.BloOfinterne).IsUnicode(false);
            });

            modelBuilder.Entity<LDChronologieAcierie>(entity =>
            {
                entity.Property(e => e.OrdreVisualisation).ValueGeneratedNever();
            });

            modelBuilder.Entity<LDCommandes>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Administration).HasDefaultValueSql("('true')");
            });

            modelBuilder.Entity<LDConsignes>(entity =>
            {
                entity.HasKey(e => new { e.Of, e.CodeOperation, e.TypeConsigne, e.ConsigneGpao });

                entity.HasIndex(e => new { e.Of, e.CodeOperation })
                    .HasName("IX_FK_SectionCharggeConsignes");
            });

            modelBuilder.Entity<LDCoulee>(entity =>
            {
                entity.Property(e => e.IdCoulee).ValueGeneratedNever();

                entity.Property(e => e.DateReception).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EtatReception).HasDefaultValueSql("((1))");

                entity.Property(e => e.Externe).HasDefaultValueSql("('False')");
            });

            modelBuilder.Entity<LDCouleeSuivi>(entity =>
            {
                entity.Property(e => e.IdCoulee).ValueGeneratedNever();
            });

            modelBuilder.Entity<LDDefaut>(entity =>
            {
                entity.HasIndex(e => e.ParamDefautId)
                    .HasName("IX_FK_ParamDefautDefaut");

                entity.HasIndex(e => new { e.NumeroLingot, e.Coulee })
                    .HasName("IX_FK_PSODefaut");

                entity.HasOne(d => d.LDPso)
                    .WithMany(p => p.LDDefaut)
                    .HasForeignKey(d => new { d.NumeroLingot, d.Coulee })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PSODefaut");
            });

            modelBuilder.Entity<LDEtatStock>(entity =>
            {
                entity.Property(e => e.Lieu).ValueGeneratedNever();
            });

            modelBuilder.Entity<LDFourAcier>(entity =>
            {
                entity.Property(e => e.Coulee).ValueGeneratedNever();

                entity.Property(e => e.Nuance).IsUnicode(false);
            });

            modelBuilder.Entity<LDFours>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<LDKape22>(entity =>
            {
                entity.Property(e => e.DateReception).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LDKeycompteur>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<LDMajDateChecker>(entity =>
            {
                entity.Property(e => e.Table).ValueGeneratedNever();
            });

            modelBuilder.Entity<LDMamQual>(entity =>
            {
                entity.Property(e => e.Of).ValueGeneratedNever();
            });

            modelBuilder.Entity<LDMouvementStock>(entity =>
            {
                entity.Property(e => e.Etat).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<LDOfSuivi>(entity =>
            {
                entity.Property(e => e.Of).ValueGeneratedNever();

                entity.HasOne(d => d.OfNavigation)
                    .WithOne(p => p.LDOfSuivi)
                    .HasForeignKey<LDOfSuivi>(d => d.Of)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SuiviDeOFOrdreFabrication");
            });

            modelBuilder.Entity<LDOrdreFabrication>(entity =>
            {
                entity.HasIndex(e => e.Coulee)
                    .HasName("IX_FK_CouleeOrdreFabrication");

                entity.HasIndex(e => e.ProfilProduit)
                    .HasName("IX_FK_OrdreFabricationProfilProduit");

                entity.Property(e => e.Of).ValueGeneratedNever();

                entity.Property(e => e.DateMaj).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateReception).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CouleeNavigation)
                    .WithMany(p => p.LDOrdreFabrication)
                    .HasForeignKey(d => d.Coulee)
                    .HasConstraintName("FK_CouleeOrdreFabrication");

                entity.HasOne(d => d.ProfilProduitNavigation)
                    .WithMany(p => p.LDOrdreFabrication)
                    .HasForeignKey(d => d.ProfilProduit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdreFabricationProfilProduit");
            });

            modelBuilder.Entity<LDOutilsVor>(entity =>
            {
                entity.HasKey(e => e.Zone)
                    .HasName("PK_SetOfOutilsVORs");

                entity.Property(e => e.Zone).ValueGeneratedNever();
            });

            modelBuilder.Entity<LDPlansFours>(entity =>
            {
                entity.HasKey(e => new { e.FourId, e.Position });

                entity.HasIndex(e => e.IdCoulee)
                    .HasName("IX_FK_PlanFourCoulee");

                entity.HasIndex(e => e.Of)
                    .HasName("IX_FK_PlanFourOrdreFabrication");

                entity.HasIndex(e => new { e.NumeroLingot, e.IdCoulee })
                    .HasName("IX_FK_PlanFourPSO");

                entity.HasOne(d => d.Four)
                    .WithMany(p => p.LDPlansFours)
                    .HasForeignKey(d => d.FourId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FourPlanFour");

                entity.HasOne(d => d.IdCouleeNavigation)
                    .WithMany(p => p.LDPlansFours)
                    .HasForeignKey(d => d.IdCoulee)
                    .HasConstraintName("FK_PlanFourCoulee");

                entity.HasOne(d => d.OfNavigation)
                    .WithMany(p => p.LDPlansFours)
                    .HasForeignKey(d => d.Of)
                    .HasConstraintName("FK_PlanFourOrdreFabrication");
            });

            modelBuilder.Entity<LDProduitsOutil>(entity =>
            {
                entity.HasKey(e => new { e.Zone, e.Of });
            });

            modelBuilder.Entity<LDPso>(entity =>
            {
                entity.HasKey(e => new { e.NumeroLingot, e.Coulee });

                entity.HasIndex(e => e.Coulee)
                    .HasName("IX_FK_PSOCoulee");

                entity.HasIndex(e => e.Of)
                    .HasName("IX_FK_OrdreFabricationPSO");

                entity.Property(e => e.Externe).HasDefaultValueSql("('False')");

                entity.HasOne(d => d.CouleeNavigation)
                    .WithMany(p => p.LDPso)
                    .HasForeignKey(d => d.Coulee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PSOCoulee");

                entity.HasOne(d => d.OfNavigation)
                    .WithMany(p => p.LDPso)
                    .HasForeignKey(d => d.Of)
                    .HasConstraintName("FK_OrdreFabricationPSO");
            });

            modelBuilder.Entity<LDPsoComplement>(entity =>
            {
                entity.HasKey(e => new { e.NumeroLingot, e.Coulee });
            });

            modelBuilder.Entity<LDRebut>(entity =>
            {
                entity.HasKey(e => new { e.RangLingotPassageAuLaminoir, e.Of, e.DateRebut });

                entity.HasIndex(e => e.Of)
                    .HasName("IX_FK_RebutOrdreFabrication");

                entity.HasOne(d => d.OfNavigation)
                    .WithMany(p => p.LDRebut)
                    .HasForeignKey(d => d.Of)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RebutOrdreFabrication");
            });

            modelBuilder.Entity<LDReleveTemperature>(entity =>
            {
                entity.HasIndex(e => e.AdressesTemperatureId)
                    .HasName("IX_FK_AdressesTemperatureReleveTemperature");

                entity.HasOne(d => d.AdressesTemperature)
                    .WithMany(p => p.LDReleveTemperature)
                    .HasForeignKey(d => d.AdressesTemperatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdressesTemperatureReleveTemperature");
            });

            modelBuilder.Entity<LDRoles>(entity =>
            {
                entity.HasKey(e => new { e.Utilisateur, e.TransactionCode });

                entity.HasIndex(e => e.TransactionCode)
                    .HasName("IX_FK_TransactionUtilisateurs");

                entity.HasOne(d => d.TransactionCodeNavigation)
                    .WithMany(p => p.LDRoles)
                    .HasForeignKey(d => d.TransactionCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionUtilisateurs");
            });

            modelBuilder.Entity<LDSectionchargeChutage>(entity =>
            {
                entity.HasKey(e => new { e.Of, e.CodeOperation });

                entity.HasIndex(e => e.CodeOperation)
                    .HasName("IX_FK_SectionChargeChutageSuiviConsigneLaminage");

                entity.HasOne(d => d.CodeOperationNavigation)
                    .WithMany(p => p.LDSectionchargeChutage)
                    .HasForeignKey(d => d.CodeOperation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SectionChargeChutageSuiviConsigneLaminage");

                entity.HasOne(d => d.OfNavigation)
                    .WithMany(p => p.LDSectionchargeChutage)
                    .HasForeignKey(d => d.Of)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsignesChutageOrdreFabrication");
            });

            modelBuilder.Entity<LDSectionchargeDecoupe>(entity =>
            {
                entity.HasKey(e => new { e.Of, e.CodeOperation });

                entity.HasIndex(e => e.CodeOperation)
                    .HasName("IX_FK_SectionChargeDecoupeSuiviConsigneLaminage");

                entity.HasOne(d => d.CodeOperationNavigation)
                    .WithMany(p => p.LDSectionchargeDecoupe)
                    .HasForeignKey(d => d.CodeOperation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SectionChargeDecoupeSuiviConsigneLaminage");

                entity.HasOne(d => d.OfNavigation)
                    .WithMany(p => p.LDSectionchargeDecoupe)
                    .HasForeignKey(d => d.Of)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsignesDecoupeLingotOrdreFabrication");
            });

            modelBuilder.Entity<LDSectionchargeLingot>(entity =>
            {
                entity.HasKey(e => new { e.Of, e.CodeOperation });

                entity.HasIndex(e => e.CodeOperation)
                    .HasName("IX_FK_SectionChargeLingoSuiviConsigneLaminage");

                entity.HasOne(d => d.CodeOperationNavigation)
                    .WithMany(p => p.LDSectionchargeLingot)
                    .HasForeignKey(d => d.CodeOperation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SectionChargeLingoSuiviConsigneLaminage");

                entity.HasOne(d => d.OfNavigation)
                    .WithMany(p => p.LDSectionchargeLingot)
                    .HasForeignKey(d => d.Of)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsignesLingotOrdreFabrication");
            });

            modelBuilder.Entity<LDSectionchargePits>(entity =>
            {
                entity.HasKey(e => new { e.Of, e.CodeOperation });

                entity.HasIndex(e => e.CodeOperation)
                    .HasName("IX_FK_SectionChargeEnfournementPitsSuiviConsigneLaminage");

                entity.HasOne(d => d.CodeOperationNavigation)
                    .WithMany(p => p.LDSectionchargePits)
                    .HasForeignKey(d => d.CodeOperation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SectionChargeEnfournementPitsSuiviConsigneLaminage");

                entity.HasOne(d => d.OfNavigation)
                    .WithMany(p => p.LDSectionchargePits)
                    .HasForeignKey(d => d.Of)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsignesEnfournementPitsOrdreFabrication");
            });

            modelBuilder.Entity<LDSectionchargePoidsmetrique>(entity =>
            {
                entity.HasKey(e => new { e.Of, e.CodeOperation });

                entity.HasIndex(e => e.CodeOperation)
                    .HasName("IX_FK_SectionChargePoidsMetriqueSuiviConsigneLaminage");

                entity.HasOne(d => d.CodeOperationNavigation)
                    .WithMany(p => p.LDSectionchargePoidsmetrique)
                    .HasForeignKey(d => d.CodeOperation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SectionChargePoidsMetriqueSuiviConsigneLaminage");

                entity.HasOne(d => d.OfNavigation)
                    .WithMany(p => p.LDSectionchargePoidsmetrique)
                    .HasForeignKey(d => d.Of)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsignesPoidsMetriqueOrdreFabrication");
            });

            modelBuilder.Entity<LDSectionchargeRefroidissoirs>(entity =>
            {
                entity.HasKey(e => new { e.Of, e.CodeOperation });

                entity.HasIndex(e => e.CodeOperation)
                    .HasName("IX_FK_SectionChargeRefroidissoirSuiviConsigneLaminage");

                entity.HasOne(d => d.CodeOperationNavigation)
                    .WithMany(p => p.LDSectionchargeRefroidissoirs)
                    .HasForeignKey(d => d.CodeOperation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SectionChargeRefroidissoirSuiviConsigneLaminage");

                entity.HasOne(d => d.OfNavigation)
                    .WithMany(p => p.LDSectionchargeRefroidissoirs)
                    .HasForeignKey(d => d.Of)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsignesRefroidissoirOrdreFabrication");
            });

            modelBuilder.Entity<LDSectionchargeSvt>(entity =>
            {
                entity.HasKey(e => new { e.Of, e.CodeOperation });

                entity.HasIndex(e => e.CodeOperation)
                    .HasName("IX_FK_SuiviConsigneLaminageConsignesSVT");

                entity.HasOne(d => d.CodeOperationNavigation)
                    .WithMany(p => p.LDSectionchargeSvt)
                    .HasForeignKey(d => d.CodeOperation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SuiviConsigneLaminageConsignesSVT");

                entity.HasOne(d => d.OfNavigation)
                    .WithMany(p => p.LDSectionchargeSvt)
                    .HasForeignKey(d => d.Of)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsignesSVTOrdreFabrication");
            });

            modelBuilder.Entity<LDSousProduits>(entity =>
            {
                entity.HasKey(e => new { e.NumeroLingot, e.Coulee, e.NumProduit });

                entity.Property(e => e.NumProduit).HasDefaultValueSql("(' ')");

                entity.Property(e => e.ProduitFini).HasDefaultValueSql("('True')");

                entity.Property(e => e.ProfilProduit).HasDefaultValueSql("('BIL')");

                entity.HasOne(d => d.LDPso)
                    .WithMany(p => p.LDSousProduits)
                    .HasForeignKey(d => new { d.NumeroLingot, d.Coulee })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SousProduitPSO");
            });

            modelBuilder.Entity<LDStockPso>(entity =>
            {
                entity.HasKey(e => new { e.IdCoulee, e.NumeroLingot, e.Id });

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdCouleeNavigation)
                    .WithMany(p => p.LDStockPso)
                    .HasForeignKey(d => d.IdCoulee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CouleeStockPSO");

                entity.HasOne(d => d.LDPso)
                    .WithMany(p => p.LDStockPso)
                    .HasForeignKey(d => new { d.NumeroLingot, d.IdCoulee })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PSOStockPSO");
            });

            modelBuilder.Entity<LDVersion>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.DateMaj).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LDWatchdog>(entity =>
            {
                entity.Property(e => e.Niveau).ValueGeneratedNever();
            });

            modelBuilder.Entity<LDZone>(entity =>
            {
                entity.Property(e => e.Zone).ValueGeneratedNever();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<LPAdressesTemperature>(entity =>
            {
                entity.Property(e => e.Code).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LPBloomingProg>(entity =>
            {
                entity.Property(e => e.BloPcannelure1).IsUnicode(false);

                entity.Property(e => e.BloPcannelure10).IsUnicode(false);

                entity.Property(e => e.BloPcannelure11).IsUnicode(false);

                entity.Property(e => e.BloPcannelure12).IsUnicode(false);

                entity.Property(e => e.BloPcannelure13).IsUnicode(false);

                entity.Property(e => e.BloPcannelure14).IsUnicode(false);

                entity.Property(e => e.BloPcannelure15).IsUnicode(false);

                entity.Property(e => e.BloPcannelure16).IsUnicode(false);

                entity.Property(e => e.BloPcannelure17).IsUnicode(false);

                entity.Property(e => e.BloPcannelure18).IsUnicode(false);

                entity.Property(e => e.BloPcannelure19).IsUnicode(false);

                entity.Property(e => e.BloPcannelure2).IsUnicode(false);

                entity.Property(e => e.BloPcannelure20).IsUnicode(false);

                entity.Property(e => e.BloPcannelure21).IsUnicode(false);

                entity.Property(e => e.BloPcannelure22).IsUnicode(false);

                entity.Property(e => e.BloPcannelure23).IsUnicode(false);

                entity.Property(e => e.BloPcannelure24).IsUnicode(false);

                entity.Property(e => e.BloPcannelure25).IsUnicode(false);

                entity.Property(e => e.BloPcannelure26).IsUnicode(false);

                entity.Property(e => e.BloPcannelure27).IsUnicode(false);

                entity.Property(e => e.BloPcannelure28).IsUnicode(false);

                entity.Property(e => e.BloPcannelure29).IsUnicode(false);

                entity.Property(e => e.BloPcannelure3).IsUnicode(false);

                entity.Property(e => e.BloPcannelure30).IsUnicode(false);

                entity.Property(e => e.BloPcannelure31).IsUnicode(false);

                entity.Property(e => e.BloPcannelure32).IsUnicode(false);

                entity.Property(e => e.BloPcannelure33).IsUnicode(false);

                entity.Property(e => e.BloPcannelure34).IsUnicode(false);

                entity.Property(e => e.BloPcannelure35).IsUnicode(false);

                entity.Property(e => e.BloPcannelure36).IsUnicode(false);

                entity.Property(e => e.BloPcannelure37).IsUnicode(false);

                entity.Property(e => e.BloPcannelure38).IsUnicode(false);

                entity.Property(e => e.BloPcannelure39).IsUnicode(false);

                entity.Property(e => e.BloPcannelure4).IsUnicode(false);

                entity.Property(e => e.BloPcannelure40).IsUnicode(false);

                entity.Property(e => e.BloPcannelure41).IsUnicode(false);

                entity.Property(e => e.BloPcannelure42).IsUnicode(false);

                entity.Property(e => e.BloPcannelure43).IsUnicode(false);

                entity.Property(e => e.BloPcannelure44).IsUnicode(false);

                entity.Property(e => e.BloPcannelure45).IsUnicode(false);

                entity.Property(e => e.BloPcannelure46).IsUnicode(false);

                entity.Property(e => e.BloPcannelure47).IsUnicode(false);

                entity.Property(e => e.BloPcannelure48).IsUnicode(false);

                entity.Property(e => e.BloPcannelure49).IsUnicode(false);

                entity.Property(e => e.BloPcannelure5).IsUnicode(false);

                entity.Property(e => e.BloPcannelure50).IsUnicode(false);

                entity.Property(e => e.BloPcannelure6).IsUnicode(false);

                entity.Property(e => e.BloPcannelure7).IsUnicode(false);

                entity.Property(e => e.BloPcannelure8).IsUnicode(false);

                entity.Property(e => e.BloPcannelure9).IsUnicode(false);

                entity.Property(e => e.BloPmontage).IsUnicode(false);
            });

            modelBuilder.Entity<LPCellulesMesureLongueur>(entity =>
            {
                entity.Property(e => e.Cellule).ValueGeneratedNever();
            });

            modelBuilder.Entity<LPCodeoutilDecoupe>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<LPCoeffdilatation>(entity =>
            {
                entity.Property(e => e.Temperature).ValueGeneratedNever();
            });

            modelBuilder.Entity<LPConsignesChutage>(entity =>
            {
                entity.HasKey(e => new { e.CodeConsigne, e.Section, e.Consignes });

                entity.HasIndex(e => e.Consignes)
                    .HasName("IX_FK_TypeConsignesParamConsignesChutage");

                entity.HasOne(d => d.ConsignesNavigation)
                    .WithMany(p => p.LPConsignesChutage)
                    .HasForeignKey(d => d.Consignes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeConsignesParamConsignesChutage");
            });

            modelBuilder.Entity<LPConsignesCodeoutilCoupe>(entity =>
            {
                entity.HasKey(e => new { e.Section, e.Consignes, e.CodeConsigne });

                entity.HasIndex(e => e.Consignes)
                    .HasName("IX_FK_ParamConsignesCodeOutilCoupeTypeConsignes");

                entity.HasOne(d => d.ConsignesNavigation)
                    .WithMany(p => p.LPConsignesCodeoutilCoupe)
                    .HasForeignKey(d => d.Consignes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParamConsignesCodeOutilCoupeTypeConsignes");
            });

            modelBuilder.Entity<LPConsignesDecoupe>(entity =>
            {
                entity.HasKey(e => new { e.CodeConsigne, e.Section, e.Consignes });

                entity.HasIndex(e => e.Consignes)
                    .HasName("IX_FK_TypeConsignesParamConsignesDecoupe");

                entity.HasOne(d => d.ConsignesNavigation)
                    .WithMany(p => p.LPConsignesDecoupe)
                    .HasForeignKey(d => d.Consignes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeConsignesParamConsignesDecoupe");
            });

            modelBuilder.Entity<LPConsignesDegazageGlobal>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<LPConsignesLingot>(entity =>
            {
                entity.HasKey(e => new { e.CodeConsigne, e.Section, e.Consignes });

                entity.HasIndex(e => e.Consignes)
                    .HasName("IX_FK_TypeConsignesParamConsignesLingot");

                entity.HasOne(d => d.ConsignesNavigation)
                    .WithMany(p => p.LPConsignesLingot)
                    .HasForeignKey(d => d.Consignes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeConsignesParamConsignesLingot");
            });

            modelBuilder.Entity<LPConsignesMarquage>(entity =>
            {
                entity.HasKey(e => new { e.Section, e.Consignes, e.CodeConsigne });

                entity.HasIndex(e => e.Consignes)
                    .HasName("IX_FK_ParamConsignesMarquageTypeConsignes");

                entity.HasOne(d => d.ConsignesNavigation)
                    .WithMany(p => p.LPConsignesMarquage)
                    .HasForeignKey(d => d.Consignes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParamConsignesMarquageTypeConsignes");
            });

            modelBuilder.Entity<LPConsignesPits>(entity =>
            {
                entity.HasKey(e => new { e.CodeConsigne, e.Section, e.Consignes });

                entity.HasIndex(e => e.Consignes)
                    .HasName("IX_FK_TypeConsignesParamConsignesEnfournementPits");

                entity.HasOne(d => d.ConsignesNavigation)
                    .WithMany(p => p.LPConsignesPits)
                    .HasForeignKey(d => d.Consignes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeConsignesParamConsignesEnfournementPits");
            });

            modelBuilder.Entity<LPConsignesPoidsmetrique>(entity =>
            {
                entity.HasKey(e => new { e.CodeConsigne, e.Consignes, e.Section });

                entity.HasIndex(e => e.Consignes)
                    .HasName("IX_FK_TypeConsignesParamConsignesPoidsMetrique");

                entity.HasOne(d => d.ConsignesNavigation)
                    .WithMany(p => p.LPConsignesPoidsmetrique)
                    .HasForeignKey(d => d.Consignes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeConsignesParamConsignesPoidsMetrique");
            });

            modelBuilder.Entity<LPConsignesPrechauffageModification>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<LPConsignesPrechauffageParticulier>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<LPConsignesRefroidissement>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<LPConsignesRefroidissementBloom>(entity =>
            {
                entity.Property(e => e.CodeConsigne).ValueGeneratedNever();
            });

            modelBuilder.Entity<LPConsignesRefroidissementLingot>(entity =>
            {
                entity.Property(e => e.CodeConsigne).ValueGeneratedNever();
            });

            modelBuilder.Entity<LPConsignesRefroidissoirs>(entity =>
            {
                entity.HasKey(e => new { e.CodeConsigne, e.Section, e.Consignes });

                entity.HasIndex(e => e.Consignes)
                    .HasName("IX_FK_TypeConsignesParamConsignesRefroidissoir");

                entity.HasOne(d => d.ConsignesNavigation)
                    .WithMany(p => p.LPConsignesRefroidissoirs)
                    .HasForeignKey(d => d.Consignes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeConsignesParamConsignesRefroidissoir");
            });

            modelBuilder.Entity<LPConsignesScarfing>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<LPConsignesSmq>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<LPDefaut>(entity =>
            {
                entity.Property(e => e.Externe).HasDefaultValueSql("('false')");
            });

            modelBuilder.Entity<LPDelaisLivraison>(entity =>
            {
                entity.HasKey(e => new { e.Code, e.Lingot });
            });

            modelBuilder.Entity<LPDestination>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<LPJalonActiviteProfil>(entity =>
            {
                entity.Property(e => e.DateMaj).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LPJalonMotif>(entity =>
            {
                entity.Property(e => e.DateMaj).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LPLieuxStockLaminoir>(entity =>
            {
                entity.HasKey(e => new { e.Lieu, e.Id });

                entity.HasIndex(e => e.Idzone)
                    .HasName("IX_FK_ParamZoneStockLaminoirParamLieuxStockLaminoir");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdzoneNavigation)
                    .WithMany(p => p.LPLieuxStockLaminoir)
                    .HasForeignKey(d => d.Idzone)
                    .HasConstraintName("FK_ParamZoneStockLaminoirParamLieuxStockLaminoir");
            });

            modelBuilder.Entity<LPLieuxStockPaquetsPesee>(entity =>
            {
                entity.HasIndex(e => e.Lieu)
                    .HasName("IX_L_P_LIEUX_STOCK_PAQUETS_PESEE");
            });

            modelBuilder.Entity<LPParametresGeneraux>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<LPProfilProduit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<LPPso>(entity =>
            {
                entity.Property(e => e.CodePso).ValueGeneratedNever();

                entity.Property(e => e.DateMaj).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LPRepere>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<LPRepereAutoLingot>(entity =>
            {
                entity.HasKey(e => new { e.AnomalieCop, e.Lingot });
            });

            modelBuilder.Entity<LPTextOperations>(entity =>
            {
                entity.Property(e => e.CodeOperation).ValueGeneratedNever();
            });

            modelBuilder.Entity<LPTypeConsigne>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<LSBlooming>(entity =>
            {
                entity.Property(e => e.IsCouleeChaude).HasDefaultValueSql("('True')");

                entity.Property(e => e.IsOfessai).HasDefaultValueSql("('False')");
            });

            modelBuilder.Entity<LSLaminoir>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<LSRapportSyntheseMensuelle>(entity =>
            {
                entity.Property(e => e.LabelDate).IsUnicode(false);

                entity.Property(e => e.LabelNom).IsUnicode(false);

                entity.Property(e => e.NomCol).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}