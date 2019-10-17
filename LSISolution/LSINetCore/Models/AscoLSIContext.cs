using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LSINetCore.Models
{
    public partial class AscoLSIContext : DbContext
    {
        public AscoLSIContext()
        {
        }

        public AscoLSIContext(DbContextOptions<AscoLSIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AggregatedCounter> AggregatedCounter { get; set; }
        public virtual DbSet<AscoEtatStockCoulee> AscoEtatStockCoulee { get; set; }
        public virtual DbSet<AscoEtatStockRejet> AscoEtatStockRejet { get; set; }
        public virtual DbSet<AscoEtatStockTmp> AscoEtatStockTmp { get; set; }
        public virtual DbSet<AscoEtatStockTrace> AscoEtatStockTrace { get; set; }
        public virtual DbSet<AtosTrace> AtosTrace { get; set; }
        public virtual DbSet<AtosTrace2> AtosTrace2 { get; set; }
        public virtual DbSet<Counter> Counter { get; set; }
        public virtual DbSet<Hash> Hash { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobParameter> JobParameter { get; set; }
        public virtual DbSet<JobQueue> JobQueue { get; set; }
        public virtual DbSet<LD1500tCamera> LD1500tCamera { get; set; }
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
        public virtual DbSet<LDRolesTmp> LDRolesTmp { get; set; }
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
        public virtual DbSet<LDTraceArchivage> LDTraceArchivage { get; set; }
        public virtual DbSet<LDVersion> LDVersion { get; set; }
        public virtual DbSet<LDWatchdog> LDWatchdog { get; set; }
        public virtual DbSet<LDZone> LDZone { get; set; }
        public virtual DbSet<LDZoneSuivi> LDZoneSuivi { get; set; }
        public virtual DbSet<LPAdressesTemperature> LPAdressesTemperature { get; set; }
        public virtual DbSet<LPAnomalies> LPAnomalies { get; set; }
        public virtual DbSet<LPArret> LPArret { get; set; }
        public virtual DbSet<LPBloomingProg> LPBloomingProg { get; set; }
        public virtual DbSet<LPBloomingProgTmp> LPBloomingProgTmp { get; set; }
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
        public virtual DbSet<LSBilanPitsCoulee> LSBilanPitsCoulee { get; set; }
        public virtual DbSet<LSBilanPitsFroid> LSBilanPitsFroid { get; set; }
        public virtual DbSet<LSBilanPitsSynthese> LSBilanPitsSynthese { get; set; }
        public virtual DbSet<LSBlooming> LSBlooming { get; set; }
        public virtual DbSet<LSCapteurZoneSuivi> LSCapteurZoneSuivi { get; set; }
        public virtual DbSet<LSDetailOfcapteur> LSDetailOfcapteur { get; set; }
        public virtual DbSet<LSLaminoir> LSLaminoir { get; set; }
        public virtual DbSet<LSLpb> LSLpb { get; set; }
        public virtual DbSet<LSOptiLgBarre> LSOptiLgBarre { get; set; }
        public virtual DbSet<LSProduction> LSProduction { get; set; }
        public virtual DbSet<LSProductionLsi> LSProductionLsi { get; set; }
        public virtual DbSet<LSProductionLsiTotal> LSProductionLsiTotal { get; set; }
        public virtual DbSet<LSRapportSyntheseMensuelle> LSRapportSyntheseMensuelle { get; set; }
        public virtual DbSet<LSSyntheseProductionMensuelle> LSSyntheseProductionMensuelle { get; set; }
        public virtual DbSet<List> List { get; set; }
        public virtual DbSet<LsiBilanCoulee> LsiBilanCoulee { get; set; }
        public virtual DbSet<LsiReportTrace> LsiReportTrace { get; set; }
        public virtual DbSet<LsiResultatsTxt> LsiResultatsTxt { get; set; }
        public virtual DbSet<Schema> Schema { get; set; }
        public virtual DbSet<Server> Server { get; set; }
        public virtual DbSet<Set> Set { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Tmpblocote> Tmpblocote { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=HNW18-Z8\\SQLEXPRESS;Database=AscoLSI;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_HangFire_CounterAggregated");

                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_AggregatedCounter_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<AscoEtatStockCoulee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASCO_ETAT_STOCK_COULEE");

                entity.Property(e => e.AnomalieApc)
                    .HasColumnName("AnomalieAPC")
                    .HasMaxLength(100);

                entity.Property(e => e.AnomalieApcrh)
                    .HasColumnName("AnomalieAPCRH")
                    .HasMaxLength(100);

                entity.Property(e => e.AnomalieRh)
                    .HasColumnName("AnomalieRH")
                    .HasMaxLength(100);

                entity.Property(e => e.AnomaliesCoulee).HasMaxLength(100);

                entity.Property(e => e.AnomaliesDegazeur).HasMaxLength(100);

                entity.Property(e => e.AnomaliesDemoulage).HasMaxLength(100);

                entity.Property(e => e.ArriveeEnfournementWagon1).HasMaxLength(100);

                entity.Property(e => e.ArriveeEnfournementWagon2).HasMaxLength(100);

                entity.Property(e => e.CodeLivraison).HasMaxLength(100);

                entity.Property(e => e.CouleeFroide).HasMaxLength(100);

                entity.Property(e => e.DateCopapc)
                    .HasColumnName("DateCOPAPC")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCopcoulee)
                    .HasColumnName("DateCOPCoulee")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCopdemoulage)
                    .HasColumnName("DateCOPDemoulage")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCoprh)
                    .HasColumnName("DateCOPRH")
                    .HasMaxLength(100);

                entity.Property(e => e.DateReception).HasMaxLength(100);

                entity.Property(e => e.DebutCoulee).HasMaxLength(100);

                entity.Property(e => e.DebutDemoulage).HasMaxLength(100);

                entity.Property(e => e.Degazee).HasMaxLength(100);

                entity.Property(e => e.DelaisLivraisonWagon1).HasMaxLength(100);

                entity.Property(e => e.DelaisLivraisonWagon2).HasMaxLength(100);

                entity.Property(e => e.DensiteCoulee).HasMaxLength(100);

                entity.Property(e => e.DerniereModif).HasMaxLength(100);

                entity.Property(e => e.EcartWagon1).HasMaxLength(100);

                entity.Property(e => e.EcartWagon2).HasMaxLength(100);

                entity.Property(e => e.Enregistrement).HasMaxLength(100);

                entity.Property(e => e.EstConformiteCoulee).HasMaxLength(100);

                entity.Property(e => e.EstEnfournementStandard).HasMaxLength(100);

                entity.Property(e => e.EstHomogene).HasMaxLength(100);

                entity.Property(e => e.EstTroisQuartsConforme).HasMaxLength(100);

                entity.Property(e => e.EtatReception).HasMaxLength(100);

                entity.Property(e => e.Externe).HasMaxLength(100);

                entity.Property(e => e.FinCoulee).HasMaxLength(100);

                entity.Property(e => e.FinDemDernierLgtWagon1).HasMaxLength(100);

                entity.Property(e => e.FinDemDernierLgtWagon2).HasMaxLength(100);

                entity.Property(e => e.HeureArriveeWagon1).HasMaxLength(100);

                entity.Property(e => e.HeureArriveeWagon2).HasMaxLength(100);

                entity.Property(e => e.HeureDepartWagon1).HasMaxLength(100);

                entity.Property(e => e.HeureDepartWagon2).HasMaxLength(100);

                entity.Property(e => e.HeurePrevuDemoulage).HasMaxLength(100);

                entity.Property(e => e.Hydrogene).HasMaxLength(100);

                entity.Property(e => e.IdCoulee).HasMaxLength(100);

                entity.Property(e => e.LingotPiscine).HasMaxLength(100);

                entity.Property(e => e.MarqueFroide).HasMaxLength(100);

                entity.Property(e => e.ModeElaboration).HasMaxLength(100);

                entity.Property(e => e.NbLingotRestantArefroidir)
                    .HasColumnName("NbLingotRestantARefroidir")
                    .HasMaxLength(100);

                entity.Property(e => e.NombreLingotAir).HasMaxLength(100);

                entity.Property(e => e.NombreLingotBacVerniculite).HasMaxLength(100);

                entity.Property(e => e.NombreLingotPitsSec).HasMaxLength(100);

                entity.Property(e => e.NombreLingotsWagon1).HasMaxLength(100);

                entity.Property(e => e.NombreLingotsWagon2).HasMaxLength(100);

                entity.Property(e => e.NombreTypelingot1).HasMaxLength(100);

                entity.Property(e => e.NombreTypelingot2).HasMaxLength(100);

                entity.Property(e => e.Nuance).HasMaxLength(100);

                entity.Property(e => e.NumerosLingotRebutes).HasMaxLength(100);

                entity.Property(e => e.Observation2).HasMaxLength(100);

                entity.Property(e => e.Observations).HasMaxLength(100);

                entity.Property(e => e.OperateurCoulee).HasMaxLength(100);

                entity.Property(e => e.OperateurDegazeur).HasMaxLength(100);

                entity.Property(e => e.OperateurDemoulage).HasMaxLength(100);

                entity.Property(e => e.Piscinage).HasMaxLength(100);

                entity.Property(e => e.PiscinageWagon1).HasMaxLength(100);

                entity.Property(e => e.PiscinageWagon2).HasMaxLength(100);

                entity.Property(e => e.PoidsMoyenLingotMere1).HasMaxLength(100);

                entity.Property(e => e.PoidsMoyenLingotMere2).HasMaxLength(100);

                entity.Property(e => e.PoidsMoyenLingotMere3).HasMaxLength(100);

                entity.Property(e => e.PoidsMoyenLingotMere4).HasMaxLength(100);

                entity.Property(e => e.PoidsUnitaireLingot1).HasMaxLength(100);

                entity.Property(e => e.PoidsUnitaireLingot2).HasMaxLength(100);

                entity.Property(e => e.ProgrammeSmq)
                    .HasColumnName("ProgrammeSMQ")
                    .HasMaxLength(100);

                entity.Property(e => e.ResponsableTraitement).HasMaxLength(100);

                entity.Property(e => e.RetardDemoulage).HasMaxLength(100);

                entity.Property(e => e.RetardLivraisonWagon1).HasMaxLength(100);

                entity.Property(e => e.RetardLivraisonWagon2).HasMaxLength(100);

                entity.Property(e => e.SaturationPits).HasMaxLength(100);

                entity.Property(e => e.SauvetageWagon1).HasMaxLength(100);

                entity.Property(e => e.SauvetageWagon2).HasMaxLength(100);

                entity.Property(e => e.TypeLingot1).HasMaxLength(100);

                entity.Property(e => e.TypeLingot2).HasMaxLength(100);
            });

            modelBuilder.Entity<AscoEtatStockRejet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASCO_ETAT_STOCK_REJET");

                entity.Property(e => e.Coulee)
                    .HasColumnName("coulee")
                    .HasMaxLength(6);

                entity.Property(e => e.Lieu)
                    .HasColumnName("lieu")
                    .HasMaxLength(50);

                entity.Property(e => e.LsiLieu)
                    .HasColumnName("lsi_lieu")
                    .HasMaxLength(25);

                entity.Property(e => e.LsiParc)
                    .HasColumnName("lsi_parc")
                    .HasMaxLength(15);

                entity.Property(e => e.NbLignot).HasColumnName("nb_lignot");

                entity.Property(e => e.Nuance)
                    .HasColumnName("nuance")
                    .HasMaxLength(25);

                entity.Property(e => e.NumEnreg).HasColumnName("num_enreg");

                entity.Property(e => e.Parc)
                    .HasColumnName("parc")
                    .HasMaxLength(50);

                entity.Property(e => e.Pso)
                    .HasColumnName("PSO")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<AscoEtatStockTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASCO_ETAT_STOCK_TMP");

                entity.Property(e => e.Coulee)
                    .HasColumnName("coulee")
                    .HasMaxLength(6);

                entity.Property(e => e.Lieu)
                    .HasColumnName("lieu")
                    .HasMaxLength(50);

                entity.Property(e => e.LsiLieu)
                    .HasColumnName("lsi_lieu")
                    .HasMaxLength(25);

                entity.Property(e => e.LsiParc)
                    .HasColumnName("lsi_parc")
                    .HasMaxLength(15);

                entity.Property(e => e.NbLignot).HasColumnName("nb_lignot");

                entity.Property(e => e.Nuance)
                    .HasColumnName("nuance")
                    .HasMaxLength(25);

                entity.Property(e => e.NumEnreg).HasColumnName("num_enreg");

                entity.Property(e => e.Parc)
                    .HasColumnName("parc")
                    .HasMaxLength(50);

                entity.Property(e => e.Pso)
                    .HasColumnName("PSO")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<AscoEtatStockTrace>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASCO_ETAT_STOCK_TRACE");

                entity.Property(e => e.DateTrace)
                    .HasColumnName("date_trace")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1024);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(255);

                entity.Property(e => e.NumEnreg).HasColumnName("num_enreg");
            });

            modelBuilder.Entity<AtosTrace>(entity =>
            {
                entity.ToTable("ATOS_TRACE");

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.NombrePdf).HasColumnName("NombrePDF");

                entity.Property(e => e.NombrePf).HasColumnName("NombrePF");

                entity.Property(e => e.NumLingotAcierie).HasMaxLength(2);

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12);

                entity.Property(e => e.Pdf)
                    .HasColumnName("PDF")
                    .HasMaxLength(10);

                entity.Property(e => e.Pf)
                    .HasColumnName("PF")
                    .HasMaxLength(8);

                entity.Property(e => e.RangLaminage).HasMaxLength(2);

                entity.Property(e => e.RepereLingot).HasMaxLength(4);

                entity.Property(e => e.VorO).HasColumnName("VOR_O");

                entity.Property(e => e.VorR).HasColumnName("VOR_R");

                entity.Property(e => e.VorV).HasColumnName("VOR_V");

                entity.Property(e => e.Zone)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<AtosTrace2>(entity =>
            {
                entity.ToTable("ATOS_TRACE2");

                entity.Property(e => e.Capteur)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => e.Key)
                    .HasName("CX_HangFire_Counter")
                    .IsClustered();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Field })
                    .HasName("PK_HangFire_Hash");

                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Hash_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Field).HasMaxLength(100);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.StateName)
                    .HasName("IX_HangFire_Job_StateName")
                    .HasFilter("([StateName] IS NOT NULL)");

                entity.HasIndex(e => new { e.StateName, e.ExpireAt })
                    .HasName("IX_HangFire_Job_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.InvocationData).IsRequired();

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Name })
                    .HasName("PK_HangFire_JobParameter");

                entity.ToTable("JobParameter", "HangFire");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameter)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.HasKey(e => new { e.Queue, e.Id })
                    .HasName("PK_HangFire_JobQueue");

                entity.ToTable("JobQueue", "HangFire");

                entity.Property(e => e.Queue).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<LD1500tCamera>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("L_D_1500T_CAMERA");

                entity.Property(e => e.DateDebutVideo).HasColumnType("datetime");

                entity.Property(e => e.DateFinVideo).HasColumnType("datetime");

                entity.Property(e => e.DatePassage1500T).HasColumnType("datetime");

                entity.Property(e => e.IdCamera)
                    .HasColumnName("Id_Camera")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Of)
                    .IsRequired()
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.VideoCamera1)
                    .HasColumnName("Video_Camera1")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.VideoCamera2)
                    .HasColumnName("Video_Camera2")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LDAnomalies>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdCoulee });

                entity.ToTable("L_D_ANOMALIES");

                entity.HasIndex(e => e.IdCoulee)
                    .HasName("IX_FK_AnomaliesCoulee");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdCoulee)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Action).HasMaxLength(100);

                entity.Property(e => e.DerniereModif).HasColumnType("datetime");

                entity.Property(e => e.Detail).HasMaxLength(100);

                entity.Property(e => e.Enregistrement)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Lingots).HasMaxLength(250);

                entity.Property(e => e.Reperage).HasMaxLength(50);

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

            modelBuilder.Entity<LDArret>(entity =>
            {
                entity.ToTable("L_D_ARRET");

                entity.Property(e => e.CodeArretReference)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.DateDebut).HasColumnType("datetime");

                entity.Property(e => e.DateFin).HasColumnType("datetime");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.OtCode).HasMaxLength(25);
            });

            modelBuilder.Entity<LDAsiSuivi>(entity =>
            {
                entity.ToTable("L_D_ASI_SUIVI");

                entity.Property(e => e.Commande).HasMaxLength(15);

                entity.Property(e => e.Coulee)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Message).HasMaxLength(250);

                entity.Property(e => e.NoEnregistrement)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<LDBilletteLaminage>(entity =>
            {
                entity.ToTable("L_D_BILLETTE_LAMINAGE");

                entity.Property(e => e.CanelurePasse1).HasMaxLength(2);

                entity.Property(e => e.CanelurePasse10).HasMaxLength(2);

                entity.Property(e => e.CanelurePasse11).HasMaxLength(2);

                entity.Property(e => e.CanelurePasse12).HasMaxLength(2);

                entity.Property(e => e.CanelurePasse13).HasMaxLength(2);

                entity.Property(e => e.CanelurePasse14).HasMaxLength(2);

                entity.Property(e => e.CanelurePasse15).HasMaxLength(2);

                entity.Property(e => e.CanelurePasse2).HasMaxLength(2);

                entity.Property(e => e.CanelurePasse3).HasMaxLength(2);

                entity.Property(e => e.CanelurePasse4).HasMaxLength(2);

                entity.Property(e => e.CanelurePasse5).HasMaxLength(2);

                entity.Property(e => e.CanelurePasse6).HasMaxLength(2);

                entity.Property(e => e.CanelurePasse7).HasMaxLength(2);

                entity.Property(e => e.CanelurePasse8).HasMaxLength(2);

                entity.Property(e => e.CanelurePasse9).HasMaxLength(2);

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.ElevationPasse1).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse10).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse11).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse12).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse13).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse14).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse15).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse2).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse3).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse4).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse5).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse6).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse7).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse8).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse9).HasMaxLength(4);

                entity.Property(e => e.Of)
                    .IsRequired()
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LDBloomingLaminage>(entity =>
            {
                entity.HasKey(e => e.IdBloLaminage)
                    .HasName("PK_L_BLOOMING_LAMINAGE");

                entity.ToTable("L_D_BLOOMING_LAMINAGE");

                entity.Property(e => e.BloCannelure1)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure10)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure11)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure12)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure13)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure14)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure15)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure16)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure17)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure18)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure19)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure2)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure20)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure21)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure22)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure23)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure24)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure25)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure26)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure27)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure28)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure29)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure3)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure30)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure31)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure32)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure33)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure34)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure35)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure36)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure37)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure38)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure39)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure4)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure40)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure41)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure42)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure43)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure44)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure45)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure46)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure47)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure48)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure49)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure5)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure50)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure6)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure7)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure8)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloCannelure9)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloDateLaminage).HasColumnType("datetime");

                entity.Property(e => e.BloMontage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BloOfinterne)
                    .IsRequired()
                    .HasColumnName("BloOFInterne")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LDCages>(entity =>
            {
                entity.ToTable("L_D_CAGES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cannelure1).HasMaxLength(4);

                entity.Property(e => e.Cannelure10).HasMaxLength(4);

                entity.Property(e => e.Cannelure11).HasMaxLength(4);

                entity.Property(e => e.Cannelure12).HasMaxLength(4);

                entity.Property(e => e.Cannelure13).HasMaxLength(4);

                entity.Property(e => e.Cannelure14).HasMaxLength(4);

                entity.Property(e => e.Cannelure15).HasMaxLength(4);

                entity.Property(e => e.Cannelure2).HasMaxLength(4);

                entity.Property(e => e.Cannelure3).HasMaxLength(4);

                entity.Property(e => e.Cannelure4).HasMaxLength(4);

                entity.Property(e => e.Cannelure5).HasMaxLength(4);

                entity.Property(e => e.Cannelure6).HasMaxLength(4);

                entity.Property(e => e.Cannelure7).HasMaxLength(4);

                entity.Property(e => e.Cannelure8).HasMaxLength(4);

                entity.Property(e => e.Cannelure9).HasMaxLength(4);

                entity.Property(e => e.Commentaire)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DateChangement).HasColumnType("datetime");

                entity.Property(e => e.DateMiseAdisposition)
                    .HasColumnName("DateMiseADisposition")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateMiseEnService).HasColumnType("datetime");

                entity.Property(e => e.DateMiseHorsService).HasColumnType("datetime");

                entity.Property(e => e.DatePremiereMiseEnService).HasColumnType("datetime");

                entity.Property(e => e.DateUsinage).HasColumnType("datetime");

                entity.Property(e => e.DiametreInferieur).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.DiametreSuperieur).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.Fournisseur).HasMaxLength(100);

                entity.Property(e => e.Largeur2Cannelure1).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Largeur2Cannelure10).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Largeur2Cannelure11).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Largeur2Cannelure12).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Largeur2Cannelure13).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Largeur2Cannelure14).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Largeur2Cannelure15).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Largeur2Cannelure2).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Largeur2Cannelure3).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Largeur2Cannelure4).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Largeur2Cannelure5).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Largeur2Cannelure6).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Largeur2Cannelure7).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Largeur2Cannelure8).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Largeur2Cannelure9).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LargeurCannelure1).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LargeurCannelure10).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LargeurCannelure11).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LargeurCannelure12).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LargeurCannelure13).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LargeurCannelure14).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LargeurCannelure15).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LargeurCannelure2).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LargeurCannelure3).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LargeurCannelure4).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LargeurCannelure5).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LargeurCannelure6).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LargeurCannelure7).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LargeurCannelure8).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LargeurCannelure9).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Longueur).HasColumnType("decimal(5, 3)");

                entity.Property(e => e.NumCage)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.NumCylInferieur).HasMaxLength(15);

                entity.Property(e => e.NumCylSuperieur).HasMaxLength(15);

                entity.Property(e => e.Observations).HasMaxLength(50);

                entity.Property(e => e.Profondeur).HasColumnType("decimal(5, 3)");

                entity.Property(e => e.Profondeur2Cannelure1).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Profondeur2Cannelure10).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Profondeur2Cannelure11).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Profondeur2Cannelure12).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Profondeur2Cannelure13).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Profondeur2Cannelure14).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Profondeur2Cannelure15).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Profondeur2Cannelure2).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Profondeur2Cannelure3).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Profondeur2Cannelure4).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Profondeur2Cannelure5).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Profondeur2Cannelure6).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Profondeur2Cannelure7).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Profondeur2Cannelure8).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Profondeur2Cannelure9).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProfondeurCannelure1).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProfondeurCannelure10).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProfondeurCannelure11).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProfondeurCannelure12).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProfondeurCannelure13).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProfondeurCannelure14).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProfondeurCannelure15).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProfondeurCannelure2).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProfondeurCannelure3).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProfondeurCannelure4).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProfondeurCannelure5).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProfondeurCannelure6).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProfondeurCannelure7).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProfondeurCannelure8).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProfondeurCannelure9).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Zone)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LDCapteur>(entity =>
            {
                entity.ToTable("L_D_CAPTEUR");

                entity.Property(e => e.Capteur)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<LDCapteurSuivi>(entity =>
            {
                entity.ToTable("L_D_CAPTEUR_SUIVI");

                entity.Property(e => e.Capteur)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<LDChronologieAcierie>(entity =>
            {
                entity.HasKey(e => e.OrdreVisualisation);

                entity.ToTable("L_D_CHRONOLOGIE_ACIERIE");

                entity.Property(e => e.OrdreVisualisation)
                    .HasColumnName("ordre_visualisation")
                    .ValueGeneratedNever();

                entity.Property(e => e.Afficher).HasColumnName("afficher");

                entity.Property(e => e.Atelier)
                    .HasColumnName("atelier")
                    .HasMaxLength(40);

                entity.Property(e => e.DonneesCoulee1)
                    .HasColumnName("donnees_coulee1")
                    .HasMaxLength(16);

                entity.Property(e => e.DonneesCoulee10)
                    .HasColumnName("donnees_coulee10")
                    .HasMaxLength(16);

                entity.Property(e => e.DonneesCoulee11)
                    .HasColumnName("donnees_coulee11")
                    .HasMaxLength(16);

                entity.Property(e => e.DonneesCoulee12)
                    .HasColumnName("donnees_coulee12")
                    .HasMaxLength(16);

                entity.Property(e => e.DonneesCoulee13)
                    .HasColumnName("donnees_coulee13")
                    .HasMaxLength(16);

                entity.Property(e => e.DonneesCoulee14)
                    .HasColumnName("donnees_coulee14")
                    .HasMaxLength(16);

                entity.Property(e => e.DonneesCoulee15)
                    .HasColumnName("donnees_coulee15")
                    .HasMaxLength(16);

                entity.Property(e => e.DonneesCoulee2)
                    .HasColumnName("donnees_coulee2")
                    .HasMaxLength(16);

                entity.Property(e => e.DonneesCoulee3)
                    .HasColumnName("donnees_coulee3")
                    .HasMaxLength(16);

                entity.Property(e => e.DonneesCoulee4)
                    .HasColumnName("donnees_coulee4")
                    .HasMaxLength(16);

                entity.Property(e => e.DonneesCoulee5)
                    .HasColumnName("donnees_coulee5")
                    .HasMaxLength(16);

                entity.Property(e => e.DonneesCoulee6)
                    .HasColumnName("donnees_coulee6")
                    .HasMaxLength(16);

                entity.Property(e => e.DonneesCoulee7)
                    .HasColumnName("donnees_coulee7")
                    .HasMaxLength(16);

                entity.Property(e => e.DonneesCoulee8)
                    .HasColumnName("donnees_coulee8")
                    .HasMaxLength(16);

                entity.Property(e => e.DonneesCoulee9)
                    .HasColumnName("donnees_coulee9")
                    .HasMaxLength(16);

                entity.Property(e => e.EtatPhase)
                    .HasColumnName("etat_phase")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<LDCommandes>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("L_D_COMMANDES");

                entity.Property(e => e.Code).HasMaxLength(8);

                entity.Property(e => e.Administration)
                    .IsRequired()
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Crb).HasColumnName("CRB");

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle).IsRequired();
            });

            modelBuilder.Entity<LDConsignes>(entity =>
            {
                entity.HasKey(e => new { e.Of, e.CodeOperation, e.TypeConsigne, e.ConsigneGpao });

                entity.ToTable("L_D_CONSIGNES");

                entity.HasIndex(e => new { e.Of, e.CodeOperation })
                    .HasName("IX_FK_SectionCharggeConsignes");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.CodeOperation)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ConsigneGpao).HasColumnName("ConsigneGPAO");

                entity.Property(e => e.CodeConsigne)
                    .IsRequired()
                    .HasMaxLength(18);
            });

            modelBuilder.Entity<LDCoulee>(entity =>
            {
                entity.HasKey(e => e.IdCoulee);

                entity.ToTable("L_D_COULEE");

                entity.Property(e => e.IdCoulee)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AnomalieApc).HasColumnName("AnomalieAPC");

                entity.Property(e => e.AnomalieApcrh).HasColumnName("AnomalieAPCRH");

                entity.Property(e => e.AnomalieRh).HasColumnName("AnomalieRH");

                entity.Property(e => e.ArriveeEnfournementWagon1).HasColumnType("datetime");

                entity.Property(e => e.ArriveeEnfournementWagon2).HasColumnType("datetime");

                entity.Property(e => e.CodeLivraison).HasMaxLength(10);

                entity.Property(e => e.DateCopapc)
                    .HasColumnName("DateCOPAPC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCopcoulee)
                    .HasColumnName("DateCOPCoulee")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCopdemoulage)
                    .HasColumnName("DateCOPDemoulage")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCoprh)
                    .HasColumnName("DateCOPRH")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateReception)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DebutCoulee).HasColumnType("datetime");

                entity.Property(e => e.DebutDemoulage).HasColumnType("datetime");

                entity.Property(e => e.DelaisLivraisonWagon1).HasColumnType("datetime");

                entity.Property(e => e.DelaisLivraisonWagon2).HasColumnType("datetime");

                entity.Property(e => e.DensiteCoulee).HasColumnType("decimal(5, 3)");

                entity.Property(e => e.DerniereModif).HasColumnType("datetime");

                entity.Property(e => e.EcartWagon1).HasColumnType("datetime");

                entity.Property(e => e.EcartWagon2).HasColumnType("datetime");

                entity.Property(e => e.Enregistrement)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.EtatReception).HasDefaultValueSql("((1))");

                entity.Property(e => e.Externe)
                    .IsRequired()
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.FinCoulee).HasColumnType("datetime");

                entity.Property(e => e.FinDemDernierLgtWagon1).HasColumnType("datetime");

                entity.Property(e => e.FinDemDernierLgtWagon2).HasColumnType("datetime");

                entity.Property(e => e.HeureArriveeWagon1).HasColumnType("datetime");

                entity.Property(e => e.HeureArriveeWagon2).HasColumnType("datetime");

                entity.Property(e => e.HeureDepartWagon1).HasColumnType("datetime");

                entity.Property(e => e.HeureDepartWagon2).HasColumnType("datetime");

                entity.Property(e => e.HeurePrevuDemoulage).HasColumnType("datetime");

                entity.Property(e => e.Hydrogene).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.NbLingotRestantArefroidir).HasColumnName("NbLingotRestantARefroidir");

                entity.Property(e => e.Nuance)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.Observation2).HasMaxLength(100);

                entity.Property(e => e.OperateurCoulee).HasMaxLength(30);

                entity.Property(e => e.OperateurDegazeur).HasMaxLength(10);

                entity.Property(e => e.OperateurDemoulage).HasMaxLength(10);

                entity.Property(e => e.ProgrammeSmq)
                    .HasColumnName("ProgrammeSMQ")
                    .HasMaxLength(3);

                entity.Property(e => e.ResponsableTraitement).HasMaxLength(30);

                entity.Property(e => e.TypeLingot1)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.TypeLingot2)
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LDCouleeSuivi>(entity =>
            {
                entity.HasKey(e => e.IdCoulee);

                entity.ToTable("L_D_COULEE_SUIVI");

                entity.Property(e => e.IdCoulee)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AnomalieApc).HasColumnName("AnomalieAPC");

                entity.Property(e => e.AnomalieApcrh).HasColumnName("AnomalieAPCRH");

                entity.Property(e => e.AnomalieRh).HasColumnName("AnomalieRH");

                entity.Property(e => e.ArriveeEnfournementWagon1).HasColumnType("datetime");

                entity.Property(e => e.ArriveeEnfournementWagon2).HasColumnType("datetime");

                entity.Property(e => e.CodeLivraison).HasMaxLength(10);

                entity.Property(e => e.DateCopapc)
                    .HasColumnName("DateCOPAPC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCopcoulee)
                    .HasColumnName("DateCOPCoulee")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCopdemoulage)
                    .HasColumnName("DateCOPDemoulage")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCoprh)
                    .HasColumnName("DateCOPRH")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateReception).HasColumnType("datetime");

                entity.Property(e => e.DebutCoulee).HasColumnType("datetime");

                entity.Property(e => e.DebutDemoulage).HasColumnType("datetime");

                entity.Property(e => e.DelaisLivraisonWagon1).HasColumnType("datetime");

                entity.Property(e => e.DelaisLivraisonWagon2).HasColumnType("datetime");

                entity.Property(e => e.DensiteCoulee).HasColumnType("decimal(5, 3)");

                entity.Property(e => e.DerniereModif).HasColumnType("datetime");

                entity.Property(e => e.EcartWagon1).HasColumnType("datetime");

                entity.Property(e => e.EcartWagon2).HasColumnType("datetime");

                entity.Property(e => e.Enregistrement)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.FinCoulee).HasColumnType("datetime");

                entity.Property(e => e.FinDemDernierLgtWagon1).HasColumnType("datetime");

                entity.Property(e => e.FinDemDernierLgtWagon2).HasColumnType("datetime");

                entity.Property(e => e.HeureArriveeWagon1).HasColumnType("datetime");

                entity.Property(e => e.HeureArriveeWagon2).HasColumnType("datetime");

                entity.Property(e => e.HeureDepartWagon1).HasColumnType("datetime");

                entity.Property(e => e.HeureDepartWagon2).HasColumnType("datetime");

                entity.Property(e => e.HeurePrevuDemoulage).HasColumnType("datetime");

                entity.Property(e => e.Hydrogene).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.NbLingotRestantArefroidir).HasColumnName("NbLingotRestantARefroidir");

                entity.Property(e => e.Nuance)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.Observation2).HasMaxLength(100);

                entity.Property(e => e.OperateurCoulee).HasMaxLength(10);

                entity.Property(e => e.OperateurDegazeur).HasMaxLength(10);

                entity.Property(e => e.OperateurDemoulage).HasMaxLength(10);

                entity.Property(e => e.ProgrammeSmq)
                    .HasColumnName("ProgrammeSMQ")
                    .HasMaxLength(3);

                entity.Property(e => e.ResponsableTraitement).HasMaxLength(30);

                entity.Property(e => e.TypeLingot1)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.TypeLingot2)
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LDDefaut>(entity =>
            {
                entity.ToTable("L_D_DEFAUT");

                entity.HasIndex(e => e.ParamDefautId)
                    .HasName("IX_FK_ParamDefautDefaut");

                entity.HasIndex(e => new { e.NumeroLingot, e.Coulee })
                    .HasName("IX_FK_PSODefaut");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Coulee)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.ParamDefautId).HasColumnName("ParamDefautID");

                entity.HasOne(d => d.LDPso)
                    .WithMany(p => p.LDDefaut)
                    .HasForeignKey(d => new { d.NumeroLingot, d.Coulee })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PSODefaut");
            });

            modelBuilder.Entity<LDEtatLiaison>(entity =>
            {
                entity.ToTable("L_D_ETAT_LIAISON");

                entity.Property(e => e.AdresseIp)
                    .IsRequired()
                    .HasColumnName("AdresseIP")
                    .HasMaxLength(15);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TypeLiaison)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LDEtatStock>(entity =>
            {
                entity.HasKey(e => e.Lieu);

                entity.ToTable("L_D_ETAT_STOCK");

                entity.Property(e => e.Lieu).HasMaxLength(25);

                entity.Property(e => e.Coulee)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.DateDerniereSortie).HasColumnType("datetime");

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.DatePremiereEntree).HasColumnType("datetime");

                entity.Property(e => e.Pso)
                    .IsRequired()
                    .HasColumnName("PSO")
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LDFileQueue>(entity =>
            {
                entity.ToTable("L_D_FILE_QUEUE");

                entity.Property(e => e.CodeEmetteur)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.Ofcount).HasColumnName("OFCount");

                entity.Property(e => e.Oftotal).HasColumnName("OFTotal");

                entity.Property(e => e.PathName).IsRequired();

                entity.Property(e => e.ServeurMac)
                    .IsRequired()
                    .HasColumnName("ServeurMAC");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<LDFonctions>(entity =>
            {
                entity.ToTable("L_D_FONCTIONS");

                entity.Property(e => e.CelluleRecalage).HasMaxLength(10);

                entity.Property(e => e.DateEnvoi)
                    .HasColumnName("Date_Envoi")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fonction)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.NombrePdf).HasColumnName("NombrePDF");

                entity.Property(e => e.NombrePf).HasColumnName("NombrePF");

                entity.Property(e => e.Of)
                    .IsRequired()
                    .HasColumnName("OF")
                    .HasMaxLength(12);

                entity.Property(e => e.Pdf)
                    .HasColumnName("PDF")
                    .HasMaxLength(8);

                entity.Property(e => e.Pf)
                    .HasColumnName("PF")
                    .HasMaxLength(8);

                entity.Property(e => e.RangAcierie).HasMaxLength(2);

                entity.Property(e => e.RangLaminage).HasMaxLength(2);

                entity.Property(e => e.RepereLingot).HasMaxLength(4);
            });

            modelBuilder.Entity<LDFonctionsN2>(entity =>
            {
                entity.ToTable("L_D_FONCTIONS_N2");

                entity.Property(e => e.CelluleRecalage).HasMaxLength(10);

                entity.Property(e => e.DateEnvoi)
                    .HasColumnName("Date_Envoi")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fonction)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.NombrePdf).HasColumnName("NombrePDF");

                entity.Property(e => e.NombrePf).HasColumnName("NombrePF");

                entity.Property(e => e.Of)
                    .IsRequired()
                    .HasColumnName("OF")
                    .HasMaxLength(12);

                entity.Property(e => e.Pdf)
                    .HasColumnName("PDF")
                    .HasMaxLength(8);

                entity.Property(e => e.Pf)
                    .HasColumnName("PF")
                    .HasMaxLength(8);

                entity.Property(e => e.RangAcierie).HasMaxLength(2);

                entity.Property(e => e.RangLaminage).HasMaxLength(2);

                entity.Property(e => e.RepereLingot).HasMaxLength(4);
            });

            modelBuilder.Entity<LDFourAcier>(entity =>
            {
                entity.HasKey(e => e.Coulee);

                entity.ToTable("L_D_FOUR_ACIER");

                entity.Property(e => e.Coulee)
                    .HasColumnName("coulee")
                    .HasMaxLength(6);

                entity.Property(e => e.DateArret)
                    .HasColumnName("date_arret")
                    .HasMaxLength(16);

                entity.Property(e => e.DateMaj)
                    .HasColumnName("date_maj")
                    .HasMaxLength(16);

                entity.Property(e => e.DureeArret)
                    .HasColumnName("duree_arret")
                    .HasMaxLength(4);

                entity.Property(e => e.Energie)
                    .HasColumnName("energie")
                    .HasMaxLength(6);

                entity.Property(e => e.Etat)
                    .HasColumnName("etat")
                    .HasMaxLength(6);

                entity.Property(e => e.Nuance)
                    .HasColumnName("nuance")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<LDFours>(entity =>
            {
                entity.ToTable("L_D_FOURS");

                entity.Property(e => e.Id).HasMaxLength(3);

                entity.Property(e => e.DebutDefournement).HasColumnType("datetime");

                entity.Property(e => e.FinEnfournement).HasColumnType("datetime");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.OfenCours)
                    .HasColumnName("OFEnCours")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.PoidsEnfourne).HasColumnType("decimal(6, 3)");
            });

            modelBuilder.Entity<LDHeurecalcul>(entity =>
            {
                entity.ToTable("L_D_HEURECALCUL");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Hj).HasColumnName("HJ");

                entity.Property(e => e.Hmb).HasColumnName("HMB");

                entity.Property(e => e.Hmm).HasColumnName("HMM");

                entity.Property(e => e.Hmn).HasColumnName("HMN");

                entity.Property(e => e.Ho).HasColumnName("HO");

                entity.Property(e => e.Hta).HasColumnName("HTA");

                entity.Property(e => e.Htc).HasColumnName("HTC");

                entity.Property(e => e.Htd).HasColumnName("HTD");

                entity.Property(e => e.Htg).HasColumnName("HTG");

                entity.Property(e => e.Hth).HasColumnName("HTH");

                entity.Property(e => e.Hti).HasColumnName("HTI");

                entity.Property(e => e.Htm).HasColumnName("HTM");

                entity.Property(e => e.Htp).HasColumnName("HTP");

                entity.Property(e => e.Htq).HasColumnName("HTQ");

                entity.Property(e => e.Htr).HasColumnName("HTR");

                entity.Property(e => e.Htt).HasColumnName("HTT");
            });

            modelBuilder.Entity<LDHistoCages>(entity =>
            {
                entity.ToTable("L_D_HISTO_CAGES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateMiseEnService).HasColumnType("datetime");

                entity.Property(e => e.DateMiseHorsService).HasColumnType("datetime");

                entity.Property(e => e.DateUsinage).HasColumnType("datetime");

                entity.Property(e => e.DiametreInferieur).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.DiametreSuperieur).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.NumCage)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.NumCylInferieur).HasMaxLength(15);

                entity.Property(e => e.NumCylSuperieur).HasMaxLength(15);
            });

            modelBuilder.Entity<LDJalondeproduction>(entity =>
            {
                entity.ToTable("L_D_JALONDEPRODUCTION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HeureDebut).HasColumnType("datetime");

                entity.Property(e => e.LanminageControle).HasMaxLength(3);

                entity.Property(e => e.Montage)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.PoidsUnitaire).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.ProfilActivite).IsRequired();

                entity.Property(e => e.Pso)
                    .HasColumnName("PSO")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Scarfing).HasMaxLength(1);

                entity.Property(e => e.Section).HasColumnType("decimal(4, 1)");
            });

            modelBuilder.Entity<LDJalondeproductionprev>(entity =>
            {
                entity.ToTable("L_D_JALONDEPRODUCTIONPREV");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.LanminageControle).HasMaxLength(3);

                entity.Property(e => e.Montage)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.PoidsUnitaire).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.ProfilActivite).IsRequired();

                entity.Property(e => e.Pso)
                    .HasColumnName("PSO")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Scarfing).HasMaxLength(1);

                entity.Property(e => e.Section).HasColumnType("decimal(4, 1)");
            });

            modelBuilder.Entity<LDKape22>(entity =>
            {
                entity.ToTable("L_D_KAPE22");

                entity.Property(e => e.AcompteSolde)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ClasseDeChute)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Client)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.CodeConsigneChutage).HasMaxLength(12);

                entity.Property(e => e.CodeConsigneDecoupe).HasMaxLength(12);

                entity.Property(e => e.CodeConsigneLingot).HasMaxLength(12);

                entity.Property(e => e.CodeConsignePits).HasMaxLength(12);

                entity.Property(e => e.CodeConsignePoidMetrique).HasMaxLength(12);

                entity.Property(e => e.CodeConsigneRefroidissoir).HasMaxLength(12);

                entity.Property(e => e.CodeConsigneSvt)
                    .HasColumnName("CodeConsigneSVT")
                    .HasMaxLength(12);

                entity.Property(e => e.CodeDemiProduit).HasMaxLength(4);

                entity.Property(e => e.CodeOpeChutage)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CodeOpeDecoupe)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CodeOpeLingot)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CodeOpePits)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CodeOpePoidMetrique)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CodeOpeRefroidissoir)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CodeOpeSvt)
                    .HasColumnName("CodeOpeSVT")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Coulee)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.DateEnfournementFour1).HasColumnType("datetime");

                entity.Property(e => e.DateEnfournementFour2).HasColumnType("datetime");

                entity.Property(e => e.DateReception)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Destination)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.GazScarfing)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.H2coulee).HasColumnName("H2Coulee");

                entity.Property(e => e.LibelleConsigneChutage).HasMaxLength(18);

                entity.Property(e => e.LibelleConsigneDecoupe).HasMaxLength(18);

                entity.Property(e => e.LibelleConsigneLingot).HasMaxLength(18);

                entity.Property(e => e.LibelleConsignePits).HasMaxLength(18);

                entity.Property(e => e.LibelleConsignePoidMetrique).HasMaxLength(18);

                entity.Property(e => e.LibelleConsigneRefroidissoir).HasMaxLength(18);

                entity.Property(e => e.LibelleConsigneSvt)
                    .HasColumnName("LibelleConsigneSVT")
                    .HasMaxLength(18);

                entity.Property(e => e.LongueurCd).HasColumnName("LongueurCD");

                entity.Property(e => e.LongueurScarfingPied)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.LongueurScarfingTete)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.MarqueCommerciale)
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.MiseAuMille)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Nuance)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.NuanceMarquage).HasMaxLength(6);

                entity.Property(e => e.NumeroFichier).IsRequired();

                entity.Property(e => e.NumeroMontage)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Of)
                    .IsRequired()
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Ofdestination)
                    .HasColumnName("OFDestination")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.OfdestinationInterne)
                    .HasColumnName("OFDestinationInterne")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Oforigin)
                    .HasColumnName("OFOrigin")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.OforiginInterne)
                    .HasColumnName("OForiginInterne")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.OutilDecoupe).HasMaxLength(1);

                entity.Property(e => e.OxygeneInferieur)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.OxygeneLatent)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.OxygeneSuperieur)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ProfilProduit)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ProfileLamine)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.RangOpeChutage)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RangOpeDecoupe)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RangOpeLingot)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RangOpePits)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RangOpePoidMetrique)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RangOpeRefroidissoir)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RangOpeSvt)
                    .HasColumnName("RangOpeSVT")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RefroidissementBloom)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.VitesseV1)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.VitesseV2)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.VitesseV3)
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LDKeycompteur>(entity =>
            {
                entity.ToTable("L_D_KEYCOMPTEUR");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Value).HasColumnName("VALUE");
            });

            modelBuilder.Entity<LDKla1>(entity =>
            {
                entity.ToTable("L_D_KLA1");

                entity.Property(e => e.Client)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CodeDemiProduit)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.DateReception).HasColumnType("datetime");

                entity.Property(e => e.Nuance)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.Observations)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Of)
                    .IsRequired()
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Pofil)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Verif)
                    .IsRequired()
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<LDLogCommande>(entity =>
            {
                entity.ToTable("L_D_LOG_COMMANDE");

                entity.Property(e => e.Commande).IsRequired();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.Of)
                    .IsRequired()
                    .HasColumnName("OF")
                    .HasMaxLength(12);

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LDMajDateChecker>(entity =>
            {
                entity.HasKey(e => e.Table);

                entity.ToTable("L_D_MAJ_DATE_CHECKER");

                entity.Property(e => e.Table).HasMaxLength(25);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");
            });

            modelBuilder.Entity<LDMajPoste>(entity =>
            {
                entity.ToTable("L_D_MAJ_POSTE");

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<LDMamQual>(entity =>
            {
                entity.HasKey(e => e.Of);

                entity.ToTable("L_D_MAM_QUAL");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12);

                entity.Property(e => e.CodePesee)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ConsigneScarfing)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.DateIpl)
                    .HasColumnName("DateIPL")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEquipe).HasMaxLength(25);

                entity.Property(e => e.LgDeveloppee).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Mmgof).HasColumnName("MMGOF");

                entity.Property(e => e.Mmtrof).HasColumnName("MMTROF");

                entity.Property(e => e.Mmttof).HasColumnName("MMTTOF");

                entity.Property(e => e.NbBarresEvc).HasColumnName("NbBarresEVC");

                entity.Property(e => e.NumeroMontage)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LDMessageProduction>(entity =>
            {
                entity.ToTable("L_D_MESSAGE_PRODUCTION");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.NomTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NomUtilisateur)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<LDMesure>(entity =>
            {
                entity.ToTable("L_D_MESURE");

                entity.Property(e => e.CompteurDd10).HasColumnName("CompteurDD10");

                entity.Property(e => e.CompteurDd11a).HasColumnName("CompteurDD11A");

                entity.Property(e => e.CompteurDd11b).HasColumnName("CompteurDD11B");

                entity.Property(e => e.CompteurDd12).HasColumnName("CompteurDD12");

                entity.Property(e => e.CompteurDd12b).HasColumnName("CompteurDD12B");

                entity.Property(e => e.CompteurDd13).HasColumnName("CompteurDD13");

                entity.Property(e => e.CompteurDd14).HasColumnName("CompteurDD14");

                entity.Property(e => e.CompteurDd15).HasColumnName("CompteurDD15");

                entity.Property(e => e.CompteurDd8).HasColumnName("CompteurDD8");

                entity.Property(e => e.CompteurDd9).HasColumnName("CompteurDD9");

                entity.Property(e => e.CompteurDd9b).HasColumnName("CompteurDD9B");

                entity.Property(e => e.CompteurDe1).HasColumnName("CompteurDE1");

                entity.Property(e => e.CompteurDe2a).HasColumnName("CompteurDE2A");

                entity.Property(e => e.CompteurDe2b).HasColumnName("CompteurDE2B");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12);

                entity.Property(e => e.Pdf)
                    .HasColumnName("PDF")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<LDMouvementStock>(entity =>
            {
                entity.ToTable("L_D_MOUVEMENT_STOCK");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Consigne).HasMaxLength(12);

                entity.Property(e => e.Coulee)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.DateDemande).HasColumnType("datetime");

                entity.Property(e => e.DateDisponibilite).HasColumnType("datetime");

                entity.Property(e => e.DateMouvement).HasColumnType("datetime");

                entity.Property(e => e.DatePrevue).HasColumnType("datetime");

                entity.Property(e => e.Etat).HasDefaultValueSql("((1))");

                entity.Property(e => e.LieuParc).HasMaxLength(25);

                entity.Property(e => e.LieuPits).HasMaxLength(25);

                entity.Property(e => e.Observations).HasMaxLength(250);

                entity.Property(e => e.Pso)
                    .IsRequired()
                    .HasColumnName("PSO")
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LDOfSuivi>(entity =>
            {
                entity.HasKey(e => e.Of);

                entity.ToTable("L_D_OF_SUIVI");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.HasOne(d => d.OfNavigation)
                    .WithOne(p => p.LDOfSuivi)
                    .HasForeignKey<LDOfSuivi>(d => d.Of)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SuiviDeOFOrdreFabrication");
            });

            modelBuilder.Entity<LDOrdreFabrication>(entity =>
            {
                entity.HasKey(e => e.Of);

                entity.ToTable("L_D_ORDRE_FABRICATION");

                entity.HasIndex(e => e.Coulee)
                    .HasName("IX_FK_CouleeOrdreFabrication");

                entity.HasIndex(e => e.ProfilProduit)
                    .HasName("IX_FK_OrdreFabricationProfilProduit");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.AcompteSolde)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ClasseDeChute)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Client)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.CodeDemiProduit)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Coulee)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.DateDebut).HasColumnType("datetime");

                entity.Property(e => e.DateDebutLaminage).HasColumnType("datetime");

                entity.Property(e => e.DateEvc)
                    .HasColumnName("DateEVC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateFin).HasColumnType("datetime");

                entity.Property(e => e.DateFinLaminage).HasColumnType("datetime");

                entity.Property(e => e.DateMaj)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateReception)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiametreProduit).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.Epaisseur).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.LongueurCd)
                    .HasColumnName("LongueurCD")
                    .HasColumnType("decimal(5, 3)");

                entity.Property(e => e.MarqueCommerciale)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.Nuance)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.NumeroFichier)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.NumeroMontage)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Oforigine)
                    .HasColumnName("OFOrigine")
                    .HasMaxLength(12);

                entity.Property(e => e.PoidsDemiProduitUnitaire).HasColumnType("decimal(7, 3)");

                entity.Property(e => e.PoidsPrevuDemiProduit).HasColumnType("decimal(6, 3)");

                entity.Property(e => e.ProfilProduit)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SensLaminage)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.SensLaminageGpao)
                    .HasColumnName("SensLaminageGPAO")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.SuiviDeZoneZone).HasMaxLength(50);

                entity.Property(e => e.ToleranceMaxEpaisseur).HasColumnType("decimal(2, 1)");

                entity.Property(e => e.ToleranceMaxLongueur).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.ToleranceMaxSection).HasColumnType("decimal(2, 1)");

                entity.Property(e => e.ToleranceMinEpaisseur).HasColumnType("decimal(2, 1)");

                entity.Property(e => e.ToleranceMinLongueur).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.ToleranceMinSection).HasColumnType("decimal(2, 1)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

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

                entity.ToTable("L_D_OUTILS_VOR");

                entity.Property(e => e.Zone).HasMaxLength(50);

                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.Commentaires).IsRequired();

                entity.Property(e => e.DateEnvoi)
                    .HasColumnName("Date_Envoi")
                    .HasColumnType("datetime");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Vor).HasColumnName("VOR");
            });

            modelBuilder.Entity<LDPanne>(entity =>
            {
                entity.ToTable("L_D_PANNE");

                entity.Property(e => e.CodeArretReference)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.DateDebut).HasColumnType("datetime");

                entity.Property(e => e.DateFin).HasColumnType("datetime");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.OtCode).HasMaxLength(25);
            });

            modelBuilder.Entity<LDPesage>(entity =>
            {
                entity.ToTable("L_D_PESAGE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Lieu).HasMaxLength(15);

                entity.Property(e => e.Of)
                    .IsRequired()
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LDPlansFours>(entity =>
            {
                entity.HasKey(e => new { e.FourId, e.Position });

                entity.ToTable("L_D_PLANS_FOURS");

                entity.HasIndex(e => e.IdCoulee)
                    .HasName("IX_FK_PlanFourCoulee");

                entity.HasIndex(e => e.Of)
                    .HasName("IX_FK_PlanFourOrdreFabrication");

                entity.HasIndex(e => new { e.NumeroLingot, e.IdCoulee })
                    .HasName("IX_FK_PlanFourPSO");

                entity.Property(e => e.FourId).HasMaxLength(3);

                entity.Property(e => e.IdCoulee)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

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

                entity.ToTable("L_D_PRODUITS_OUTIL");

                entity.Property(e => e.Zone).HasMaxLength(10);

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12);

                entity.Property(e => e.Commentaire).HasMaxLength(250);

                entity.Property(e => e.HeureArrivee).HasColumnType("datetime");

                entity.Property(e => e.HeureSortie).HasColumnType("datetime");

                entity.Property(e => e.Ligne).HasMaxLength(3);
            });

            modelBuilder.Entity<LDPso>(entity =>
            {
                entity.HasKey(e => new { e.NumeroLingot, e.Coulee });

                entity.ToTable("L_D_PSO");

                entity.HasIndex(e => e.Coulee)
                    .HasName("IX_FK_PSOCoulee");

                entity.HasIndex(e => e.Of)
                    .HasName("IX_FK_OrdreFabricationPSO");

                entity.Property(e => e.Coulee)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Action).HasMaxLength(8);

                entity.Property(e => e.Arefroidir).HasColumnName("ARefroidir");

                entity.Property(e => e.ConsigneScarfing)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.CoteBloomingCommentaire).HasMaxLength(250);

                entity.Property(e => e.CoteBloomingHauteur).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.CoteBloomingLargeur).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.CoteCage900Commentaire).HasMaxLength(250);

                entity.Property(e => e.CoteCage900Epaulement1).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.CoteCage900Epaulement2).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.CoteCage900Hauteur).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.CoteCage900Largeur).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.DateDefournement).HasColumnType("datetime");

                entity.Property(e => e.DateEnfournement).HasColumnType("datetime");

                entity.Property(e => e.DateRefroidissement).HasColumnType("datetime");

                entity.Property(e => e.Densite).HasColumnType("decimal(5, 3)");

                entity.Property(e => e.Externe)
                    .IsRequired()
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.LgDeveloppee).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.PoidsChutePied).HasColumnType("decimal(7, 3)");

                entity.Property(e => e.PoidsChuteTete).HasColumnType("decimal(7, 3)");

                entity.Property(e => e.PoidsEboutagePied).HasColumnType("decimal(7, 3)");

                entity.Property(e => e.PoidsEboutageTete).HasColumnType("decimal(7, 3)");

                entity.Property(e => e.Reperage).HasMaxLength(8);

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

                entity.ToTable("L_D_PSO_COMPLEMENT");

                entity.Property(e => e.Coulee)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.DateLg1500T).HasColumnType("datetime");

                entity.Property(e => e.DateLgCage900).HasColumnType("datetime");

                entity.Property(e => e.DateMajPso)
                    .HasColumnName("DateMajPSO")
                    .HasColumnType("datetime");

                entity.Property(e => e.LgTheorique1500T).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LgTheoriqueCage900).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.TypePso)
                    .HasColumnName("TypePSO")
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LDRebut>(entity =>
            {
                entity.HasKey(e => new { e.RangLingotPassageAuLaminoir, e.Of, e.DateRebut });

                entity.ToTable("L_D_REBUT");

                entity.HasIndex(e => e.Of)
                    .HasName("IX_FK_RebutOrdreFabrication");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.DateRebut).HasColumnType("datetime");

                entity.Property(e => e.Cage).HasMaxLength(10);

                entity.Property(e => e.CodeRebut).IsRequired();

                entity.Property(e => e.Commentaire)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.IdEquipe).HasMaxLength(25);

                entity.Property(e => e.Monture)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Pdf)
                    .HasColumnName("PDF")
                    .HasMaxLength(10);

                entity.HasOne(d => d.OfNavigation)
                    .WithMany(p => p.LDRebut)
                    .HasForeignKey(d => d.Of)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RebutOrdreFabrication");
            });

            modelBuilder.Entity<LDReleveTemperature>(entity =>
            {
                entity.ToTable("L_D_RELEVE_TEMPERATURE");

                entity.HasIndex(e => e.AdressesTemperatureId)
                    .HasName("IX_FK_AdressesTemperatureReleveTemperature");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdressesTemperatureId).HasColumnName("AdressesTemperatureID");

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.HasOne(d => d.AdressesTemperature)
                    .WithMany(p => p.LDReleveTemperature)
                    .HasForeignKey(d => d.AdressesTemperatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdressesTemperatureReleveTemperature");
            });

            modelBuilder.Entity<LDRoles>(entity =>
            {
                entity.HasKey(e => new { e.Utilisateur, e.TransactionCode });

                entity.ToTable("L_D_ROLES");

                entity.HasIndex(e => e.TransactionCode)
                    .HasName("IX_FK_TransactionUtilisateurs");

                entity.Property(e => e.Utilisateur).HasMaxLength(30);

                entity.Property(e => e.TransactionCode).HasMaxLength(8);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.HasOne(d => d.TransactionCodeNavigation)
                    .WithMany(p => p.LDRoles)
                    .HasForeignKey(d => d.TransactionCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionUtilisateurs");
            });

            modelBuilder.Entity<LDRolesTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("L_D_ROLES_TMP");

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.TransactionCode)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Utilisateur)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<LDRouleaux>(entity =>
            {
                entity.ToTable("L_D_ROULEAUX");

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.NomTable).HasMaxLength(50);
            });

            modelBuilder.Entity<LDSectionchargeChutage>(entity =>
            {
                entity.HasKey(e => new { e.Of, e.CodeOperation });

                entity.ToTable("L_D_SECTIONCHARGE_CHUTAGE");

                entity.HasIndex(e => e.CodeOperation)
                    .HasName("IX_FK_SectionChargeChutageSuiviConsigneLaminage");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.CodeOperation)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ChutagePied).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.ChutageTete).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.Destination)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.RangOperation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

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

                entity.ToTable("L_D_SECTIONCHARGE_DECOUPE");

                entity.HasIndex(e => e.CodeOperation)
                    .HasName("IX_FK_SectionChargeDecoupeSuiviConsigneLaminage");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.CodeOperation)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.LongueurMoyenne).HasColumnType("decimal(5, 3)");

                entity.Property(e => e.OutilDeDecoupe)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.RangOperation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

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

                entity.ToTable("L_D_SECTIONCHARGE_LINGOT");

                entity.HasIndex(e => e.CodeOperation)
                    .HasName("IX_FK_SectionChargeLingoSuiviConsigneLaminage");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.CodeOperation)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.EpaisseurEnLaminage).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.PriseDeFerEpaisseur).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.PriseDeFerEpaisseurGpao)
                    .HasColumnName("PriseDeFerEpaisseurGPAO")
                    .HasColumnType("decimal(4, 1)");

                entity.Property(e => e.PriseDeFerHauteur).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.PriseDeFerHauteurGpao)
                    .HasColumnName("PriseDeFerHauteurGPAO")
                    .HasColumnType("decimal(4, 1)");

                entity.Property(e => e.PriseDeFerSectionGpao).HasColumnName("PriseDeFerSectionGPAO");

                entity.Property(e => e.ProfileLamine)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ProgrammeGpao).HasColumnName("ProgrammeGPAO");

                entity.Property(e => e.RangOperation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SectionLaminage).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.ToleranceMaxEpaisseur).HasColumnType("decimal(2, 1)");

                entity.Property(e => e.ToleranceMaxSection).HasColumnType("decimal(2, 1)");

                entity.Property(e => e.ToleranceMinEpaisseur).HasColumnType("decimal(2, 1)");

                entity.Property(e => e.ToleranceMinSection).HasColumnType("decimal(2, 1)");

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

                entity.ToTable("L_D_SECTIONCHARGE_PITS");

                entity.HasIndex(e => e.CodeOperation)
                    .HasName("IX_FK_SectionChargeEnfournementPitsSuiviConsigneLaminage");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.CodeOperation)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.DateDefournementFour1).HasColumnType("datetime");

                entity.Property(e => e.DateDefournementFour2).HasColumnType("datetime");

                entity.Property(e => e.DateEnfournementFour1).HasColumnType("datetime");

                entity.Property(e => e.DateEnfournementFour2).HasColumnType("datetime");

                entity.Property(e => e.H2coulee)
                    .HasColumnName("H2Coulee")
                    .HasColumnType("decimal(2, 1)");

                entity.Property(e => e.RangOperation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

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

                entity.ToTable("L_D_SECTIONCHARGE_POIDSMETRIQUE");

                entity.HasIndex(e => e.CodeOperation)
                    .HasName("IX_FK_SectionChargePoidsMetriqueSuiviConsigneLaminage");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.CodeOperation)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RangOperation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

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

                entity.ToTable("L_D_SECTIONCHARGE_REFROIDISSOIRS");

                entity.HasIndex(e => e.CodeOperation)
                    .HasName("IX_FK_SectionChargeRefroidissoirSuiviConsigneLaminage");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.CodeOperation)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.GazScarfing)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.LongueurScarfingPied)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.LongueurScarfingTete)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.MiseAuMille)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.NuanceMarquage).HasMaxLength(6);

                entity.Property(e => e.Ofdestination)
                    .HasColumnName("OFDestination")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Ofinterne)
                    .HasColumnName("OFInterne")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Oforigin)
                    .HasColumnName("OFOrigin")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.OxygeneInferieur)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.OxygeneLatent)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.OxygeneSuperieur)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RangOperation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RefroidissementBloom)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.VitesseV1)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.VitesseV2)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.VitesseV3)
                    .HasMaxLength(4)
                    .IsFixedLength();

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

                entity.ToTable("L_D_SECTIONCHARGE_SVT");

                entity.HasIndex(e => e.CodeOperation)
                    .HasName("IX_FK_SuiviConsigneLaminageConsignesSVT");

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.CodeOperation)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RangOperation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

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

                entity.ToTable("L_D_SOUS_PRODUITS");

                entity.Property(e => e.Coulee)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.NumProduit)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LgCage900).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.LgDeveloppe).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Longueur).HasColumnType("decimal(5, 3)");

                entity.Property(e => e.Parent).HasMaxLength(8);

                entity.Property(e => e.PoidsEboutagePied).HasColumnType("decimal(7, 3)");

                entity.Property(e => e.PoidsEboutageTete).HasColumnType("decimal(7, 3)");

                entity.Property(e => e.ProduitFini)
                    .IsRequired()
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.ProfilProduit)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("('BIL')");

                entity.HasOne(d => d.LDPso)
                    .WithMany(p => p.LDSousProduits)
                    .HasForeignKey(d => new { d.NumeroLingot, d.Coulee })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SousProduitPSO");
            });

            modelBuilder.Entity<LDStockPso>(entity =>
            {
                entity.HasKey(e => new { e.IdCoulee, e.NumeroLingot, e.Id });

                entity.ToTable("L_D_STOCK_PSO");

                entity.Property(e => e.IdCoulee)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateEntree).HasColumnType("datetime");

                entity.Property(e => e.DateSortie).HasColumnType("datetime");

                entity.Property(e => e.DateStockageTemporaire).HasColumnType("datetime");

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

            modelBuilder.Entity<LDTraceArchivage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("L_D_TRACE_ARCHIVAGE");

                entity.Property(e => e.DateTrace)
                    .HasColumnName("Date_trace")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .IsFixedLength();

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LDVersion>(entity =>
            {
                entity.HasKey(e => e.Numero);

                entity.ToTable("L_D_VERSION");

                entity.Property(e => e.Numero).HasMaxLength(8);

                entity.Property(e => e.DateMaj)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Libelle).IsRequired();
            });

            modelBuilder.Entity<LDWatchdog>(entity =>
            {
                entity.HasKey(e => e.Niveau);

                entity.ToTable("L_D_WATCHDOG");

                entity.Property(e => e.Niveau).HasMaxLength(15);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");
            });

            modelBuilder.Entity<LDZone>(entity =>
            {
                entity.HasKey(e => e.Zone);

                entity.ToTable("L_D_ZONE");

                entity.Property(e => e.Zone).HasMaxLength(10);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NombrePdf).HasColumnName("NombrePDF");

                entity.Property(e => e.NombrePf).HasColumnName("NombrePF");

                entity.Property(e => e.NumLingotAcierie).HasMaxLength(2);

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12);

                entity.Property(e => e.Pdf)
                    .HasColumnName("PDF")
                    .HasMaxLength(10);

                entity.Property(e => e.Pf)
                    .HasColumnName("PF")
                    .HasMaxLength(8);

                entity.Property(e => e.RangLaminage).HasMaxLength(2);

                entity.Property(e => e.RepereLingot).HasMaxLength(4);

                entity.Property(e => e.VorO).HasColumnName("VOR_O");

                entity.Property(e => e.VorR).HasColumnName("VOR_R");

                entity.Property(e => e.VorV).HasColumnName("VOR_V");
            });

            modelBuilder.Entity<LDZoneSuivi>(entity =>
            {
                entity.ToTable("L_D_ZONE_SUIVI");

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.NombrePdf).HasColumnName("NombrePDF");

                entity.Property(e => e.NombrePf).HasColumnName("NombrePF");

                entity.Property(e => e.NumLingotAcierie).HasMaxLength(2);

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12);

                entity.Property(e => e.Pdf)
                    .HasColumnName("PDF")
                    .HasMaxLength(10);

                entity.Property(e => e.Pf)
                    .HasColumnName("PF")
                    .HasMaxLength(8);

                entity.Property(e => e.RangLaminage).HasMaxLength(2);

                entity.Property(e => e.RepereLingot).HasMaxLength(3);

                entity.Property(e => e.VorO).HasColumnName("VOR_O");

                entity.Property(e => e.VorR).HasColumnName("VOR_R");

                entity.Property(e => e.VorV).HasColumnName("VOR_V");

                entity.Property(e => e.Zone)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<LPAdressesTemperature>(entity =>
            {
                entity.ToTable("L_P_ADRESSES_TEMPERATURE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdresseIp)
                    .IsRequired()
                    .HasColumnName("AdresseIP")
                    .HasMaxLength(15);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Modbus)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Outil).HasMaxLength(25);
            });

            modelBuilder.Entity<LPAnomalies>(entity =>
            {
                entity.ToTable("L_P_ANOMALIES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LPArret>(entity =>
            {
                entity.HasKey(e => e.IdArret);

                entity.ToTable("L_P_ARRET");

                entity.Property(e => e.Affectation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Categorie)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.DateMaj)
                    .HasColumnName("DateMAJ")
                    .HasColumnType("datetime");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<LPBloomingProg>(entity =>
            {
                entity.HasKey(e => e.IdBloPprog);

                entity.ToTable("L_P_BLOOMING_PROG");

                entity.Property(e => e.IdBloPprog).HasColumnName("IdBloPProg");

                entity.Property(e => e.BloPcannelure1)
                    .HasColumnName("BloPCannelure1")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure10)
                    .HasColumnName("BloPCannelure10")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure11)
                    .HasColumnName("BloPCannelure11")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure12)
                    .HasColumnName("BloPCannelure12")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure13)
                    .HasColumnName("BloPCannelure13")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure14)
                    .HasColumnName("BloPCannelure14")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure15)
                    .HasColumnName("BloPCannelure15")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure16)
                    .HasColumnName("BloPCannelure16")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure17)
                    .HasColumnName("BloPCannelure17")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure18)
                    .HasColumnName("BloPCannelure18")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure19)
                    .HasColumnName("BloPCannelure19")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure2)
                    .HasColumnName("BloPCannelure2")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure20)
                    .HasColumnName("BloPCannelure20")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure21)
                    .HasColumnName("BloPCannelure21")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure22)
                    .HasColumnName("BloPCannelure22")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure23)
                    .HasColumnName("BloPCannelure23")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure24)
                    .HasColumnName("BloPCannelure24")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure25)
                    .HasColumnName("BloPCannelure25")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure26)
                    .HasColumnName("BloPCannelure26")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure27)
                    .HasColumnName("BloPCannelure27")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure28)
                    .HasColumnName("BloPCannelure28")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure29)
                    .HasColumnName("BloPCannelure29")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure3)
                    .HasColumnName("BloPCannelure3")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure30)
                    .HasColumnName("BloPCannelure30")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure31)
                    .HasColumnName("BloPCannelure31")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure32)
                    .HasColumnName("BloPCannelure32")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure33)
                    .HasColumnName("BloPCannelure33")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure34)
                    .HasColumnName("BloPCannelure34")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure35)
                    .HasColumnName("BloPCannelure35")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure36)
                    .HasColumnName("BloPCannelure36")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure37)
                    .HasColumnName("BloPCannelure37")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure38)
                    .HasColumnName("BloPCannelure38")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure39)
                    .HasColumnName("BloPCannelure39")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure4)
                    .HasColumnName("BloPCannelure4")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure40)
                    .HasColumnName("BloPCannelure40")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure41)
                    .HasColumnName("BloPCannelure41")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure42)
                    .HasColumnName("BloPCannelure42")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure43)
                    .HasColumnName("BloPCannelure43")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure44)
                    .HasColumnName("BloPCannelure44")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure45)
                    .HasColumnName("BloPCannelure45")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure46)
                    .HasColumnName("BloPCannelure46")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure47)
                    .HasColumnName("BloPCannelure47")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure48)
                    .HasColumnName("BloPCannelure48")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure49)
                    .HasColumnName("BloPCannelure49")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure5)
                    .HasColumnName("BloPCannelure5")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure50)
                    .HasColumnName("BloPCannelure50")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure6)
                    .HasColumnName("BloPCannelure6")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure7)
                    .HasColumnName("BloPCannelure7")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure8)
                    .HasColumnName("BloPCannelure8")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPcannelure9)
                    .HasColumnName("BloPCannelure9")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloPdateCre)
                    .HasColumnName("BloPDateCre")
                    .HasColumnType("datetime");

                entity.Property(e => e.BloPdateMdf)
                    .HasColumnName("BloPDateMdf")
                    .HasColumnType("datetime");

                entity.Property(e => e.BloPlargeur).HasColumnName("BloPLargeur");

                entity.Property(e => e.BloPmontage)
                    .IsRequired()
                    .HasColumnName("BloPMontage")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BloPnbPasse).HasColumnName("BloPNbPasse");

                entity.Property(e => e.BloPpasse1).HasColumnName("BloPPasse1");

                entity.Property(e => e.BloPpasse10).HasColumnName("BloPPasse10");

                entity.Property(e => e.BloPpasse11).HasColumnName("BloPPasse11");

                entity.Property(e => e.BloPpasse12).HasColumnName("BloPPasse12");

                entity.Property(e => e.BloPpasse13).HasColumnName("BloPPasse13");

                entity.Property(e => e.BloPpasse14).HasColumnName("BloPPasse14");

                entity.Property(e => e.BloPpasse15).HasColumnName("BloPPasse15");

                entity.Property(e => e.BloPpasse16).HasColumnName("BloPPasse16");

                entity.Property(e => e.BloPpasse17).HasColumnName("BloPPasse17");

                entity.Property(e => e.BloPpasse18).HasColumnName("BloPPasse18");

                entity.Property(e => e.BloPpasse19).HasColumnName("BloPPasse19");

                entity.Property(e => e.BloPpasse2).HasColumnName("BloPPasse2");

                entity.Property(e => e.BloPpasse20).HasColumnName("BloPPasse20");

                entity.Property(e => e.BloPpasse21).HasColumnName("BloPPasse21");

                entity.Property(e => e.BloPpasse22).HasColumnName("BloPPasse22");

                entity.Property(e => e.BloPpasse23).HasColumnName("BloPPasse23");

                entity.Property(e => e.BloPpasse24).HasColumnName("BloPPasse24");

                entity.Property(e => e.BloPpasse25).HasColumnName("BloPPasse25");

                entity.Property(e => e.BloPpasse26).HasColumnName("BloPPasse26");

                entity.Property(e => e.BloPpasse27).HasColumnName("BloPPasse27");

                entity.Property(e => e.BloPpasse28).HasColumnName("BloPPasse28");

                entity.Property(e => e.BloPpasse29).HasColumnName("BloPPasse29");

                entity.Property(e => e.BloPpasse3).HasColumnName("BloPPasse3");

                entity.Property(e => e.BloPpasse30).HasColumnName("BloPPasse30");

                entity.Property(e => e.BloPpasse31).HasColumnName("BloPPasse31");

                entity.Property(e => e.BloPpasse32).HasColumnName("BloPPasse32");

                entity.Property(e => e.BloPpasse33).HasColumnName("BloPPasse33");

                entity.Property(e => e.BloPpasse34).HasColumnName("BloPPasse34");

                entity.Property(e => e.BloPpasse35).HasColumnName("BloPPasse35");

                entity.Property(e => e.BloPpasse36).HasColumnName("BloPPasse36");

                entity.Property(e => e.BloPpasse37).HasColumnName("BloPPasse37");

                entity.Property(e => e.BloPpasse38).HasColumnName("BloPPasse38");

                entity.Property(e => e.BloPpasse39).HasColumnName("BloPPasse39");

                entity.Property(e => e.BloPpasse4).HasColumnName("BloPPasse4");

                entity.Property(e => e.BloPpasse40).HasColumnName("BloPPasse40");

                entity.Property(e => e.BloPpasse41).HasColumnName("BloPPasse41");

                entity.Property(e => e.BloPpasse42).HasColumnName("BloPPasse42");

                entity.Property(e => e.BloPpasse43).HasColumnName("BloPPasse43");

                entity.Property(e => e.BloPpasse44).HasColumnName("BloPPasse44");

                entity.Property(e => e.BloPpasse45).HasColumnName("BloPPasse45");

                entity.Property(e => e.BloPpasse46).HasColumnName("BloPPasse46");

                entity.Property(e => e.BloPpasse47).HasColumnName("BloPPasse47");

                entity.Property(e => e.BloPpasse48).HasColumnName("BloPPasse48");

                entity.Property(e => e.BloPpasse49).HasColumnName("BloPPasse49");

                entity.Property(e => e.BloPpasse5).HasColumnName("BloPPasse5");

                entity.Property(e => e.BloPpasse50).HasColumnName("BloPPasse50");

                entity.Property(e => e.BloPpasse6).HasColumnName("BloPPasse6");

                entity.Property(e => e.BloPpasse7).HasColumnName("BloPPasse7");

                entity.Property(e => e.BloPpasse8).HasColumnName("BloPPasse8");

                entity.Property(e => e.BloPpasse9).HasColumnName("BloPPasse9");

                entity.Property(e => e.BloPprog).HasColumnName("BloPProg");

                entity.Property(e => e.BloPsection).HasColumnName("BloPSection");
            });

            modelBuilder.Entity<LPBloomingProgTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("L_P_BLOOMING_PROG_TMP");

                entity.Property(e => e.BloPmontage)
                    .IsRequired()
                    .HasColumnName("BloPMontage")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BloPnbPasse).HasColumnName("BloPNbPasse");

                entity.Property(e => e.BloPpasse1).HasColumnName("BloPPasse1");

                entity.Property(e => e.BloPpasse10).HasColumnName("BloPPasse10");

                entity.Property(e => e.BloPpasse11).HasColumnName("BloPPasse11");

                entity.Property(e => e.BloPpasse12).HasColumnName("BloPPasse12");

                entity.Property(e => e.BloPpasse13).HasColumnName("BloPPasse13");

                entity.Property(e => e.BloPpasse14).HasColumnName("BloPPasse14");

                entity.Property(e => e.BloPpasse15).HasColumnName("BloPPasse15");

                entity.Property(e => e.BloPpasse16).HasColumnName("BloPPasse16");

                entity.Property(e => e.BloPpasse17).HasColumnName("BloPPasse17");

                entity.Property(e => e.BloPpasse18).HasColumnName("BloPPasse18");

                entity.Property(e => e.BloPpasse19).HasColumnName("BloPPasse19");

                entity.Property(e => e.BloPpasse2).HasColumnName("BloPPasse2");

                entity.Property(e => e.BloPpasse20).HasColumnName("BloPPasse20");

                entity.Property(e => e.BloPpasse21).HasColumnName("BloPPasse21");

                entity.Property(e => e.BloPpasse22).HasColumnName("BloPPasse22");

                entity.Property(e => e.BloPpasse23).HasColumnName("BloPPasse23");

                entity.Property(e => e.BloPpasse24).HasColumnName("BloPPasse24");

                entity.Property(e => e.BloPpasse25).HasColumnName("BloPPasse25");

                entity.Property(e => e.BloPpasse26).HasColumnName("BloPPasse26");

                entity.Property(e => e.BloPpasse27).HasColumnName("BloPPasse27");

                entity.Property(e => e.BloPpasse28).HasColumnName("BloPPasse28");

                entity.Property(e => e.BloPpasse29).HasColumnName("BloPPasse29");

                entity.Property(e => e.BloPpasse3).HasColumnName("BloPPasse3");

                entity.Property(e => e.BloPpasse30).HasColumnName("BloPPasse30");

                entity.Property(e => e.BloPpasse31).HasColumnName("BloPPasse31");

                entity.Property(e => e.BloPpasse32).HasColumnName("BloPPasse32");

                entity.Property(e => e.BloPpasse33).HasColumnName("BloPPasse33");

                entity.Property(e => e.BloPpasse34).HasColumnName("BloPPasse34");

                entity.Property(e => e.BloPpasse35).HasColumnName("BloPPasse35");

                entity.Property(e => e.BloPpasse36).HasColumnName("BloPPasse36");

                entity.Property(e => e.BloPpasse37).HasColumnName("BloPPasse37");

                entity.Property(e => e.BloPpasse38).HasColumnName("BloPPasse38");

                entity.Property(e => e.BloPpasse39).HasColumnName("BloPPasse39");

                entity.Property(e => e.BloPpasse4).HasColumnName("BloPPasse4");

                entity.Property(e => e.BloPpasse40).HasColumnName("BloPPasse40");

                entity.Property(e => e.BloPpasse41).HasColumnName("BloPPasse41");

                entity.Property(e => e.BloPpasse42).HasColumnName("BloPPasse42");

                entity.Property(e => e.BloPpasse43).HasColumnName("BloPPasse43");

                entity.Property(e => e.BloPpasse44).HasColumnName("BloPPasse44");

                entity.Property(e => e.BloPpasse45).HasColumnName("BloPPasse45");

                entity.Property(e => e.BloPpasse46).HasColumnName("BloPPasse46");

                entity.Property(e => e.BloPpasse47).HasColumnName("BloPPasse47");

                entity.Property(e => e.BloPpasse48).HasColumnName("BloPPasse48");

                entity.Property(e => e.BloPpasse49).HasColumnName("BloPPasse49");

                entity.Property(e => e.BloPpasse5).HasColumnName("BloPPasse5");

                entity.Property(e => e.BloPpasse50).HasColumnName("BloPPasse50");

                entity.Property(e => e.BloPpasse6).HasColumnName("BloPPasse6");

                entity.Property(e => e.BloPpasse7).HasColumnName("BloPPasse7");

                entity.Property(e => e.BloPpasse8).HasColumnName("BloPPasse8");

                entity.Property(e => e.BloPpasse9).HasColumnName("BloPPasse9");

                entity.Property(e => e.BloPprog).HasColumnName("BloPProg");
            });

            modelBuilder.Entity<LPCellulesMesureLongueur>(entity =>
            {
                entity.HasKey(e => e.Cellule);

                entity.ToTable("L_P_CELLULES_MESURE_LONGUEUR");

                entity.Property(e => e.Cellule).HasMaxLength(5);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Longueur).HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<LPCodeoutilDecoupe>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("L_P_CODEOUTIL_DECOUPE");

                entity.Property(e => e.Code).HasMaxLength(1);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle).HasMaxLength(50);
            });

            modelBuilder.Entity<LPCoeffdilatation>(entity =>
            {
                entity.HasKey(e => e.Temperature);

                entity.ToTable("L_P_COEFFDILATATION");

                entity.Property(e => e.Temperature).ValueGeneratedNever();

                entity.Property(e => e.DateMaj).HasColumnType("datetime");
            });

            modelBuilder.Entity<LPConsignesChutage>(entity =>
            {
                entity.HasKey(e => new { e.CodeConsigne, e.Section, e.Consignes });

                entity.ToTable("L_P_CONSIGNES_CHUTAGE");

                entity.HasIndex(e => e.Consignes)
                    .HasName("IX_FK_TypeConsignesParamConsignesChutage");

                entity.Property(e => e.CodeConsigne).HasMaxLength(12);

                entity.Property(e => e.Section).HasMaxLength(4);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle).IsRequired();

                entity.HasOne(d => d.ConsignesNavigation)
                    .WithMany(p => p.LPConsignesChutage)
                    .HasForeignKey(d => d.Consignes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeConsignesParamConsignesChutage");
            });

            modelBuilder.Entity<LPConsignesCodeoutilCoupe>(entity =>
            {
                entity.HasKey(e => new { e.Section, e.Consignes, e.CodeConsigne });

                entity.ToTable("L_P_CONSIGNES_CODEOUTIL_COUPE");

                entity.HasIndex(e => e.Consignes)
                    .HasName("IX_FK_ParamConsignesCodeOutilCoupeTypeConsignes");

                entity.Property(e => e.Section).HasMaxLength(4);

                entity.Property(e => e.CodeConsigne).HasMaxLength(12);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle).IsRequired();

                entity.HasOne(d => d.ConsignesNavigation)
                    .WithMany(p => p.LPConsignesCodeoutilCoupe)
                    .HasForeignKey(d => d.Consignes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParamConsignesCodeOutilCoupeTypeConsignes");
            });

            modelBuilder.Entity<LPConsignesDecoupe>(entity =>
            {
                entity.HasKey(e => new { e.CodeConsigne, e.Section, e.Consignes });

                entity.ToTable("L_P_CONSIGNES_DECOUPE");

                entity.HasIndex(e => e.Consignes)
                    .HasName("IX_FK_TypeConsignesParamConsignesDecoupe");

                entity.Property(e => e.CodeConsigne).HasMaxLength(12);

                entity.Property(e => e.Section).HasMaxLength(4);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle).IsRequired();

                entity.HasOne(d => d.ConsignesNavigation)
                    .WithMany(p => p.LPConsignesDecoupe)
                    .HasForeignKey(d => d.Consignes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeConsignesParamConsignesDecoupe");
            });

            modelBuilder.Entity<LPConsignesDegazageDetail>(entity =>
            {
                entity.ToTable("L_P_CONSIGNES_DEGAZAGE_DETAIL");

                entity.Property(e => e.H21).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.H22).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.H23).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.H24).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.ProfilProduit)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Refroidissement).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.SectionMax).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.SectionMin).HasColumnType("decimal(4, 1)");
            });

            modelBuilder.Entity<LPConsignesDegazageGlobal>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("L_P_CONSIGNES_DEGAZAGE_GLOBAL");

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.StandardM).IsRequired();

                entity.Property(e => e.Tableau)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<LPConsignesLingot>(entity =>
            {
                entity.HasKey(e => new { e.CodeConsigne, e.Section, e.Consignes });

                entity.ToTable("L_P_CONSIGNES_LINGOT");

                entity.HasIndex(e => e.Consignes)
                    .HasName("IX_FK_TypeConsignesParamConsignesLingot");

                entity.Property(e => e.CodeConsigne).HasMaxLength(12);

                entity.Property(e => e.Section).HasMaxLength(4);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle).IsRequired();

                entity.HasOne(d => d.ConsignesNavigation)
                    .WithMany(p => p.LPConsignesLingot)
                    .HasForeignKey(d => d.Consignes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeConsignesParamConsignesLingot");
            });

            modelBuilder.Entity<LPConsignesMarquage>(entity =>
            {
                entity.HasKey(e => new { e.Section, e.Consignes, e.CodeConsigne });

                entity.ToTable("L_P_CONSIGNES_MARQUAGE");

                entity.HasIndex(e => e.Consignes)
                    .HasName("IX_FK_ParamConsignesMarquageTypeConsignes");

                entity.Property(e => e.Section).HasMaxLength(4);

                entity.Property(e => e.CodeConsigne).HasMaxLength(12);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.LibellePied)
                    .IsRequired()
                    .HasColumnName("Libelle_Pied");

                entity.Property(e => e.LibelleSection)
                    .IsRequired()
                    .HasColumnName("Libelle_Section");

                entity.Property(e => e.LibelleTete)
                    .IsRequired()
                    .HasColumnName("Libelle_Tete");

                entity.Property(e => e.Type).IsRequired();

                entity.HasOne(d => d.ConsignesNavigation)
                    .WithMany(p => p.LPConsignesMarquage)
                    .HasForeignKey(d => d.Consignes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParamConsignesMarquageTypeConsignes");
            });

            modelBuilder.Entity<LPConsignesPits>(entity =>
            {
                entity.HasKey(e => new { e.CodeConsigne, e.Section, e.Consignes });

                entity.ToTable("L_P_CONSIGNES_PITS");

                entity.HasIndex(e => e.Consignes)
                    .HasName("IX_FK_TypeConsignesParamConsignesEnfournementPits");

                entity.Property(e => e.CodeConsigne).HasMaxLength(12);

                entity.Property(e => e.Section).HasMaxLength(4);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle).IsRequired();

                entity.HasOne(d => d.ConsignesNavigation)
                    .WithMany(p => p.LPConsignesPits)
                    .HasForeignKey(d => d.Consignes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeConsignesParamConsignesEnfournementPits");
            });

            modelBuilder.Entity<LPConsignesPoidsmetrique>(entity =>
            {
                entity.HasKey(e => new { e.CodeConsigne, e.Consignes, e.Section });

                entity.ToTable("L_P_CONSIGNES_POIDSMETRIQUE");

                entity.HasIndex(e => e.Consignes)
                    .HasName("IX_FK_TypeConsignesParamConsignesPoidsMetrique");

                entity.Property(e => e.CodeConsigne).HasMaxLength(12);

                entity.Property(e => e.Section).HasMaxLength(4);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle).IsRequired();

                entity.HasOne(d => d.ConsignesNavigation)
                    .WithMany(p => p.LPConsignesPoidsmetrique)
                    .HasForeignKey(d => d.Consignes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeConsignesParamConsignesPoidsMetrique");
            });

            modelBuilder.Entity<LPConsignesPrechauffageModification>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("L_P_CONSIGNES_PRECHAUFFAGE_MODIFICATION");

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Lien).IsRequired();
            });

            modelBuilder.Entity<LPConsignesPrechauffageParticulier>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("L_P_CONSIGNES_PRECHAUFFAGE_PARTICULIER");

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<LPConsignesRefroidissement>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("L_P_CONSIGNES_REFROIDISSEMENT");

                entity.Property(e => e.Code)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LPConsignesRefroidissementBloom>(entity =>
            {
                entity.HasKey(e => e.CodeConsigne);

                entity.ToTable("L_P_CONSIGNES_REFROIDISSEMENT_BLOOM");

                entity.Property(e => e.CodeConsigne).HasMaxLength(12);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle).IsRequired();
            });

            modelBuilder.Entity<LPConsignesRefroidissementLingot>(entity =>
            {
                entity.HasKey(e => e.CodeConsigne);

                entity.ToTable("L_P_CONSIGNES_REFROIDISSEMENT_LINGOT");

                entity.Property(e => e.CodeConsigne).HasMaxLength(12);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle).IsRequired();
            });

            modelBuilder.Entity<LPConsignesRefroidissoirs>(entity =>
            {
                entity.HasKey(e => new { e.CodeConsigne, e.Section, e.Consignes });

                entity.ToTable("L_P_CONSIGNES_REFROIDISSOIRS");

                entity.HasIndex(e => e.Consignes)
                    .HasName("IX_FK_TypeConsignesParamConsignesRefroidissoir");

                entity.Property(e => e.CodeConsigne).HasMaxLength(12);

                entity.Property(e => e.Section).HasMaxLength(4);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle).IsRequired();

                entity.HasOne(d => d.ConsignesNavigation)
                    .WithMany(p => p.LPConsignesRefroidissoirs)
                    .HasForeignKey(d => d.Consignes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeConsignesParamConsignesRefroidissoir");
            });

            modelBuilder.Entity<LPConsignesScarfing>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("L_P_CONSIGNES_SCARFING");

                entity.Property(e => e.Code)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.LpLt)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Pression1).HasColumnType("decimal(2, 1)");

                entity.Property(e => e.Pression2).HasColumnType("decimal(2, 1)");

                entity.Property(e => e.Pression3).HasColumnType("decimal(2, 1)");

                entity.Property(e => e.TypeGaz)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LPConsignesSmq>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("L_P_CONSIGNES_SMQ");

                entity.Property(e => e.Code)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LPDefaut>(entity =>
            {
                entity.ToTable("L_P_DEFAUT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Externe)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LPDelaisLivraison>(entity =>
            {
                entity.HasKey(e => new { e.Code, e.Lingot });

                entity.ToTable("L_P_DELAIS_LIVRAISON");

                entity.Property(e => e.Lingot).HasColumnType("decimal(2, 1)");

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Valeur)
                    .IsRequired()
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<LPDestination>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("L_P_DESTINATION");

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle).HasMaxLength(50);
            });

            modelBuilder.Entity<LPEquipes>(entity =>
            {
                entity.ToTable("L_P_EQUIPES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Contremaitre)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.IdEquipe).HasMaxLength(25);
            });

            modelBuilder.Entity<LPJalonActiviteProfil>(entity =>
            {
                entity.ToTable("L_P_JALON_ACTIVITE_PROFIL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AffichageIhm)
                    .IsRequired()
                    .HasColumnName("AffichageIHM")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Commentaires)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DateMaj)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<LPJalonMotif>(entity =>
            {
                entity.ToTable("L_P_JALON_MOTIF");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateMaj)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MotifJalon)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<LPLienPdf>(entity =>
            {
                entity.ToTable("L_P_LIEN_PDF");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Lien).HasMaxLength(250);
            });

            modelBuilder.Entity<LPLieuxStockLaminoir>(entity =>
            {
                entity.HasKey(e => new { e.Lieu, e.Id });

                entity.ToTable("L_P_LIEUX_STOCK_LAMINOIR");

                entity.HasIndex(e => e.Idzone)
                    .HasName("IX_FK_ParamZoneStockLaminoirParamLieuxStockLaminoir");

                entity.Property(e => e.Lieu).HasMaxLength(15);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Idzone).HasColumnName("IDZone");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.HasOne(d => d.IdzoneNavigation)
                    .WithMany(p => p.LPLieuxStockLaminoir)
                    .HasForeignKey(d => d.Idzone)
                    .HasConstraintName("FK_ParamZoneStockLaminoirParamLieuxStockLaminoir");
            });

            modelBuilder.Entity<LPLieuxStockPaquetsPesee>(entity =>
            {
                entity.ToTable("L_P_LIEUX_STOCK_PAQUETS_PESEE");

                entity.HasIndex(e => e.Lieu)
                    .HasName("IX_L_P_LIEUX_STOCK_PAQUETS_PESEE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Lieu)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<LPMontageSectionMam>(entity =>
            {
                entity.ToTable("L_P_MONTAGE_SECTION_MAM");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cannelure).HasMaxLength(4);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Profil)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.RayonChutage).HasColumnType("decimal(3, 2)");
            });

            modelBuilder.Entity<LPParametresGeneraux>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("L_P_PARAMETRES_GENERAUX");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Display).HasMaxLength(8);

                entity.Property(e => e.TypeData)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Valeur)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LPPredecesseurZone>(entity =>
            {
                entity.ToTable("L_P_PREDECESSEUR_ZONE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Destination1).HasMaxLength(5);

                entity.Property(e => e.Destination2).HasMaxLength(5);

                entity.Property(e => e.Destination3).HasMaxLength(5);

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Zone)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<LPPriseDeFer>(entity =>
            {
                entity.ToTable("L_P_PRISE_DE_FER");

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Montage)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.TypeProfil)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LPProfilProduit>(entity =>
            {
                entity.ToTable("L_P_PROFIL_PRODUIT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Libelle).IsRequired();
            });

            modelBuilder.Entity<LPProgBillette>(entity =>
            {
                entity.ToTable("L_P_PROG_BILLETTE");

                entity.Property(e => e.CalibrageOvale).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CalibrageRond).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CanelurePasse1).HasMaxLength(5);

                entity.Property(e => e.CanelurePasse10).HasMaxLength(5);

                entity.Property(e => e.CanelurePasse11).HasMaxLength(5);

                entity.Property(e => e.CanelurePasse12).HasMaxLength(5);

                entity.Property(e => e.CanelurePasse13).HasMaxLength(5);

                entity.Property(e => e.CanelurePasse14).HasMaxLength(5);

                entity.Property(e => e.CanelurePasse15).HasMaxLength(5);

                entity.Property(e => e.CanelurePasse2).HasMaxLength(5);

                entity.Property(e => e.CanelurePasse3).HasMaxLength(5);

                entity.Property(e => e.CanelurePasse4).HasMaxLength(5);

                entity.Property(e => e.CanelurePasse5).HasMaxLength(5);

                entity.Property(e => e.CanelurePasse6).HasMaxLength(5);

                entity.Property(e => e.CanelurePasse7).HasMaxLength(5);

                entity.Property(e => e.CanelurePasse8).HasMaxLength(5);

                entity.Property(e => e.CanelurePasse9).HasMaxLength(5);

                entity.Property(e => e.CoteBouchon).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.ElevationPasse1).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse10).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse11).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse12).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse13).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse14).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse15).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse2).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse3).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse4).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse5).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse6).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse7).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse8).HasMaxLength(4);

                entity.Property(e => e.ElevationPasse9).HasMaxLength(4);

                entity.Property(e => e.Largeur).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.Monture)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Observations)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.OuvertureOv)
                    .HasColumnName("OuvertureOV")
                    .HasMaxLength(3);

                entity.Property(e => e.OuverturePov)
                    .HasColumnName("OuverturePOV")
                    .HasMaxLength(3);

                entity.Property(e => e.OuvertureRond).HasMaxLength(3);

                entity.Property(e => e.PriseDeFerHauteur).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PriseDeFerLargeur).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Profile)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Section).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.SectionMax).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.SectionMin).HasColumnType("decimal(4, 1)");
            });

            modelBuilder.Entity<LPPso>(entity =>
            {
                entity.HasKey(e => e.CodePso);

                entity.ToTable("L_P_PSO");

                entity.Property(e => e.CodePso)
                    .HasColumnName("CodePSO")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.DateMaj)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LPRebut>(entity =>
            {
                entity.ToTable("L_P_REBUT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle).IsRequired();
            });

            modelBuilder.Entity<LPRepere>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("L_P_REPERE");

                entity.Property(e => e.Code).HasMaxLength(8);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Smq)
                    .HasColumnName("SMQ")
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<LPRepereAutoLingot>(entity =>
            {
                entity.HasKey(e => new { e.AnomalieCop, e.Lingot });

                entity.ToTable("L_P_REPERE_AUTO_LINGOT");

                entity.Property(e => e.AnomalieCop).HasColumnName("AnomalieCOP");

                entity.Property(e => e.Lingot)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Reperage)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LPSmq>(entity =>
            {
                entity.ToTable("L_P_SMQ");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Action).IsRequired();

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.StandardM).IsRequired();
            });

            modelBuilder.Entity<LPTextOperations>(entity =>
            {
                entity.HasKey(e => e.CodeOperation);

                entity.ToTable("L_P_TEXT_OPERATIONS");

                entity.Property(e => e.CodeOperation)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.LibelleConsigne).IsRequired();
            });

            modelBuilder.Entity<LPTypeConsigne>(entity =>
            {
                entity.ToTable("L_P_TYPE_CONSIGNE");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Libelle).IsRequired();
            });

            modelBuilder.Entity<LPZoneStockLaminoir>(entity =>
            {
                entity.ToTable("L_P_ZONE_STOCK_LAMINOIR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<LSBilanPitsCoulee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("L_S_Bilan_Pits_Coulee");

                entity.Property(e => e.AvecCop)
                    .HasColumnName("AvecCOP")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Coulee)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.GrosFour)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Jour)
                    .HasColumnName("jour")
                    .HasColumnType("datetime");

                entity.Property(e => e.Poste)
                    .IsRequired()
                    .HasColumnName("poste")
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.RetardLivraison)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.TypeLingot)
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LSBilanPitsFroid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("L_S_Bilan_Pits_Froid");

                entity.Property(e => e._1t8)
                    .HasColumnName("1T8")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e._2t7)
                    .HasColumnName("2T7")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e._3t3)
                    .HasColumnName("3T3")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e._5t3)
                    .HasColumnName("5T3")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e._6t2)
                    .HasColumnName("6T2")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e._7t5)
                    .HasColumnName("7T5")
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LSBilanPitsSynthese>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("L_S_Bilan_Pits_Synthese");

                entity.Property(e => e.Eccinqtrois).HasColumnName("eccinqtrois");

                entity.Property(e => e.Ecseptcinq).HasColumnName("ecseptcinq");

                entity.Property(e => e.Ecsixdeux).HasColumnName("ecsixdeux");

                entity.Property(e => e.Efcinqtrois).HasColumnName("efcinqtrois");

                entity.Property(e => e.Efseptcinq).HasColumnName("efseptcinq");

                entity.Property(e => e.Efsixdeux).HasColumnName("efsixdeux");

                entity.Property(e => e.Enfcinqtrois).HasColumnName("enfcinqtrois");

                entity.Property(e => e.Enfseptcinq).HasColumnName("enfseptcinq");

                entity.Property(e => e.Enfsixdeux).HasColumnName("enfsixdeux");

                entity.Property(e => e.Enftroisdeux).HasColumnName("enftroisdeux");

                entity.Property(e => e.NbCouleeAvecCop).HasColumnName("nbCouleeAvecCOP");

                entity.Property(e => e.NbCouleeAvecGrosFour).HasColumnName("nbCouleeAvecGrosFour");

                entity.Property(e => e.NbCouleeRecu).HasColumnName("nbCouleeRecu");

                entity.Property(e => e.NbCouleeRetard).HasColumnName("nbCouleeRetard");
            });

            modelBuilder.Entity<LSBlooming>(entity =>
            {
                entity.ToTable("L_S_BLOOMING");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsCouleeChaude)
                    .IsRequired()
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.IsOfessai)
                    .IsRequired()
                    .HasColumnName("IsOFEssai")
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.LaminageControle).HasMaxLength(3);

                entity.Property(e => e.Montage).IsRequired();

                entity.Property(e => e.NumLingot).IsRequired();

                entity.Property(e => e.Of)
                    .IsRequired()
                    .HasColumnName("OF");

                entity.Property(e => e.Poids).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Profil).IsRequired();

                entity.Property(e => e.Scarfing)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Section).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.TopDebutLaminage).HasColumnType("datetime");

                entity.Property(e => e.TopFinLaminage).HasColumnType("datetime");
            });

            modelBuilder.Entity<LSCapteurZoneSuivi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("L_S_Capteur_Zone_Suivi");

                entity.Property(e => e.Capteur).HasMaxLength(10);

                entity.Property(e => e.DateCapteur).HasColumnType("datetime");

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Fonction).HasMaxLength(5);

                entity.Property(e => e.NombrePf).HasColumnName("NombrePF");

                entity.Property(e => e.Of)
                    .IsRequired()
                    .HasColumnName("OF")
                    .HasMaxLength(12);

                entity.Property(e => e.Rang).HasMaxLength(2);

                entity.Property(e => e.RangAcierie).HasMaxLength(2);

                entity.Property(e => e.Zone).HasMaxLength(10);
            });

            modelBuilder.Entity<LSDetailOfcapteur>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("L_S_DetailOFCapteur");

                entity.Property(e => e.Capteur)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DerniereActivation).HasColumnType("datetime");

                entity.Property(e => e.PremiereActivation).HasColumnType("datetime");
            });

            modelBuilder.Entity<LSLaminoir>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("L_S_LAMINOIR");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TypeData)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Valeur)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LSLpb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("L_S_LPB");

                entity.Property(e => e.AcompteSolde)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Arr).HasMaxLength(8);

                entity.Property(e => e.CCli)
                    .HasColumnName("C_Cli")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.CEnf)
                    .HasColumnName("C_Enf")
                    .HasMaxLength(18);

                entity.Property(e => e.CScf)
                    .HasColumnName("C_Scf")
                    .HasMaxLength(18);

                entity.Property(e => e.Client).HasMaxLength(13);

                entity.Property(e => e.Coulee)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.CsgChf)
                    .HasColumnName("Csg_Chf")
                    .HasMaxLength(18);

                entity.Property(e => e.DateDebutLaminage).HasColumnType("datetime");

                entity.Property(e => e.DateEnfournement).HasColumnType("datetime");

                entity.Property(e => e.DerDefournement).HasColumnType("datetime");

                entity.Property(e => e.Dim).HasMaxLength(5);

                entity.Property(e => e.Inc).HasMaxLength(8);

                entity.Property(e => e.Lc)
                    .HasColumnName("LC")
                    .HasMaxLength(18);

                entity.Property(e => e.Mnt).HasMaxLength(8);

                entity.Property(e => e.Mrc).HasMaxLength(8);

                entity.Property(e => e.NbF1).HasColumnName("Nb_F1");

                entity.Property(e => e.NbF2).HasColumnName("Nb_F2");

                entity.Property(e => e.NbProd).HasColumnName("Nb_Prod");

                entity.Property(e => e.Nuance).HasMaxLength(7);

                entity.Property(e => e.NumeroMontage)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Pan).HasMaxLength(8);

                entity.Property(e => e.PdsProd)
                    .HasColumnName("Pds_Prod")
                    .HasColumnType("decimal(4, 3)");

                entity.Property(e => e.PdsTotal)
                    .HasColumnName("Pds_Total")
                    .HasColumnType("decimal(6, 3)");

                entity.Property(e => e.PreDefournement).HasColumnType("datetime");
            });

            modelBuilder.Entity<LSOptiLgBarre>(entity =>
            {
                entity.ToTable("L_S_OPTI_LG_BARRE");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.LgBrCourte).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.LgBrMaxi).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.LgBrMini).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.LgChutage).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.LgCoupe).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.LgOpti).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LgRestante).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.LgSecurite).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.LgTot).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LgUtil).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Of)
                    .IsRequired()
                    .HasColumnName("OF")
                    .HasMaxLength(12);

                entity.Property(e => e.Pdf)
                    .HasColumnName("PDF")
                    .HasMaxLength(8);

                entity.Property(e => e.PositionButee).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.PositionScieFixe).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.PositionScieMobile).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Rang).HasMaxLength(2);
            });

            modelBuilder.Entity<LSProduction>(entity =>
            {
                entity.ToTable("L_S_PRODUCTION");

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<LSProductionLsi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("L_S_PRODUCTION_LSI");

                entity.Property(e => e.As)
                    .HasColumnName("AS")
                    .HasMaxLength(1);

                entity.Property(e => e.Client).HasMaxLength(13);

                entity.Property(e => e.CodeConsPits).HasMaxLength(3);

                entity.Property(e => e.CodeOpePits).HasMaxLength(3);

                entity.Property(e => e.CodeScarf).HasMaxLength(3);

                entity.Property(e => e.Coulee).HasMaxLength(6);

                entity.Property(e => e.CouleeFroide).HasMaxLength(3);

                entity.Property(e => e.DateDebutLaminage).HasColumnType("datetime");

                entity.Property(e => e.DateDebutOf)
                    .HasColumnName("DateDebutOF")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateDefournement).HasColumnType("datetime");

                entity.Property(e => e.DateEnfournement).HasColumnType("datetime");

                entity.Property(e => e.DateEvc)
                    .HasColumnName("DateEVC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateFinLaminage).HasColumnType("datetime");

                entity.Property(e => e.DateFinOf)
                    .HasColumnName("DateFinOF")
                    .HasColumnType("datetime");

                entity.Property(e => e.Destination).HasMaxLength(3);

                entity.Property(e => e.DiametreProduit).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.Dimension).HasMaxLength(6);

                entity.Property(e => e.DureeChauffe).HasMaxLength(8);

                entity.Property(e => e.DureeLaminage).HasMaxLength(8);

                entity.Property(e => e.DureeOf)
                    .HasColumnName("DureeOF")
                    .HasMaxLength(8);

                entity.Property(e => e.Equipe).HasMaxLength(1);

                entity.Property(e => e.Etat).HasColumnName("etat");

                entity.Property(e => e.NombreEvc).HasColumnName("NombreEVC");

                entity.Property(e => e.Nuance).HasMaxLength(7);

                entity.Property(e => e.NumeroMontage).HasMaxLength(3);

                entity.Property(e => e.Of)
                    .IsRequired()
                    .HasColumnName("OF")
                    .HasMaxLength(12);

                entity.Property(e => e.PoidsChauffe).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.PoidsDemiProduitUnitaire).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.PoidsEvc)
                    .HasColumnName("PoidsEVC")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.PoidsLamine).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.PoidsPrevuDemiProduit).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.PoidsRebute).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.ProfilProduit).HasMaxLength(5);

                entity.Property(e => e.Thlamine)
                    .HasColumnName("THLamine")
                    .HasColumnType("decimal(8, 3)");
            });

            modelBuilder.Entity<LSProductionLsiTotal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("L_S_PRODUCTION_LSI_TOTAL");

                entity.Property(e => e.NbTotalEvc).HasColumnName("NbTotalEVC");

                entity.Property(e => e.PdsTotalChauffe).HasColumnType("decimal(12, 3)");

                entity.Property(e => e.PdsTotalEvc)
                    .HasColumnName("PdsTotalEVC")
                    .HasColumnType("decimal(12, 3)");

                entity.Property(e => e.PdsTotalFroid).HasColumnType("decimal(12, 3)");

                entity.Property(e => e.PdsTotalLamine).HasColumnType("decimal(12, 3)");

                entity.Property(e => e.PdsTotalRebute).HasColumnType("decimal(12, 3)");

                entity.Property(e => e.Poste).HasMaxLength(6);
            });

            modelBuilder.Entity<LSRapportSyntheseMensuelle>(entity =>
            {
                entity.ToTable("L_S_RAPPORT_SYNTHESE_MENSUELLE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cumul).HasMaxLength(12);

                entity.Property(e => e.LabelDate)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LabelNom)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValeurMois1).HasMaxLength(12);

                entity.Property(e => e.ValeurMois10).HasMaxLength(12);

                entity.Property(e => e.ValeurMois11).HasMaxLength(12);

                entity.Property(e => e.ValeurMois12).HasMaxLength(12);

                entity.Property(e => e.ValeurMois2).HasMaxLength(12);

                entity.Property(e => e.ValeurMois3).HasMaxLength(12);

                entity.Property(e => e.ValeurMois4).HasMaxLength(12);

                entity.Property(e => e.ValeurMois5).HasMaxLength(12);

                entity.Property(e => e.ValeurMois6).HasMaxLength(12);

                entity.Property(e => e.ValeurMois7).HasMaxLength(12);

                entity.Property(e => e.ValeurMois8).HasMaxLength(12);

                entity.Property(e => e.ValeurMois9).HasMaxLength(12);
            });

            modelBuilder.Entity<LSSyntheseProductionMensuelle>(entity =>
            {
                entity.ToTable("L_S_SYNTHESE_PRODUCTION_MENSUELLE");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCloture).HasColumnType("datetime");

                entity.Property(e => e.Hj).HasColumnName("HJ");

                entity.Property(e => e.Hmb).HasColumnName("HMB");

                entity.Property(e => e.Hmm).HasColumnName("HMM");

                entity.Property(e => e.Hmn).HasColumnName("HMN");

                entity.Property(e => e.Ho).HasColumnName("HO");

                entity.Property(e => e.Hta).HasColumnName("HTA");

                entity.Property(e => e.Htc).HasColumnName("HTC");

                entity.Property(e => e.Htd).HasColumnName("HTD");

                entity.Property(e => e.Htg).HasColumnName("HTG");

                entity.Property(e => e.Hth).HasColumnName("HTH");

                entity.Property(e => e.Hti).HasColumnName("HTI");

                entity.Property(e => e.Htm).HasColumnName("HTM");

                entity.Property(e => e.Htp).HasColumnName("HTP");

                entity.Property(e => e.Htq).HasColumnName("HTQ");

                entity.Property(e => e.Htr).HasColumnName("HTR");

                entity.Property(e => e.Htt).HasColumnName("HTT");
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Id })
                    .HasName("PK_HangFire_List");

                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_List_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<LsiBilanCoulee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LSI_bilan_coulee");

                entity.Property(e => e.AvecCop)
                    .HasColumnName("AvecCOP")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Coulee)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.GrosFour)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Jour)
                    .HasColumnName("jour")
                    .HasColumnType("datetime");

                entity.Property(e => e.Poste)
                    .IsRequired()
                    .HasColumnName("poste")
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.RetardLivraison)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LsiReportTrace>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LSI_Report_trace");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Procedure)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LsiResultatsTxt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LSI_Resultats.txt");

                entity.Property(e => e.Capteur)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DateMaj).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Of)
                    .HasColumnName("OF")
                    .HasMaxLength(12);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.HasIndex(e => e.LastHeartbeat)
                    .HasName("IX_HangFire_Server_LastHeartbeat");

                entity.Property(e => e.Id).HasMaxLength(100);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Value })
                    .HasName("PK_HangFire_Set");

                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Set_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.HasIndex(e => new { e.Key, e.Score })
                    .HasName("IX_HangFire_Set_Score");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Value).HasMaxLength(256);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Id })
                    .HasName("PK_HangFire_State");

                entity.ToTable("State", "HangFire");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<Tmpblocote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMPBLOCOTE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
