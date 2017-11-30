﻿namespace SommerhusProjektWebService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SommerhusProjektDBContext : DbContext
    {
        public SommerhusProjektDBContext()
            : base("name=SommerhusProjektDBContext")
        {
            base.Configuration.LazyLoadingEnabled = false;
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<BookingFaktura> BookingFakturas { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<KontaktPerson> KontaktPersons { get; set; }
        public virtual DbSet<Leverance> Leverances { get; set; }
        public virtual DbSet<Leverandør> Leverandør { get; set; }
        public virtual DbSet<Opgaver> Opgavers { get; set; }
        public virtual DbSet<Sommerhus> Sommerhus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingFaktura>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<BookingFaktura>()
                .Property(e => e.KundeNavn)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Navn)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.BookingFakturas)
                .WithOptional(e => e.Customer)
                .HasForeignKey(e => e.Tlf_Nr);

            modelBuilder.Entity<KontaktPerson>()
                .Property(e => e.Navn)
                .IsFixedLength();

            modelBuilder.Entity<KontaktPerson>()
                .HasMany(e => e.Opgavers)
                .WithRequired(e => e.KontaktPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Leverance>()
                .Property(e => e.sommerhusNavn)
                .IsFixedLength();

            modelBuilder.Entity<Leverance>()
                .Property(e => e.LeveringsAddresse)
                .IsFixedLength();

            modelBuilder.Entity<Leverandør>()
                .Property(e => e.Navn)
                .IsFixedLength();

            modelBuilder.Entity<Leverandør>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Leverandør>()
                .HasMany(e => e.Leverances)
                .WithRequired(e => e.Leverandør)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Opgaver>()
                .Property(e => e.sommerhusNavn)
                .IsFixedLength();

            modelBuilder.Entity<Sommerhus>()
                .Property(e => e.sommerhusNavn)
                .IsFixedLength();

            modelBuilder.Entity<Sommerhus>()
                .Property(e => e.by)
                .IsFixedLength();

            modelBuilder.Entity<Sommerhus>()
                .Property(e => e.vejNavn)
                .IsFixedLength();

            modelBuilder.Entity<Sommerhus>()
                .Property(e => e.kommune)
                .IsFixedLength();

            modelBuilder.Entity<Sommerhus>()
                .HasMany(e => e.Leverances)
                .WithRequired(e => e.Sommerhu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sommerhus>()
                .HasMany(e => e.Opgavers)
                .WithRequired(e => e.Sommerhu)
                .WillCascadeOnDelete(false);
        }
    }
}
