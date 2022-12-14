using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Q593HM_ZH3_Web.Models
{
    public partial class BreadOrderContext : DbContext
    {
        public BreadOrderContext()
        {
        }

        public BreadOrderContext(DbContextOptions<BreadOrderContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bread> Breads { get; set; } = null!;
        public virtual DbSet<Buyer> Buyers { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=leventesofteng.database.windows.net;Initial Catalog=BreadOrder;User ID=levente;Password=softeng0.");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bread>(entity =>
            {
                entity.ToTable("Bread");

                entity.Property(e => e.BreadId).HasColumnName("BreadID");

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.ShortName).HasMaxLength(4);
            });

            modelBuilder.Entity<Buyer>(entity =>
            {
                entity.ToTable("Buyer");

                entity.Property(e => e.BuyerId).HasColumnName("BuyerID");

                entity.Property(e => e.Idnumber)
                    .HasMaxLength(8)
                    .HasColumnName("IDNumber")
                    .IsFixedLength();

                entity.Property(e => e.Name).HasMaxLength(60);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrderSk);

                entity.ToTable("Order");

                entity.Property(e => e.OrderSk).HasColumnName("OrderSK");

                entity.Property(e => e.BreadFk).HasColumnName("BreadFK");

                entity.Property(e => e.BuyerFk).HasColumnName("BuyerFK");

                entity.Property(e => e.Pcs).HasColumnName("PCS");

                entity.HasOne(d => d.BreadFkNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.BreadFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_ToBread");

                entity.HasOne(d => d.BuyerFkNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.BuyerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_ToBuyer");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
