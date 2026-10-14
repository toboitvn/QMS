using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels2
{
    public partial class QMSContext : DbContext
    {
        public QMSContext()
        {
        }

        public QMSContext(DbContextOptions<QMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<QmsCanLamSang> QmsCanLamSang { get; set; }
        public virtual DbSet<QmsChoKham> QmsChoKham { get; set; }
        public virtual DbSet<QmsGoiLoa> QmsGoiLoa { get; set; }
        public virtual DbSet<QmsLoai> QmsLoai { get; set; }
        public virtual DbSet<QmsPhongBan> QmsPhongBan { get; set; }
        public virtual DbSet<QmsSoKham> QmsSoKham { get; set; }
        public virtual DbSet<QmsThoigianCho> QmsThoigianCho { get; set; }
        public virtual DbSet<SysWebServicePath> SysWebServicePath { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=14.224.188.66;Initial Catalog=HISLINK_SONTAY;Persist Security Info=True;User ID=sa;Password=Cntt@@");
                //optionsBuilder.UseSqlServer("Data Source=192.168.1.254;Initial Catalog=QMS;Persist Security Info=True;User ID=sa;Password=Cntt@@");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QmsCanLamSang>(entity =>
            {
                entity.ToTable("QMS_CanLamSang");

                entity.Property(e => e.CoKetqua)
                    .HasColumnName("co_ketqua")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaBenhVien)
                    .IsRequired()
                    .HasColumnName("Ma_BenhVien")
                    .HasMaxLength(10);

                entity.Property(e => e.MaChucnang)
                    .HasColumnName("Ma_chucnang")
                    .HasMaxLength(10);

                entity.Property(e => e.MaCoSo)
                    .IsRequired()
                    .HasColumnName("Ma_CoSo")
                    .HasMaxLength(10);

                entity.Property(e => e.MaKhoa).HasMaxLength(10);

                entity.Property(e => e.MaPhieu)
                    .HasColumnName("ma_phieu")
                    .HasMaxLength(20);

                entity.Property(e => e.MaPhong)
                    .IsRequired()
                    .HasColumnName("Ma_Phong")
                    .HasMaxLength(10);

                entity.Property(e => e.NgayTao)
                    .HasColumnName("Ngay_Tao")
                    .HasColumnType("datetime");

                entity.Property(e => e.PatientCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SoKham).HasColumnName("So_Kham");

                entity.Property(e => e.SoPhong).HasMaxLength(10);

                entity.Property(e => e.TenBenhnhan)
                    .IsRequired()
                    .HasColumnName("Ten_benhnhan")
                    .HasMaxLength(100);

                entity.Property(e => e.TrangThai)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0: Nhỡ;1: Vừa tạo;2=Đang được gọi;3=Đã thực hiện xong");

                entity.Property(e => e.UuTien).HasColumnName("Uu_Tien");
            });

            modelBuilder.Entity<QmsChoKham>(entity =>
            {
                entity.HasKey(e => e.RegId);

                entity.ToTable("QMS_ChoKham");

                entity.Property(e => e.RegId)
                    .HasColumnName("Reg_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.DoctorAssignId).HasColumnName("DoctorAssign_ID");

                entity.Property(e => e.ExamId).HasColumnName("Exam_ID");

                entity.Property(e => e.HienThi)
                    .HasColumnName("Hien_Thi")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InputDate)
                    .HasColumnName("Input_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaCoSo)
                    .HasColumnName("Ma_CoSo")
                    .HasMaxLength(10);

                entity.Property(e => e.MaKhoaThien)
                    .HasColumnName("MA_KHOA_THIEN")
                    .HasMaxLength(10);

                entity.Property(e => e.MaPhongStt)
                    .HasColumnName("MA_PHONG_STT")
                    .HasMaxLength(20);

                entity.Property(e => e.PatientCode)
                    .HasColumnName("Patient_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.PatientName).HasMaxLength(100);

                entity.Property(e => e.QmsHienThi).HasColumnName("QMS_HienThi");

                entity.Property(e => e.RegDate)
                    .HasColumnName("Reg_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SoKham).HasColumnName("So_Kham");

                entity.Property(e => e.UuTien).HasColumnName("uu_tien");
            });

            modelBuilder.Entity<QmsGoiLoa>(entity =>
            {
                entity.ToTable("QMS_GoiLoa");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoaGoi)
                    .HasColumnName("Loa_Goi")
                    .HasMaxLength(20);

                entity.Property(e => e.MaKhoa)
                    .HasColumnName("Ma_Khoa")
                    .HasMaxLength(10);

                entity.Property(e => e.MayGoi)
                    .HasColumnName("May_Goi")
                    .HasMaxLength(20);

                entity.Property(e => e.MayTao)
                    .HasColumnName("May_Tao")
                    .HasMaxLength(20);

                entity.Property(e => e.NgayTao)
                    .HasColumnName("Ngay_Tao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NguoiTao)
                    .HasColumnName("Nguoi_Tao")
                    .HasMaxLength(20);

                entity.Property(e => e.NoiDung).HasMaxLength(500);

                entity.Property(e => e.QuayGoi)
                    .HasColumnName("Quay_Goi")
                    .HasMaxLength(50);

                entity.Property(e => e.SoKham)
                    .HasColumnName("So_Kham")
                    .HasMaxLength(20);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QmsLoai>(entity =>
            {
                entity.ToTable("QMS_LOAI");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GhiChu)
                    .HasColumnName("ghi_chu")
                    .HasMaxLength(50);

                entity.Property(e => e.LoaiQms)
                    .IsRequired()
                    .HasColumnName("loai_qms")
                    .HasMaxLength(20);

                entity.Property(e => e.MaDoituongKcb)
                    .HasColumnName("ma_doituongKcb")
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('ALL')");

                entity.Property(e => e.MaKhoa)
                    .HasColumnName("ma_khoa")
                    .HasMaxLength(10);

                entity.Property(e => e.NhomQms)
                    .IsRequired()
                    .HasColumnName("nhom_qms")
                    .HasMaxLength(20);

                entity.Property(e => e.SttHienthi).HasColumnName("stt_hienthi");

                entity.Property(e => e.SttUutien).HasColumnName("stt_uutien");

                entity.Property(e => e.TenQms)
                    .IsRequired()
                    .HasColumnName("ten_qms")
                    .HasMaxLength(50);

                entity.Property(e => e.Trangthai)
                    .HasColumnName("trangthai")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QmsPhongBan>(entity =>
            {
                entity.HasKey(e => e.IdPhong);

                entity.ToTable("QMS_PhongBan");

                entity.Property(e => e.IdPhong).HasColumnName("Id_Phong");

                entity.Property(e => e.HienThi).HasColumnName("Hien_Thi");

                entity.Property(e => e.MaChucnang)
                    .HasColumnName("ma_chucnang")
                    .HasMaxLength(10);

                entity.Property(e => e.MaKhoa).HasMaxLength(10);

                entity.Property(e => e.MaPhong)
                    .IsRequired()
                    .HasColumnName("Ma_Phong")
                    .HasMaxLength(10);

                entity.Property(e => e.Motathem).HasMaxLength(50);

                entity.Property(e => e.SoPhong).HasMaxLength(20);

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TenBs)
                    .HasColumnName("Ten_Bs")
                    .HasMaxLength(100);

                entity.Property(e => e.TenPhong)
                    .IsRequired()
                    .HasColumnName("Ten_Phong")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<QmsSoKham>(entity =>
            {
                entity.ToTable("QMS_So_Kham");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.IpMayTao)
                    .HasColumnName("Ip_May_Tao")
                    .HasMaxLength(50);

                entity.Property(e => e.IsDaXoa)
                    .HasColumnName("Is_DaXoa")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUuTien)
                    .HasColumnName("Is_UuTien")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LoaiQms)
                    .HasColumnName("loai_qms")
                    .HasMaxLength(20);

                entity.Property(e => e.MaBenhVien)
                    .HasColumnName("Ma_BenhVien")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'NTTW')");

                entity.Property(e => e.MaCoSo)
                    .HasColumnName("Ma_CoSo")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'BV02')");

                entity.Property(e => e.MaDoituongKcb)
                    .HasColumnName("ma_doituongKcb")
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('ALL')");

                entity.Property(e => e.MaQuay)
                    .HasColumnName("Ma_Quay")
                    .HasMaxLength(50);

                entity.Property(e => e.MaTram)
                    .HasColumnName("Ma_Tram")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'T01')");

                entity.Property(e => e.MayTao)
                    .HasColumnName("May_Tao")
                    .HasMaxLength(50);

                entity.Property(e => e.NgayTao)
                    .HasColumnName("Ngay_Tao")
                    .HasColumnType("datetime");

                entity.Property(e => e.PatientCode)
                    .HasColumnName("Patient_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.SoKham).HasColumnName("So_Kham");

                entity.Property(e => e.SoPhong).HasColumnName("So_Phong");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QmsThoigianCho>(entity =>
            {
                entity.HasKey(e => e.MaLoai);

                entity.ToTable("QMS_THOIGIAN_CHO");

                entity.Property(e => e.MaLoai)
                    .HasColumnName("ma_loai")
                    .HasMaxLength(10);

                entity.Property(e => e.Ghichu)
                    .HasColumnName("ghichu")
                    .HasMaxLength(50);

                entity.Property(e => e.SobanTiepdon).HasColumnName("soban_tiepdon");

                entity.Property(e => e.TenLoai)
                    .IsRequired()
                    .HasColumnName("ten_loai")
                    .HasMaxLength(50);

                entity.Property(e => e.Thoigiancho).HasColumnName("thoigiancho");

                entity.Property(e => e.Trangthai).HasColumnName("trangthai");
            });

            modelBuilder.Entity<SysWebServicePath>(entity =>
            {
                entity.HasKey(e => new { e.WebPathCode, e.MaCoSo })
                    .HasName("PK_Sys_WebPath");

                entity.ToTable("Sys_WebServicePath");

                entity.Property(e => e.WebPathCode)
                    .HasColumnName("WebPath_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaCoSo)
                    .HasColumnName("Ma_CoSo")
                    .HasMaxLength(10);

                entity.Property(e => e.MaKhoaThucHien)
                    .HasColumnName("Ma_KhoaThucHien")
                    .HasMaxLength(10);

                entity.Property(e => e.WebPathName)
                    .IsRequired()
                    .HasColumnName("WebPath_Name")
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
