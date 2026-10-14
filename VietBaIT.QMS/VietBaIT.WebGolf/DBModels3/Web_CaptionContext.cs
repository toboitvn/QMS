using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels3
{
    public partial class Web_CaptionContext : DbContext
    {
        public Web_CaptionContext()
        {
        }

        public Web_CaptionContext(DbContextOptions<Web_CaptionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LCaption> LCaption { get; set; }
        public virtual DbSet<LTag> LTag { get; set; }
        public virtual DbSet<LUser> LUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=MANHHUNG\\SQLEXPRESS;Initial Catalog=Web_Caption;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LCaption>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("L_Caption");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCaption).HasColumnName("id_caption");

                entity.Property(e => e.TrangThai).HasColumnName("trang_thai");
            });

            modelBuilder.Entity<LTag>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("L_Tag");

                entity.Property(e => e.IdTag).HasColumnName("id_tag");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasColumnName("trang_thai");
            });

            modelBuilder.Entity<LUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("L_User");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
