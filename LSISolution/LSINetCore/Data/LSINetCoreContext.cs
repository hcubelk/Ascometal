using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LSINetCore.Models
{
    
    public class LSINetCoreContext : DbContext
    {
        public LSINetCoreContext(DbContextOptions<LSINetCoreContext> options) : base(options) { }

        //public DbSet<LSINetCore.Models.Movie> Movie { get; set; }
        public DbSet<LDEtatStock> L_D_ETAT_STOCK { get; set; }
        public DbSet<LDOrdreFabrication> L_D_ORDRE_FABRICATION { get; set; }
        public DbSet<LDOfSuivi> L_D_OF_SUIVI { get; set; }
        
        public DbSet<LDSectionchargePits> L_D_SECTIONCHARGE_PITS { get; set; }

        public DbSet<LDSectionchargeLingot> L_D_SECTIONCHARGE_LINGOT { get; set; }
        public DbSet<LDConsignes> L_D_CONSIGNES { get; set; }

        public DbSet<LDSectionchargeDecoupe> L_D_SECTIONCHARGE_DECOUPE { get; set; }
        public DbSet<LDSectionchargeRefroidissoirs> L_D_SECTIONCHARGE_REFROIDISSOIRS { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // LDOrdreFabrication
        //    // Foreign Key LDOfSuivi
        //    modelBuilder.Entity<LDOrdreFabrication>()
        //        .HasOne(of => of.LDOfSuivi)
        //        .WithOne(suivi => suivi.OfNavigation)
        //        .HasForeignKey<LDOfSuivi>(fk => fk.Of);

        //    // Foreign Key LDPlansFours
        //    modelBuilder.Entity<LDOrdreFabrication>()
        //        .HasMany(of => of.LDPlansFours)
        //        .WithOne(profil => profil.OfNavigation);


        //    // LDConsignes
        //    // Primary Key
        //    modelBuilder.Entity<LDConsignes>()
        //        .HasKey(c => new { c.Of, c.CodeConsigne, c.TypeConsigne, c.ConsigneGpao});

        //    // LDPlansFours
        //    // Primary Key
        //    modelBuilder.Entity<LDPlansFours>()
        //        .HasKey(c => new { c.FourId, c.Position });

        //    // LDPso
        //    // Primary Key
        //    modelBuilder.Entity<LDPso>()
        //        .HasKey(c => new { c.Coulee, c.NumeroLingot});

        //    // LDRebut
        //    // Primary Key
        //    modelBuilder.Entity<LDRebut>()
        //        .HasKey(c => new { c.Of, c.RangLingotPassageAuLaminoir, c.DateRebut});

        //    // LDSectionchargeChutage
        //    // Primary Key
        //    modelBuilder.Entity<LDSectionchargeChutage>()
        //        .HasKey(c => new { c.Of, c.CodeOperation});

        //    // LDSectionchargeDecoupe
        //    // Primary Key
        //    modelBuilder.Entity<LDSectionchargeDecoupe>()
        //       .HasKey(c => new { c.Of, c.CodeOperation });

        //    // LDSectionchargeLingot
        //    // Primary Key
        //    modelBuilder.Entity<LDSectionchargeLingot>()
        //       .HasKey(c => new { c.Of, c.CodeOperation });

        //    // LDSectionchargePits
        //    // Primary Key
        //    modelBuilder.Entity<LDSectionchargePits>()
        //       .HasKey(c => new { c.Of, c.CodeOperation });

        //    // LDSectionchargePoidsmetrique
        //    // Primary Key
        //    modelBuilder.Entity<LDSectionchargePoidsmetrique>()
        //       .HasKey(c => new { c.Of, c.CodeOperation });

        //    // LDSectionchargeRefroidissoirs
        //    // Primary Key
        //    modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
        //       .HasKey(c => new { c.Of, c.CodeOperation });

        //    // LDSectionchargeSvt
        //    // Primary Key
        //    modelBuilder.Entity<LDSectionchargeSvt>()
        //       .HasKey(c => new { c.Of, c.CodeOperation });
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LDAnomalies>()
                .Property(e => e.IdCoulee)
                .IsFixedLength();

            modelBuilder.Entity<LDAnomalies>()
                .Property(e => e.Enregistrement)
                .IsFixedLength();

            modelBuilder.Entity<LDArret>()
                .Property(e => e.Of)
                .IsFixedLength();
            
            modelBuilder.Entity<LDAsiSuivi>()
                .Property(e => e.NoEnregistrement)
                .IsFixedLength();

            modelBuilder.Entity<LDBilletteLaminage>()
                .Property(e => e.Of)
                .IsFixedLength();
            ///////////////////////////////////////////////////////////////////
            // LDBloomingLaminage.
            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloOfinterne)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloMontage)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure1)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure2)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure3)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure4)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure5)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure6)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure7)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure8)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure9)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure10)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure11)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure12)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure13)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure14)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure15)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure16)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure17)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure18)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure19)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure20)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure21)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure22)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure23)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure24)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure25)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure26)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure27)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure28)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure29)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure30)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure31)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure32)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure33)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure34)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure35)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure36)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure37)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure38)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure39)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure40)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure41)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure42)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure43)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure44)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure45)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure46)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure47)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure48)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure49)
                .IsUnicode(false);

            modelBuilder.Entity<LDBloomingLaminage>()
                .Property(e => e.BloCannelure50)
                .IsUnicode(false);

            ///////////////////////////////////////////////////////////////////
            
            modelBuilder.Entity<LDCages>()
                .Property(e => e.Longueur)
                .HasPrecision(5, 3);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Profondeur)
                .HasPrecision(5, 3);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.DiametreInferieur)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.DiametreSuperieur)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.LargeurCannelure1)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.ProfondeurCannelure1)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.LargeurCannelure2)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.ProfondeurCannelure2)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.LargeurCannelure3)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.ProfondeurCannelure3)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.LargeurCannelure4)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.ProfondeurCannelure4)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.LargeurCannelure5)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.ProfondeurCannelure5)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.LargeurCannelure6)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.ProfondeurCannelure6)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.LargeurCannelure7)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.ProfondeurCannelure7)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.LargeurCannelure8)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.ProfondeurCannelure8)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.LargeurCannelure9)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.ProfondeurCannelure9)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.LargeurCannelure10)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.ProfondeurCannelure10)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.LargeurCannelure11)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.ProfondeurCannelure11)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.LargeurCannelure12)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.ProfondeurCannelure12)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.LargeurCannelure13)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.ProfondeurCannelure13)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.LargeurCannelure14)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.ProfondeurCannelure14)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.LargeurCannelure15)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.ProfondeurCannelure15)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Largeur2Cannelure1)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Profondeur2Cannelure1)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Largeur2Cannelure2)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Profondeur2Cannelure2)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Largeur2Cannelure3)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Profondeur2Cannelure3)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Largeur2Cannelure4)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Profondeur2Cannelure4)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Largeur2Cannelure5)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Profondeur2Cannelure5)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Largeur2Cannelure6)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Profondeur2Cannelure6)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Largeur2Cannelure7)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Profondeur2Cannelure7)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Largeur2Cannelure8)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Profondeur2Cannelure8)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Largeur2Cannelure9)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Profondeur2Cannelure9)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Largeur2Cannelure10)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Profondeur2Cannelure10)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Largeur2Cannelure11)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Profondeur2Cannelure11)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Largeur2Cannelure12)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Profondeur2Cannelure12)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Largeur2Cannelure13)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Profondeur2Cannelure13)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Largeur2Cannelure14)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Profondeur2Cannelure14)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Largeur2Cannelure15)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCages>()
                .Property(e => e.Profondeur2Cannelure15)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDCommandes>()
                .HasMany(e => e.LDRoles)
                .WithOne(e => e.TransactionCodeNavigation)
                .HasForeignKey(e => e.TransactionCode)
                .OnDelete(DeleteBehavior.ClientSetNull);

            // LDConsignes.
            modelBuilder.Entity<LDConsignes>()
                .Property(e => e.Of)
                .IsFixedLength();

            modelBuilder.Entity<LDConsignes>()
                .Property(e => e.CodeOperation)
                .IsFixedLength();
            
            modelBuilder.Entity<LDConsignes>()
                .HasKey(c => new { c.Of, c.CodeConsigne, c.TypeConsigne, c.ConsigneGpao });

            modelBuilder.Entity<LDCoulee>()
                .Property(e => e.IdCoulee)
                .IsFixedLength();

            modelBuilder.Entity<LDCoulee>()
                .Property(e => e.Nuance)
                .IsFixedLength();

            modelBuilder.Entity<LDCoulee>()
                .Property(e => e.TypeLingot1)
                .IsFixedLength();

            modelBuilder.Entity<LDCoulee>()
                .Property(e => e.TypeLingot2)
                .IsFixedLength();

            modelBuilder.Entity<LDCoulee>()
                .Property(e => e.DensiteCoulee)
                .HasPrecision(5, 3);

            modelBuilder.Entity<LDCoulee>()
                .Property(e => e.Hydrogene)
                .HasPrecision(3, 2);

            modelBuilder.Entity<LDCoulee>()
                .Property(e => e.Enregistrement)
                .IsFixedLength();

            modelBuilder.Entity<LDCoulee>()
                .HasMany(e => e.LDAnomalies)
                .WithOne(e => e.IdCouleeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LDCoulee>()
                .HasMany(e => e.LDOrdreFabrication)
                .WithOne(e => e.CouleeNavigation)/////////////////////////////////////////////////////// withoptional
                .HasForeignKey(e => e.Coulee);

            modelBuilder.Entity<LDCoulee>()
                .HasMany(e => e.LDStockPso)
                .WithOne(e => e.IdCouleeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LDCoulee>()
                .HasMany(e => e.LDPso)
                .WithOne(e => e.CouleeNavigation)
                .HasForeignKey(e => e.Coulee)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LDCouleeSuivi>()
                .Property(e => e.IdCoulee)
                .IsFixedLength();

            modelBuilder.Entity<LDCouleeSuivi>()
                .Property(e => e.Nuance)
                .IsFixedLength();

            modelBuilder.Entity<LDCouleeSuivi>()
                .Property(e => e.TypeLingot1)
                .IsFixedLength();

            modelBuilder.Entity<LDCouleeSuivi>()
                .Property(e => e.TypeLingot2)
                .IsFixedLength();

            modelBuilder.Entity<LDCouleeSuivi>()
                .Property(e => e.DensiteCoulee)
                .HasPrecision(5, 3);

            modelBuilder.Entity<LDCouleeSuivi>()
                .Property(e => e.Hydrogene)
                .HasPrecision(3, 2);

            modelBuilder.Entity<LDCouleeSuivi>()
                .Property(e => e.Enregistrement)
                .IsFixedLength();

            modelBuilder.Entity<LDDefaut>()
                .Property(e => e.Coulee)
                .IsFixedLength();

            modelBuilder.Entity<LDEtatStock>()
                .Property(e => e.Coulee)
                .IsFixedLength();

            modelBuilder.Entity<LDEtatStock>()
                .Property(e => e.Pso)
                .IsFixedLength();

            modelBuilder.Entity<LDFourAcier>()
                .Property(e => e.Nuance)
                .IsUnicode(false);

            modelBuilder.Entity<LDFours>()
                .Property(e => e.PoidsEnfourne)
                .HasPrecision(6, 3);

            modelBuilder.Entity<LDFours>()
                .Property(e => e.OfenCours)
                .IsFixedLength();

            modelBuilder.Entity<LDFours>()
                .HasMany(e => e.LDPlansFours)
                .WithOne(e => e.Four)
                .HasForeignKey(e => e.FourId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LDHistoCages>()
                .Property(e => e.DiametreInferieur)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDHistoCages>()
                .Property(e => e.DiametreSuperieur)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDJalondeproduction>()
                .Property(e => e.Section)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDJalondeproduction>()
                .Property(e => e.Montage)
                .IsFixedLength();

            modelBuilder.Entity<LDJalondeproduction>()
                .Property(e => e.Pso)
                .IsFixedLength();

            modelBuilder.Entity<LDJalondeproduction>()
                .Property(e => e.PoidsUnitaire)
                .HasPrecision(10, 3);

            modelBuilder.Entity<LDJalondeproductionprev>()
                .Property(e => e.Section)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDJalondeproductionprev>()
                .Property(e => e.Montage)
                .IsFixedLength();

            modelBuilder.Entity<LDJalondeproductionprev>()
                .Property(e => e.Pso)
                .IsFixedLength();

            modelBuilder.Entity<LDJalondeproductionprev>()
                .Property(e => e.PoidsUnitaire)
                .HasPrecision(10, 3);

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.Of)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.Type)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.ProfilProduit)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.ClasseDeChute)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.MarqueCommerciale)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.NumeroMontage)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.AcompteSolde)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.RangOpePits)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.CodeOpePits)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.RangOpeLingot)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.CodeOpeLingot)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.ProfileLamine)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.CodeOpeChutage)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.RangOpeChutage)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.Destination)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.CodeOpeDecoupe)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.RangOpeDecoupe)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.CodeOpePoidMetrique)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.RangOpePoidMetrique)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.CodeOpeRefroidissoir)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.RangOpeRefroidissoir)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.RefroidissementBloom)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.Oforigin)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.Ofdestination)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.OforiginInterne)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.OfdestinationInterne)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.GazScarfing)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.OxygeneSuperieur)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.OxygeneInferieur)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.OxygeneLatent)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.VitesseV1)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.VitesseV2)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.VitesseV3)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.LongueurScarfingPied)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.LongueurScarfingTete)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.MiseAuMille)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.CodeOpeSvt)
                .IsFixedLength();

            modelBuilder.Entity<LDKape22>()
                .Property(e => e.RangOpeSvt)
                .IsFixedLength();

            modelBuilder.Entity<LDKla1>()
                .Property(e => e.Nuance)
                .IsFixedLength();

            modelBuilder.Entity<LDKla1>()
                .Property(e => e.Of)
                .IsFixedLength();

            modelBuilder.Entity<LDMamQual>()
                .Property(e => e.NumeroMontage)
                .IsFixedLength();

            modelBuilder.Entity<LDMamQual>()
                .Property(e => e.LgDeveloppee)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LDMamQual>()
                .Property(e => e.ConsigneScarfing)
                .IsFixedLength();

            modelBuilder.Entity<LDMamQual>()
                .Property(e => e.CodePesee)
                .IsFixedLength();

            modelBuilder.Entity<LDMouvementStock>()
                .Property(e => e.Pso)
                .IsFixedLength();

            modelBuilder.Entity<LDMouvementStock>()
                .Property(e => e.Coulee)
                .IsFixedLength();

            modelBuilder.Entity<LDOfSuivi>()
                .Property(e => e.Of)
                .IsFixedLength();

            modelBuilder.Entity<LDOfSuivi>()
                .HasOne(e => e.OfNavigation)
                .WithOne(e => e.LDOfSuivi)
                .HasForeignKey<LDOfSuivi>(fk => fk.Of);


            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.Of)
                .IsFixedLength();

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.Type)
                .IsFixedLength();

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.Coulee)
                .IsFixedLength();

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.ProfilProduit)
                .IsFixedLength();

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.DiametreProduit)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.ToleranceMaxSection)
                .HasPrecision(2, 1);

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.ToleranceMinSection)
                .HasPrecision(2, 1);

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.Epaisseur)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.ToleranceMaxEpaisseur)
                .HasPrecision(2, 1);

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.ToleranceMinEpaisseur)
                .HasPrecision(2, 1);

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.ClasseDeChute)
                .IsFixedLength();

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.LongueurCd)
                .HasPrecision(5, 3);

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.ToleranceMaxLongueur)
                .HasPrecision(4, 0);

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.ToleranceMinLongueur)
                .HasPrecision(4, 0);

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.MarqueCommerciale)
                .IsFixedLength();

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.NumeroMontage)
                .IsFixedLength();

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.PoidsDemiProduitUnitaire)
                .HasPrecision(7, 3);

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.AcompteSolde)
                .IsFixedLength();

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.PoidsPrevuDemiProduit)
                .HasPrecision(6, 3);

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.SensLaminage)
                .IsFixedLength();

            modelBuilder.Entity<LDOrdreFabrication>()
                .Property(e => e.SensLaminageGpao)
                .IsFixedLength();

            modelBuilder.Entity<LDOrdreFabrication>()
                .HasOne(e => e.LDOfSuivi)
                .WithOne(e => e.OfNavigation);

            modelBuilder.Entity<LDOrdreFabrication>()
                .HasMany(e => e.LDSectionchargeChutage)
                .WithOne(e => e.OfNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LDOrdreFabrication>()
                .HasMany(e => e.LDSectionchargeDecoupe)
                .WithOne(e => e.OfNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LDOrdreFabrication>()
                .HasMany(e => e.LDSectionchargePits)
                .WithOne(e => e.OfNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LDOrdreFabrication>()
                .HasMany(e => e.LDSectionchargeLingot)
                .WithOne(e => e.OfNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LDOrdreFabrication>()
                .HasMany(e => e.LDSectionchargePoidsmetrique)
                .WithOne(e => e.OfNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LDOrdreFabrication>()
                .HasMany(e => e.LDSectionchargeRefroidissoirs)
                .WithOne(e => e.OfNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LDOrdreFabrication>()
                .HasMany(e => e.LDSectionchargeSvt)
                .WithOne(e => e.OfNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LDOrdreFabrication>()
                .HasMany(e => e.LDRebut)
                .WithOne(e => e.OfNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LDOutilsVor>()
                .Property(e => e.Of)
                .IsFixedLength();

            modelBuilder.Entity<LDPanne>()
                .Property(e => e.Of)
                .IsFixedLength();

            modelBuilder.Entity<LDPesage>()
                .Property(e => e.Of)
                .IsFixedLength();
            ///////////////////////////////////////////////////////////////////
            // LDPlansFours.
            modelBuilder.Entity<LDPlansFours>()
                .Property(e => e.IdCoulee)
                .IsFixedLength();

            modelBuilder.Entity<LDPlansFours>()
                .Property(e => e.Of)
                .IsFixedLength();
            
            modelBuilder.Entity<LDPlansFours>()
            .HasKey(c => new { c.FourId, c.Position });
            ///////////////////////////////////////////////////////////////////
            // LDPso.
            modelBuilder.Entity<LDPso>()
                .Property(e => e.Coulee)
                .IsFixedLength();

            modelBuilder.Entity<LDPso>()
                .Property(e => e.Of)
                .IsFixedLength();

            modelBuilder.Entity<LDPso>()
                .Property(e => e.CoteBloomingHauteur)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDPso>()
                .Property(e => e.CoteBloomingLargeur)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDPso>()
                .Property(e => e.CoteCage900Hauteur)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDPso>()
                .Property(e => e.CoteCage900Largeur)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDPso>()
                .Property(e => e.CoteCage900Epaulement1)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDPso>()
                .Property(e => e.CoteCage900Epaulement2)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDPso>()
                .Property(e => e.ConsigneScarfing)
                .IsFixedLength();

            modelBuilder.Entity<LDPso>()
                .Property(e => e.LgDeveloppee)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LDPso>()
                .Property(e => e.Densite)
                .HasPrecision(5, 3);

            modelBuilder.Entity<LDPso>()
                .Property(e => e.PoidsChuteTete)
                .HasPrecision(7, 3);

            modelBuilder.Entity<LDPso>()
                .Property(e => e.PoidsChutePied)
                .HasPrecision(7, 3);

            modelBuilder.Entity<LDPso>()
                .Property(e => e.PoidsEboutagePied)
                .HasPrecision(7, 3);

            modelBuilder.Entity<LDPso>()
                .Property(e => e.PoidsEboutageTete)
                .HasPrecision(7, 3);

            modelBuilder.Entity<LDPso>()
                .HasMany(e => e.LDDefaut)
                .WithOne(e => e.LDPso)
                .HasForeignKey(e => new { e.Coulee, e.NumeroLingot })
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LDPso>()
                .HasMany(e => e.LDStockPso)
                .WithOne(e => e.LDPso)
                .HasForeignKey(e => new { e.IdCoulee, e.NumeroLingot })
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LDPso>()
                .HasMany(e => e.LDSousProduits)
                .WithOne(e => e.LDPso)
                .HasForeignKey(e => new { e.Coulee, e.NumeroLingot })
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LDPso>()
            .HasKey(c => new { c.Coulee, c.NumeroLingot });
            ///////////////////////////////////////////////////////////////////
            // LDRoles
            modelBuilder.Entity<LDRoles>()
            .HasKey(c => new { c.Utilisateur, c.TransactionCode });
            ///////////////////////////////////////////////////////////////////
            // LDPsoComplement.
            modelBuilder.Entity<LDPsoComplement>()
                .Property(e => e.Coulee)
                .IsFixedLength();

            modelBuilder.Entity<LDPsoComplement>()
                .Property(e => e.Of)
                .IsFixedLength();

            modelBuilder.Entity<LDPsoComplement>()
                .Property(e => e.TypePso)
                .IsFixedLength();

            modelBuilder.Entity<LDPsoComplement>()
                .Property(e => e.LgTheorique1500T)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDPsoComplement>()
                .Property(e => e.LgTheoriqueCage900)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LDPsoComplement>()
            .HasKey(c => new { c.Coulee, c.NumeroLingot});
            ///////////////////////////////////////////////////////////////////
            // LDRebut.
            modelBuilder.Entity<LDRebut>()
                .Property(e => e.Of)
                .IsFixedLength();

            modelBuilder.Entity<LDRebut>()
            .HasKey(c => new { c.Of, c.RangLingotPassageAuLaminoir, c.DateRebut });
            ///////////////////////////////////////////////////////////////////
            // LDSectionchargeChutage
            modelBuilder.Entity<LDSectionchargeChutage>()
                .Property(e => e.Of)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeChutage>()
                .Property(e => e.CodeOperation)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeChutage>()
                .Property(e => e.RangOperation)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeChutage>()
                .Property(e => e.Destination)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeChutage>()
                .Property(e => e.ChutageTete)
                .HasPrecision(3, 2);

            modelBuilder.Entity<LDSectionchargeChutage>()
                .Property(e => e.ChutagePied)
                .HasPrecision(3, 2);

            modelBuilder.Entity<LDSectionchargeChutage>()
            .HasKey(c => new { c.Of, c.CodeOperation });
            ///////////////////////////////////////////////////////////////////
            // LDSectionchargeDecoupe
            modelBuilder.Entity<LDSectionchargeDecoupe>()
                .Property(e => e.Of)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeDecoupe>()
                .Property(e => e.CodeOperation)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeDecoupe>()
                .Property(e => e.RangOperation)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeDecoupe>()
                .Property(e => e.LongueurMoyenne)
                .HasPrecision(5, 3);

            modelBuilder.Entity<LDSectionchargeDecoupe>()
                .Property(e => e.OutilDeDecoupe)
                .IsFixedLength();
            
            modelBuilder.Entity<LDSectionchargeDecoupe>()
            .HasKey(c => new { c.Of, c.CodeOperation });
            ///////////////////////////////////////////////////////////////////
            // LDSectionchargeLingot.
            modelBuilder.Entity<LDSectionchargeLingot>()
                .Property(e => e.Of)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeLingot>()
                .Property(e => e.CodeOperation)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeLingot>()
                .Property(e => e.RangOperation)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeLingot>()
                .Property(e => e.ProfileLamine)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeLingot>()
                .Property(e => e.SectionLaminage)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDSectionchargeLingot>()
                .Property(e => e.ToleranceMaxSection)
                .HasPrecision(2, 1);

            modelBuilder.Entity<LDSectionchargeLingot>()
                .Property(e => e.ToleranceMinSection)
                .HasPrecision(2, 1);

            modelBuilder.Entity<LDSectionchargeLingot>()
                .Property(e => e.EpaisseurEnLaminage)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDSectionchargeLingot>()
                .Property(e => e.ToleranceMaxEpaisseur)
                .HasPrecision(2, 1);

            modelBuilder.Entity<LDSectionchargeLingot>()
                .Property(e => e.ToleranceMinEpaisseur)
                .HasPrecision(2, 1);

            modelBuilder.Entity<LDSectionchargeLingot>()
                .Property(e => e.PriseDeFerHauteur)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDSectionchargeLingot>()
                .Property(e => e.PriseDeFerEpaisseur)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDSectionchargeLingot>()
                .Property(e => e.PriseDeFerHauteurGpao)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LDSectionchargeLingot>()
                .Property(e => e.PriseDeFerEpaisseurGpao)
                .HasPrecision(4, 1);
            
            modelBuilder.Entity<LDSectionchargeLingot>()
            .HasKey(c => new { c.Of, c.CodeOperation });
            ///////////////////////////////////////////////////////////////////
            // LDSectionchargePits.
            modelBuilder.Entity<LDSectionchargePits>()
                .Property(e => e.Of)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargePits>()
                .Property(e => e.CodeOperation)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargePits>()
                .Property(e => e.RangOperation)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargePits>()
                .Property(e => e.H2coulee)
                .HasPrecision(2, 1);
            
            modelBuilder.Entity<LDSectionchargePits>()
            .HasKey(c => new { c.Of, c.CodeOperation });
            ///////////////////////////////////////////////////////////////////
            // LDSectionchargePoidsmetrique.
            modelBuilder.Entity<LDSectionchargePoidsmetrique>()
                .Property(e => e.Of)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargePoidsmetrique>()
                .Property(e => e.CodeOperation)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargePoidsmetrique>()
                .Property(e => e.RangOperation)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargePoidsmetrique>()
            .HasKey(c => new { c.Of, c.CodeOperation });
            ///////////////////////////////////////////////////////////////////
            // LDSectionchargeRefroidissoirs.
            modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
                .Property(e => e.Of)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
                .Property(e => e.CodeOperation)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
                .Property(e => e.RangOperation)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
                .Property(e => e.RefroidissementBloom)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
                .Property(e => e.Oforigin)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
                .Property(e => e.Ofdestination)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
                .Property(e => e.Ofinterne)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
                .Property(e => e.GazScarfing)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
                .Property(e => e.OxygeneSuperieur)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
                .Property(e => e.OxygeneInferieur)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
                .Property(e => e.OxygeneLatent)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
                .Property(e => e.VitesseV1)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
                .Property(e => e.VitesseV2)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
                .Property(e => e.VitesseV3)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
                .Property(e => e.LongueurScarfingPied)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
                .Property(e => e.LongueurScarfingTete)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
                .Property(e => e.MiseAuMille)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeRefroidissoirs>()
            .HasKey(c => new { c.Of, c.CodeOperation });
            ///////////////////////////////////////////////////////////////////
            // LDSectionchargeSvt.
            modelBuilder.Entity<LDSectionchargeSvt>()
                .Property(e => e.Of)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeSvt>()
                .Property(e => e.CodeOperation)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeSvt>()
                .Property(e => e.RangOperation)
                .IsFixedLength();

            modelBuilder.Entity<LDSectionchargeSvt>()
            .HasKey(c => new { c.Of, c.CodeOperation });
            ///////////////////////////////////////////////////////////////////
            modelBuilder.Entity<LDSousProduits>()
                .Property(e => e.Coulee)
                .IsFixedLength();

            modelBuilder.Entity<LDSousProduits>()
                .Property(e => e.Longueur)
                .HasPrecision(5, 3);

            modelBuilder.Entity<LDSousProduits>()
                .Property(e => e.LgCage900)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LDSousProduits>()
                .Property(e => e.LgDeveloppe)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LDSousProduits>()
                .Property(e => e.ProfilProduit)
                .IsFixedLength();

            modelBuilder.Entity<LDSousProduits>()
                .Property(e => e.PoidsEboutagePied)
                .HasPrecision(7, 3);

            modelBuilder.Entity<LDSousProduits>()
                .Property(e => e.PoidsEboutageTete)
                .HasPrecision(7, 3);

            modelBuilder.Entity<LDStockPso>()
                .Property(e => e.IdCoulee)
                .IsFixedLength();

            modelBuilder.Entity<LPAdressesTemperature>()
                .HasMany(e => e.LDReleveTemperature)
                .WithOne(e => e.AdressesTemperature)
                .HasForeignKey(e => e.AdressesTemperatureId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LPAnomalies>()
                .HasMany(e => e.LDAnomalies)
                .WithOne(e => e.IdNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull);

            ///////////////////////////////////////////////////////////////////
            // LPArret
            modelBuilder.Entity<LPArret>()
                .Property(e => e.Code)
                .IsFixedLength();
            ///////////////////////////////////////////////////////////////////
            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPmontage)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure1)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure2)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure3)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure4)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure5)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure6)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure7)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure8)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure9)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure10)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure11)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure12)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure13)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure14)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure15)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure16)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure17)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure18)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure19)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure20)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure21)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure22)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure23)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure24)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure25)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure26)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure27)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure28)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure29)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure30)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure31)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure32)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure33)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure34)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure35)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure36)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure37)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure38)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure39)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure40)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure41)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure42)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure43)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure44)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure45)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure46)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure47)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure48)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure49)
                .IsUnicode(false);

            modelBuilder.Entity<LPBloomingProg>()
                .Property(e => e.BloPcannelure50)
                .IsUnicode(false);
            ///////////////////////////////////////////////////////////////////
            // LPBloomingProgTmp.
            modelBuilder.Entity<LPBloomingProgTmp>()
                .HasNoKey();
            ///////////////////////////////////////////////////////////////////
            
            modelBuilder.Entity<LPCellulesMesureLongueur>()
                .Property(e => e.Longueur)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LPConsignesDegazageDetail>()
                .Property(e => e.SectionMax)
                .HasPrecision(4, 1);
            ///////////////////////////////////////////////////////////////////
            // LPConsignesChutage
            modelBuilder.Entity<LPConsignesChutage>()
                .HasKey(c => new { c.Section, c.Consignes, c.CodeConsigne });
            ///////////////////////////////////////////////////////////////////
            // LPConsignesCodeoutilCoupe
            modelBuilder.Entity<LPConsignesCodeoutilCoupe>()
                .HasKey(c => new { c.Section, c.Consignes, c.CodeConsigne });
            ///////////////////////////////////////////////////////////////////
            ///// LPConsignesCodeoutilCoupe
            modelBuilder.Entity<LPConsignesDecoupe>()
                .HasKey(c => new { c.Section, c.Consignes, c.CodeConsigne });
            ///////////////////////////////////////////////////////////////////
            modelBuilder.Entity<LPConsignesDegazageDetail>()
                .Property(e => e.SectionMin)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LPConsignesDegazageDetail>()
                .Property(e => e.Refroidissement)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LPConsignesDegazageDetail>()
                .Property(e => e.H21)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LPConsignesDegazageDetail>()
                .Property(e => e.H22)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LPConsignesDegazageDetail>()
                .Property(e => e.H23)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LPConsignesDegazageDetail>()
                .Property(e => e.H24)
                .HasPrecision(4, 2);


            ///////////////////////////////////////////////////////////////////
            ///// LPConsignesLingot.
            modelBuilder.Entity<LPConsignesLingot>()
                .HasKey(c => new { c.Section, c.Consignes, c.CodeConsigne });
            ///////////////////////////////////////////////////////////////////
            //////// LPConsignesMarquage.
            modelBuilder.Entity<LPConsignesMarquage>()
                .HasKey(c => new { c.Section, c.Consignes, c.CodeConsigne });
            ///////////////////////////////////////////////////////////////////
            //////// LPConsignesPits.
            modelBuilder.Entity<LPConsignesPits>()
                .HasKey(c => new { c.Section, c.Consignes, c.CodeConsigne });
            ///////////////////////////////////////////////////////////////////
            /////////// LPConsignesPoidsmetrique.
            modelBuilder.Entity<LPConsignesPoidsmetrique>()
                .HasKey(c => new { c.Section, c.Consignes, c.CodeConsigne });
            ///////////////////////////////////////////////////////////////////
            ////////////// LPConsignesRefroidissement.
            modelBuilder.Entity<LPConsignesRefroidissement>()
                .Property(e => e.Code)
                .IsFixedLength();
            ///////////////////////////////////////////////////////////////////
            ////////////// LPConsignesRefroidissoirs.
            modelBuilder.Entity<LPConsignesRefroidissoirs>()
                .HasKey(c => new { c.Section, c.Consignes, c.CodeConsigne });
            ///////////////////////////////////////////////////////////////////

            modelBuilder.Entity<LPConsignesScarfing>()
                .Property(e => e.Code)
                .IsFixedLength();

            modelBuilder.Entity<LPConsignesScarfing>()
                .Property(e => e.TypeGaz)
                .IsFixedLength();

            modelBuilder.Entity<LPConsignesScarfing>()
                .Property(e => e.Pression1)
                .HasPrecision(2, 1);

            modelBuilder.Entity<LPConsignesScarfing>()
                .Property(e => e.Pression2)
                .HasPrecision(2, 1);

            modelBuilder.Entity<LPConsignesScarfing>()
                .Property(e => e.Pression3)
                .HasPrecision(2, 1);
            ///////////////////////////////////////////////////////////////////
            // LPConsignesSmq.
            modelBuilder.Entity<LPConsignesSmq>()
                .Property(e => e.Code)
                .IsFixedLength();
            ///////////////////////////////////////////////////////////////////
            // LPDelaisLivraison.
            modelBuilder.Entity<LPDelaisLivraison>()
                .Property(e => e.Lingot)
                .HasPrecision(2, 1);

            modelBuilder.Entity<LPDelaisLivraison>()
            .HasKey(c => new { c.Code, c.Lingot});
            ///////////////////////////////////////////////////////////////////

            modelBuilder.Entity<LPJalonActiviteProfil>()
                .Property(e => e.AffichageIhm)
                .IsFixedLength();

            modelBuilder.Entity<LPMontageSectionMam>()
                .Property(e => e.RayonChutage)
                .HasPrecision(3, 2);

            modelBuilder.Entity<LPPriseDeFer>()
                .Property(e => e.TypeProfil)
                .IsFixedLength();

            modelBuilder.Entity<LPProfilProduit>()
                .Property(e => e.Id)
                .IsFixedLength();

            modelBuilder.Entity<LPProfilProduit>()
                .HasMany(e => e.LDOrdreFabrication)
                .WithOne(e => e.ProfilProduitNavigation)
                .HasForeignKey(e => e.ProfilProduit)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LPProgBillette>()
                .Property(e => e.Section)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LPProgBillette>()
                .Property(e => e.Largeur)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LPProgBillette>()
                .Property(e => e.CoteBouchon)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LPProgBillette>()
                .Property(e => e.CalibrageOvale)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LPProgBillette>()
                .Property(e => e.CalibrageRond)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LPProgBillette>()
                .Property(e => e.SectionMin)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LPProgBillette>()
                .Property(e => e.SectionMax)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LPProgBillette>()
                .Property(e => e.PriseDeFerHauteur)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LPProgBillette>()
                .Property(e => e.PriseDeFerLargeur)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LPPso>()
                .Property(e => e.CodePso)
                .IsFixedLength();
            ///////////////////////////////////////////////////////////////////
            // LPRepereAutoLingot.
            modelBuilder.Entity<LPRepereAutoLingot>()
                .Property(e => e.Lingot)
                .IsFixedLength();

            modelBuilder.Entity<LPRepereAutoLingot>()
                .Property(e => e.Reperage)
                .IsFixedLength();

            modelBuilder.Entity<LPRepereAutoLingot>()
                .HasKey(c => new { c.AnomalieCop, c.Lingot });
            ///////////////////////////////////////////////////////////////////
            modelBuilder.Entity<LPTextOperations>()
                .Property(e => e.CodeOperation)
                .IsFixedLength();

            modelBuilder.Entity<LPTextOperations>()
                .HasMany(e => e.LDSectionchargeChutage)
                .WithOne(e => e.CodeOperationNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LPTextOperations>()
                .HasMany(e => e.LDSectionchargeDecoupe)
                .WithOne(e => e.CodeOperationNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LPTextOperations>()
                .HasMany(e => e.LDSectionchargeLingot)
                .WithOne(e => e.CodeOperationNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LPTextOperations>()
                .HasMany(e => e.LDSectionchargePits)
                .WithOne(e => e.CodeOperationNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LPTextOperations>()
                .HasMany(e => e.LDSectionchargePoidsmetrique)
                .WithOne(e => e.CodeOperationNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LPTextOperations>()
                .HasMany(e => e.LDSectionchargeRefroidissoirs)
                .WithOne(e => e.CodeOperationNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LPTextOperations>()
                .HasMany(e => e.LDSectionchargeSvt)
                .WithOne(e => e.CodeOperationNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LPTypeConsigne>()
                .HasMany(e => e.LPConsignesChutage)
                .WithOne(e => e.ConsignesNavigation)
                .HasForeignKey(e => e.Consignes)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LPTypeConsigne>()
                .HasMany(e => e.LPConsignesCodeoutilCoupe)
                .WithOne(e => e.ConsignesNavigation)
                .HasForeignKey(e => e.Consignes)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LPTypeConsigne>()
                .HasMany(e => e.LPConsignesDecoupe)
                .WithOne(e => e.ConsignesNavigation)
                .HasForeignKey(e => e.Consignes)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LPTypeConsigne>()
                .HasMany(e => e.LPConsignesLingot)
                .WithOne(e => e.ConsignesNavigation)
                .HasForeignKey(e => e.Consignes)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LPTypeConsigne>()
                .HasMany(e => e.LPConsignesMarquage)
                .WithOne(e => e.ConsignesNavigation)
                .HasForeignKey(e => e.Consignes)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LPTypeConsigne>()
                .HasMany(e => e.LPConsignesPits)
                .WithOne(e => e.ConsignesNavigation)
                .HasForeignKey(e => e.Consignes)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LPTypeConsigne>()
                .HasMany(e => e.LPConsignesPoidsmetrique)
                .WithOne(e => e.ConsignesNavigation)
                .HasForeignKey(e => e.Consignes)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LPTypeConsigne>()
                .HasMany(e => e.LPConsignesRefroidissoirs)
                .WithOne(e => e.ConsignesNavigation)
                .HasForeignKey(e => e.Consignes)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<LPZoneStockLaminoir>()
                .HasMany(e => e.LPLieuxStockLaminoir)
                .WithOne(e => e.IdzoneNavigation)
                .HasForeignKey(e => e.Idzone);

            modelBuilder.Entity<LSBlooming>()
                .Property(e => e.Section)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LSBlooming>()
                .Property(e => e.Poids)
                .HasPrecision(10, 3);

            modelBuilder.Entity<LSBlooming>()
                .Property(e => e.Scarfing)
                .IsFixedLength();

            modelBuilder.Entity<LSOptiLgBarre>()
                .Property(e => e.PositionButee)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LSOptiLgBarre>()
                .Property(e => e.PositionScieFixe)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LSOptiLgBarre>()
                .Property(e => e.PositionScieMobile)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LSOptiLgBarre>()
                .Property(e => e.LgSecurite)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LSOptiLgBarre>()
                .Property(e => e.LgBrCourte)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LSOptiLgBarre>()
                .Property(e => e.LgChutage)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LSOptiLgBarre>()
                .Property(e => e.LgTot)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LSOptiLgBarre>()
                .Property(e => e.LgCoupe)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LSOptiLgBarre>()
                .Property(e => e.LgBrMini)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LSOptiLgBarre>()
                .Property(e => e.LgOpti)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LSOptiLgBarre>()
                .Property(e => e.LgBrMaxi)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LSOptiLgBarre>()
                .Property(e => e.LgRestante)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LSOptiLgBarre>()
                .Property(e => e.LgUtil)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LSRapportSyntheseMensuelle>()
                .Property(e => e.LabelNom)
                .IsUnicode(false);

            modelBuilder.Entity<LSRapportSyntheseMensuelle>()
                .Property(e => e.NomCol)
                .IsUnicode(false);

            modelBuilder.Entity<LSRapportSyntheseMensuelle>()
                .Property(e => e.LabelDate)
                .IsUnicode(false);
            ///////////////////////////////////////////////////////////////////
            // LD1500tCamera.
            modelBuilder.Entity<LD1500tCamera>()
                .Property(e => e.Of)
                .IsFixedLength();

            modelBuilder.Entity<LD1500tCamera>()
                .Property(e => e.VideoCamera1)
                .IsFixedLength();

            modelBuilder.Entity<LD1500tCamera>()
                .Property(e => e.VideoCamera2)
                .IsFixedLength();

            modelBuilder.Entity<LD1500tCamera>()
                .HasNoKey();
            ///////////////////////////////////////////////////////////////////
            modelBuilder.Entity<LPBloomingProgTmp>()
                .Property(e => e.BloPmontage)
                .IsUnicode(false);
            ///////////////////////////////////////////////////////////////////
            // LSBilanPitsCoulee
            modelBuilder.Entity<LSBilanPitsCoulee>()
                .Property(e => e.Poste)
                .IsFixedLength();

            modelBuilder.Entity<LSBilanPitsCoulee>()
                .Property(e => e.Coulee)
                .IsFixedLength();

            modelBuilder.Entity<LSBilanPitsCoulee>()
                .Property(e => e.RetardLivraison)
                .IsFixedLength();

            modelBuilder.Entity<LSBilanPitsCoulee>()
                .Property(e => e.AvecCop)
                .IsFixedLength();

            modelBuilder.Entity<LSBilanPitsCoulee>()
                .Property(e => e.GrosFour)
                .IsFixedLength();

            modelBuilder.Entity<LSBilanPitsCoulee>()
                .Property(e => e.TypeLingot)
                .IsFixedLength();

            modelBuilder.Entity<LSBilanPitsCoulee>()
                .HasNoKey();
            ///////////////////////////////////////////////////////////////////
            // LSProductionLsi.
            modelBuilder.Entity<LSProductionLsi>()
                .Property(e => e.PoidsChauffe)
                .HasPrecision(8, 3);

            modelBuilder.Entity<LSProductionLsi>()
                .Property(e => e.PoidsLamine)
                .HasPrecision(8, 3);

            modelBuilder.Entity<LSProductionLsi>()
                .Property(e => e.PoidsRebute)
                .HasPrecision(8, 3);

            modelBuilder.Entity<LSProductionLsi>()
                .Property(e => e.PoidsEvc)
                .HasPrecision(8, 3);

            modelBuilder.Entity<LSProductionLsi>()
                .Property(e => e.DiametreProduit)
                .HasPrecision(4, 1);

            modelBuilder.Entity<LSProductionLsi>()
                .Property(e => e.PoidsDemiProduitUnitaire)
                .HasPrecision(8, 3);

            modelBuilder.Entity<LSProductionLsi>()
                .Property(e => e.PoidsPrevuDemiProduit)
                .HasPrecision(8, 3);

            modelBuilder.Entity<LSProductionLsi>()
                .Property(e => e.Thlamine)
                .HasPrecision(8, 3);

            modelBuilder.Entity<LSProductionLsi>()
                .HasNoKey();
            ///////////////////////////////////////////////////////////////////
            // LsiBilanCoulee.
            modelBuilder.Entity<LsiBilanCoulee>()
                .Property(e => e.Poste)
                .IsFixedLength();

            modelBuilder.Entity<LsiBilanCoulee>()
                .Property(e => e.Coulee)
                .IsFixedLength();

            modelBuilder.Entity<LsiBilanCoulee>()
                .Property(e => e.RetardLivraison)
                .IsFixedLength();

            modelBuilder.Entity<LsiBilanCoulee>()
                .Property(e => e.AvecCop)
                .IsFixedLength();

            modelBuilder.Entity<LsiBilanCoulee>()
                .Property(e => e.GrosFour)
                .IsFixedLength();

            modelBuilder.Entity<LsiBilanCoulee>()
                .HasNoKey();
        }
    }
}
