//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

//namespace VegitableShop.Models
//{
//    public partial class dbVegitableShopContext : DbContext
//    {
//        public dbVegitableShopContext()
//        {
//        }

//        public dbVegitableShopContext(DbContextOptions<dbVegitableShopContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<Role> Roles { get; set; } = null!;
//        public virtual DbSet<TransactStatus> TransactStatuses { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-HM9E0PP; Database=dbVegitableShop; Trusted_Connection=True; MultipleActiveResultSets=true");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Role>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.Description).HasMaxLength(50);

//                entity.Property(e => e.RoleId)
//                    .ValueGeneratedOnAdd()
//                    .HasColumnName("RoleID");

//                entity.Property(e => e.RoleName).HasMaxLength(50);
//            });

//            modelBuilder.Entity<TransactStatus>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("TransactStatus");

//                entity.Property(e => e.Status).HasMaxLength(50);

//                entity.Property(e => e.TransactStatusId)
//                    .ValueGeneratedOnAdd()
//                    .HasColumnName("TransactStatusID")
//                    .HasComment("");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
