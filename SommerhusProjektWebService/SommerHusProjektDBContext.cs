namespace SommerhusProjektWebService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SommerHusProjektDBContext : DbContext
    {
        public SommerHusProjektDBContext()
            : base("name=SommerHusProjektDBContext")
        {
        }

        public virtual DbSet<Sommerhus> Sommerhus { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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

            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsFixedLength();

        }
    }
}
