using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PRoject.Data
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=PC")
        {
        }

        public virtual DbSet<Corpus> Corpus { get; set; }
        public virtual DbSet<CPU> CPU { get; set; }
        public virtual DbSet<HDD> HDD { get; set; }
        public virtual DbSet<Motherboald> Motherboald { get; set; }
        public virtual DbSet<PSU> PSU { get; set; }
        public virtual DbSet<RAM> RAM { get; set; }
        public virtual DbSet<SSD> SSD { get; set; }
        public virtual DbSet<System_cold> System_cold { get; set; }
        public virtual DbSet<Videocard> Videocard { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Corpus>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Corpus>()
                .Property(e => e.Photo)
                .IsFixedLength();

            modelBuilder.Entity<CPU>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CPU>()
                .Property(e => e.Photo)
                .IsFixedLength();

            modelBuilder.Entity<HDD>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HDD>()
                .Property(e => e.Memory_count)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HDD>()
                .Property(e => e.Speed_data)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HDD>()
                .Property(e => e.Photo)
                .IsFixedLength();

            modelBuilder.Entity<Motherboald>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Motherboald>()
                .Property(e => e.Max_RAM)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Motherboald>()
                .Property(e => e.Photo)
                .IsFixedLength();

            modelBuilder.Entity<PSU>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PSU>()
                .Property(e => e.Photo)
                .IsFixedLength();

            modelBuilder.Entity<RAM>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RAM>()
                .Property(e => e.Memory_count)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RAM>()
                .Property(e => e.Photo)
                .IsFixedLength();

            modelBuilder.Entity<SSD>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SSD>()
                .Property(e => e.Photo)
                .IsFixedLength();

            modelBuilder.Entity<System_cold>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<System_cold>()
                .Property(e => e.Photo)
                .IsFixedLength();

            modelBuilder.Entity<System_cold>()
                .HasMany(e => e.CPU)
                .WithOptional(e => e.System_cold)
                .HasForeignKey(e => e.ColdId);

            modelBuilder.Entity<Videocard>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Videocard>()
                .Property(e => e.Photo)
                .IsFixedLength();
        }
    }
}
