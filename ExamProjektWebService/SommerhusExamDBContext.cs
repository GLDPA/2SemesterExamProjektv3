namespace ExamProjektWebService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SommerhusExamDBContext : DbContext
    {
        public SommerhusExamDBContext()
            : base("name=SommerhusExamDBContext")
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
        public virtual DbSet<SommerhusTable> SommerhusTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingFaktura>()
                .Property(e => e.sommerhusNavn)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Navn)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.BookingFakturas)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.Tlf_Nr)
                .WillCascadeOnDelete(false);

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

            modelBuilder.Entity<SommerhusTable>()
                .Property(e => e.sommerhusNavn)
                .IsFixedLength();

            modelBuilder.Entity<SommerhusTable>()
                .Property(e => e.by)
                .IsFixedLength();

            modelBuilder.Entity<SommerhusTable>()
                .Property(e => e.vejNavn)
                .IsFixedLength();

            modelBuilder.Entity<SommerhusTable>()
                .Property(e => e.kommune)
                .IsFixedLength();

            modelBuilder.Entity<SommerhusTable>()
                .HasMany(e => e.BookingFakturas)
                .WithRequired(e => e.SommerhusTable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SommerhusTable>()
                .HasMany(e => e.Leverances)
                .WithRequired(e => e.SommerhusTable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SommerhusTable>()
                .HasMany(e => e.Opgavers)
                .WithRequired(e => e.SommerhusTable)
                .WillCascadeOnDelete(false);
        }
    }
}
