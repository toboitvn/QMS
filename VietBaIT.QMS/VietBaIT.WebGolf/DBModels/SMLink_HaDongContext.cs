using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class SMLink_HaDongContext : DbContext
    {
        public SMLink_HaDongContext()
        {
        }

        public SMLink_HaDongContext(DbContextOptions<SMLink_HaDongContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DMultiReport> DMultiReport { get; set; }
        public virtual DbSet<DMultiReportConfig> DMultiReportConfig { get; set; }
        public virtual DbSet<DMultiReportSheetConfig> DMultiReportSheetConfig { get; set; }
        public virtual DbSet<LAssemblyReport> LAssemblyReport { get; set; }
        public virtual DbSet<LCardTypeList> LCardTypeList { get; set; }
        public virtual DbSet<LCountries> LCountries { get; set; }
        public virtual DbSet<LCountryList> LCountryList { get; set; }
        public virtual DbSet<LCoupon> LCoupon { get; set; }
        public virtual DbSet<LCouponConfig> LCouponConfig { get; set; }
        public virtual DbSet<LDepartments> LDepartments { get; set; }
        public virtual DbSet<LDichVu> LDichVu { get; set; }
        public virtual DbSet<LDinhDanhCaNhan> LDinhDanhCaNhan { get; set; }
        public virtual DbSet<LDrivingFloor> LDrivingFloor { get; set; }
        public virtual DbSet<LDrivingLane> LDrivingLane { get; set; }
        public virtual DbSet<LGeneralList> LGeneralList { get; set; }
        public virtual DbSet<LMemberInfo> LMemberInfo { get; set; }
        public virtual DbSet<LMemberPolicies> LMemberPolicies { get; set; }
        public virtual DbSet<LMemberTypeList> LMemberTypeList { get; set; }
        public virtual DbSet<LMulist> LMulist { get; set; }
        public virtual DbSet<LPaymentMethodList> LPaymentMethodList { get; set; }
        public virtual DbSet<LPlayerDetail> LPlayerDetail { get; set; }
        public virtual DbSet<LPlayerInfo> LPlayerInfo { get; set; }
        public virtual DbSet<LReportConfig> LReportConfig { get; set; }
        public virtual DbSet<LServiceListV2> LServiceListV2 { get; set; }
        public virtual DbSet<LServiceTypeList> LServiceTypeList { get; set; }
        public virtual DbSet<LStaffList> LStaffList { get; set; }
        public virtual DbSet<LStaffType> LStaffType { get; set; }
        public virtual DbSet<LStaffs> LStaffs { get; set; }
        public virtual DbSet<LUidFunction> LUidFunction { get; set; }
        public virtual DbSet<LUser> LUser { get; set; }
        public virtual DbSet<LUserServiceType> LUserServiceType { get; set; }
        public virtual DbSet<SysAdministrator> SysAdministrator { get; set; }
        public virtual DbSet<SysConfigRadio> SysConfigRadio { get; set; }
        public virtual DbSet<SysDelegateUser> SysDelegateUser { get; set; }
        public virtual DbSet<SysFormColor> SysFormColor { get; set; }
        public virtual DbSet<SysFunctions> SysFunctions { get; set; }
        public virtual DbSet<SysGridViewOptions> SysGridViewOptions { get; set; }
        public virtual DbSet<SysGroupRoles> SysGroupRoles { get; set; }
        public virtual DbSet<SysGroupUser> SysGroupUser { get; set; }
        public virtual DbSet<SysGroups> SysGroups { get; set; }
        public virtual DbSet<SysImgAndIcon> SysImgAndIcon { get; set; }
        public virtual DbSet<SysLockObject> SysLockObject { get; set; }
        public virtual DbSet<SysManagementUnit> SysManagementUnit { get; set; }
        public virtual DbSet<SysMessages> SysMessages { get; set; }
        public virtual DbSet<SysMultiLanguage> SysMultiLanguage { get; set; }
        public virtual DbSet<SysRoles> SysRoles { get; set; }
        public virtual DbSet<SysRolesForUsers> SysRolesForUsers { get; set; }
        public virtual DbSet<SysScreen> SysScreen { get; set; }
        public virtual DbSet<SysSecurity> SysSecurity { get; set; }
        public virtual DbSet<SysSystemParameters> SysSystemParameters { get; set; }
        public virtual DbSet<SysToolbarButton> SysToolbarButton { get; set; }
        public virtual DbSet<SysTrace> SysTrace { get; set; }
        public virtual DbSet<SysTrinhky> SysTrinhky { get; set; }
        public virtual DbSet<SysUpdateVersion> SysUpdateVersion { get; set; }
        public virtual DbSet<SysUserPrinter> SysUserPrinter { get; set; }
        public virtual DbSet<SysUsers> SysUsers { get; set; }
        public virtual DbSet<SysVersion> SysVersion { get; set; }
        public virtual DbSet<TBooking> TBooking { get; set; }
        public virtual DbSet<TBookingDetail> TBookingDetail { get; set; }
        public virtual DbSet<TCoupon> TCoupon { get; set; }
        public virtual DbSet<TGolfBag> TGolfBag { get; set; }
        public virtual DbSet<TGolfBagDetail> TGolfBagDetail { get; set; }
        public virtual DbSet<TGolfBagLog> TGolfBagLog { get; set; }
        public virtual DbSet<TLog> TLog { get; set; }
        public virtual DbSet<TPaymentDetail> TPaymentDetail { get; set; }
        public virtual DbSet<VPatientExamSearch> VPatientExamSearch { get; set; }
        public virtual DbSet<VPatientSearch> VPatientSearch { get; set; }
        public virtual DbSet<VinHospitalPatientInfo> VinHospitalPatientInfo { get; set; }
        public virtual DbSet<VpatientInfoSearch> VpatientInfoSearch { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=123.31.17.35;Initial Catalog=SMLink_HaDong;Persist Security Info=True;User ID=sa;Password=Cntt@@");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DMultiReport>(entity =>
            {
                entity.HasKey(e => e.MultiReportId);

                entity.ToTable("D_Multi_Report");

                entity.Property(e => e.MultiReportId).HasColumnName("MultiReport_ID");

                entity.Property(e => e.MultiReportIsAdmin).HasColumnName("MultiReport_IsAdmin");

                entity.Property(e => e.MultiReportName)
                    .HasColumnName("MultiReport_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.MultiReportQueryString)
                    .HasColumnName("MultiReport_Query_String")
                    .HasMaxLength(3000);

                entity.Property(e => e.MultiReportQueryType)
                    .HasColumnName("MultiReport_Query_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MultiReportSequence).HasColumnName("MultiReport_Sequence");

                entity.Property(e => e.MultiReportType)
                    .HasColumnName("MultiReport_Type")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DMultiReportConfig>(entity =>
            {
                entity.HasKey(e => e.MultiReportConfigId);

                entity.ToTable("D_Multi_Report_Config");

                entity.Property(e => e.MultiReportConfigId).HasColumnName("MultiReport_Config_ID");

                entity.Property(e => e.MultiReportConfigExcelColAggregateFunction)
                    .HasColumnName("MultiReport_Config_ExcelColAggregateFunction")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MultiReportConfigExcelColName)
                    .IsRequired()
                    .HasColumnName("MultiReport_Config_ExcelColName")
                    .HasMaxLength(200);

                entity.Property(e => e.MultiReportConfigExcelColNumberFormat)
                    .HasColumnName("MultiReport_Config_ExcelColNumberFormat")
                    .HasMaxLength(50);

                entity.Property(e => e.MultiReportConfigExcelColPosition).HasColumnName("MultiReport_Config_ExcelColPosition");

                entity.Property(e => e.MultiReportConfigExcelColWidth).HasColumnName("MultiReport_Config_ExcelColWidth");

                entity.Property(e => e.MultiReportConfigSqlColName)
                    .IsRequired()
                    .HasColumnName("MultiReport_Config_SqlColName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MultiReportConfigTableIndex).HasColumnName("MultiReport_Config_Table_Index");

                entity.Property(e => e.MultiReportId).HasColumnName("MultiReport_ID");
            });

            modelBuilder.Entity<DMultiReportSheetConfig>(entity =>
            {
                entity.HasKey(e => e.MultiReportSheetConfigId);

                entity.ToTable("D_Multi_Report_Sheet_Config");

                entity.Property(e => e.MultiReportSheetConfigId).HasColumnName("MultiReport_Sheet_Config_ID");

                entity.Property(e => e.HeaderBlankRowCount).HasColumnName("Header_Blank_Row_Count");

                entity.Property(e => e.HeaderTitle)
                    .IsRequired()
                    .HasColumnName("Header_Title")
                    .HasColumnType("ntext");

                entity.Property(e => e.HeaderTitleCellCount).HasColumnName("Header_Title_Cell_Count");

                entity.Property(e => e.MultiReportConfigTableIndex).HasColumnName("MultiReport_Config_Table_Index");

                entity.Property(e => e.MultiReportId).HasColumnName("MultiReport_ID");

                entity.Property(e => e.SheetName)
                    .IsRequired()
                    .HasColumnName("Sheet_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SheetSequence).HasColumnName("Sheet_Sequence");
            });

            modelBuilder.Entity<LAssemblyReport>(entity =>
            {
                entity.HasKey(e => e.AssemblyReportId);

                entity.ToTable("L_Assembly_Report");

                entity.Property(e => e.AssemblyReportId)
                    .HasColumnName("AssemblyReport_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.Desc).HasMaxLength(200);

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasColumnName("Report_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SAssemblyName)
                    .HasColumnName("sAssemblyName")
                    .HasMaxLength(100);

                entity.Property(e => e.SDllname)
                    .HasColumnName("sDLLname")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LCardTypeList>(entity =>
            {
                entity.HasKey(e => e.CardTypeId)
                    .HasName("PK_L_CardList");

                entity.ToTable("L_CardTypeList");

                entity.Property(e => e.CardTypeId).HasColumnName("CardType_ID");

                entity.Property(e => e.CardTypeName)
                    .IsRequired()
                    .HasColumnName("CardType_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Desc).HasMaxLength(100);

                entity.Property(e => e.MemberTypeId).HasColumnName("MemberType_ID");
            });

            modelBuilder.Entity<LCountries>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("L_Countries");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("Country_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("Country_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CountryNameEn)
                    .HasColumnName("Country_Name_En")
                    .HasMaxLength(255);

                entity.Property(e => e.CountrySequence).HasColumnName("Country_Sequence");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Nationality).HasMaxLength(100);
            });

            modelBuilder.Entity<LCountryList>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("L_CountryList");

                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_ID")
                    .HasMaxLength(3);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("Country_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Desc).HasMaxLength(100);

                entity.Property(e => e.IntStt).HasColumnName("intSTT");
            });

            modelBuilder.Entity<LCoupon>(entity =>
            {
                entity.HasKey(e => e.CouponId);

                entity.ToTable("L_Coupon");

                entity.Property(e => e.CouponId).HasColumnName("Coupon_ID");

                entity.Property(e => e.CouponEndIdx).HasColumnName("Coupon_End_Idx");

                entity.Property(e => e.CouponFullName)
                    .HasColumnName("Coupon_FullName")
                    .HasMaxLength(100);

                entity.Property(e => e.CouponNote)
                    .HasColumnName("Coupon_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.CouponPhone)
                    .HasColumnName("Coupon_Phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CouponPrefix)
                    .IsRequired()
                    .HasColumnName("Coupon_Prefix")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CouponStartIdx).HasColumnName("Coupon_Start_Idx");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemberId).HasColumnName("Member_ID");

                entity.Property(e => e.PlayerId).HasColumnName("Player_ID");

                entity.Property(e => e.SaleBy).HasColumnName("Sale_By");

                entity.Property(e => e.SaleDate)
                    .HasColumnName("Sale_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartDate)
                    .HasColumnName("Start_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<LCouponConfig>(entity =>
            {
                entity.HasKey(e => new { e.CouponTypeCode, e.ServiceId });

                entity.ToTable("L_Coupon_Config");

                entity.Property(e => e.CouponTypeCode)
                    .HasColumnName("Coupon_Type_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId)
                    .HasColumnName("Service_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CouponProportion)
                    .HasColumnName("Coupon_Proportion")
                    .HasColumnType("numeric(5, 3)");
            });

            modelBuilder.Entity<LDepartments>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("L_Departments");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.DepartmentCode)
                    .HasColumnName("Department_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasColumnName("Department_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DeptFee)
                    .HasColumnName("Dept_Fee")
                    .HasColumnType("money");

                entity.Property(e => e.DeptType).HasColumnName("Dept_Type");

                entity.Property(e => e.HienThi)
                    .HasColumnName("Hien_Thi")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.KhoaCapcuu).HasColumnName("KHOA_CAPCUU");

                entity.Property(e => e.KieuKphong)
                    .HasColumnName("KIEU_KPHONG")
                    .HasMaxLength(50);

                entity.Property(e => e.LoaiKhoa)
                    .HasColumnName("LOAI_KHOA")
                    .HasMaxLength(50);

                entity.Property(e => e.LoaiTamUng)
                    .HasColumnName("LOAI_TAM_UNG")
                    .HasMaxLength(50);

                entity.Property(e => e.MaPhongStt)
                    .HasColumnName("MA_PHONG_STT")
                    .HasMaxLength(50);

                entity.Property(e => e.NgaySua)
                    .HasColumnName("NGAY_SUA")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayTao)
                    .HasColumnName("NGAY_TAO")
                    .HasColumnType("datetime");

                entity.Property(e => e.NguoiSua)
                    .HasColumnName("NGUOI_SUA")
                    .HasMaxLength(50);

                entity.Property(e => e.NguoiTao)
                    .HasColumnName("NGUOI_TAO")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentId)
                    .HasColumnName("Parent_ID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PhongThien)
                    .HasColumnName("PHONG_THIEN")
                    .HasMaxLength(100);

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(255);

                entity.Property(e => e.TienTamUng)
                    .HasColumnName("TIEN_TAM_UNG")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");
            });

            modelBuilder.Entity<LDichVu>(entity =>
            {
                entity.ToTable("L_DichVu");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DonGia)
                    .HasColumnName("don_gia")
                    .HasColumnType("money");

                entity.Property(e => e.IdDichvu)
                    .IsRequired()
                    .HasColumnName("id_dichvu")
                    .HasMaxLength(30);

                entity.Property(e => e.IdKhachhang).HasColumnName("id_khachhang");

                entity.Property(e => e.Khuyenmai)
                    .HasColumnName("khuyenmai")
                    .HasColumnType("money");

                entity.Property(e => e.LoaiDichVu)
                    .IsRequired()
                    .HasColumnName("loai_dich_vu")
                    .HasMaxLength(100);

                entity.Property(e => e.MaDichVu)
                    .IsRequired()
                    .HasColumnName("ma_dich_vu")
                    .HasMaxLength(30);

                entity.Property(e => e.NgayDangKy)
                    .HasColumnName("ngay_dang_ky")
                    .HasColumnType("datetime");

                entity.Property(e => e.TenDichVu)
                    .IsRequired()
                    .HasColumnName("ten_dich_vu")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LDinhDanhCaNhan>(entity =>
            {
                entity.HasKey(e => e.DinhDanhCaNhanId);

                entity.ToTable("L_DinhDanhCaNhan");

                entity.Property(e => e.DinhDanhCaNhanId).HasColumnName("DinhDanhCaNhan_Id");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CountryId).HasColumnName("Country_Id");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DinhDanhCaNhanCode)
                    .HasColumnName("DinhDanhCaNhan_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.DinhDanhCaNhanCreatedDate)
                    .HasColumnName("DinhDanhCaNhan_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DinhDanhCaNhanName)
                    .HasColumnName("DinhDanhCaNhan_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DinhDanhCaNhanSequence).HasColumnName("DinhDanhCaNhan_Sequence");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Telephone).HasMaxLength(50);
            });

            modelBuilder.Entity<LDrivingFloor>(entity =>
            {
                entity.HasKey(e => e.FloorId);

                entity.ToTable("L_Driving_FLoor");

                entity.Property(e => e.FloorId).HasColumnName("Floor_ID");

                entity.Property(e => e.FloorIntOrder).HasColumnName("Floor_intOrder");

                entity.Property(e => e.FloorName)
                    .HasColumnName("Floor_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LDrivingLane>(entity =>
            {
                entity.HasKey(e => e.LaneId)
                    .HasName("PK_L_Driving_Lane_1");

                entity.ToTable("L_Driving_Lane");

                entity.Property(e => e.LaneId).HasColumnName("Lane_ID");

                entity.Property(e => e.FloorId).HasColumnName("Floor_ID");

                entity.Property(e => e.LaneIntOrder).HasColumnName("Lane_intOrder");

                entity.Property(e => e.LaneName)
                    .IsRequired()
                    .HasColumnName("Lane_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.LaneOrderId)
                    .HasColumnName("Lane_Order_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("Player_ID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<LGeneralList>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.ToTable("L_GeneralList");

                entity.Property(e => e.ListId).HasColumnName("List_ID");

                entity.Property(e => e.ListCode)
                    .HasColumnName("List_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ListName)
                    .HasColumnName("List_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ListSequence).HasColumnName("List_Sequence");

                entity.Property(e => e.ListType)
                    .HasColumnName("List_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ListValue)
                    .HasColumnName("List_Value")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LMemberInfo>(entity =>
            {
                entity.HasKey(e => e.MemberId);

                entity.ToTable("L_MEMBER_INFO");

                entity.Property(e => e.MemberId)
                    .HasColumnName("Member_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CardTypeId).HasColumnName("CardType_ID");

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasColumnName("Country_ID")
                    .HasMaxLength(3)
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.DinhDanhCaNhanId).HasColumnName("DinhDanhCaNhan_Id");

                entity.Property(e => e.EndDate)
                    .HasColumnName("End_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImagePath)
                    .HasColumnName("Image_path")
                    .HasMaxLength(200);

                entity.Property(e => e.MemberAddress)
                    .HasColumnName("Member_Address")
                    .HasMaxLength(150);

                entity.Property(e => e.MemberCode)
                    .IsRequired()
                    .HasColumnName("Member_code")
                    .HasMaxLength(10);

                entity.Property(e => e.MemberDob)
                    .HasColumnName("Member_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemberEmail)
                    .HasColumnName("Member_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemberLoyaltyNumber)
                    .HasColumnName("Member_Loyalty_Number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MemberName)
                    .IsRequired()
                    .HasColumnName("Member_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.MemberNationalId)
                    .HasColumnName("Member_National_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MemberPhone)
                    .HasColumnName("Member_Phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemberYob).HasColumnName("Member_YOB");

                entity.Property(e => e.Sex).HasDefaultValueSql("((1))");

                entity.Property(e => e.StartDate)
                    .HasColumnName("Start_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<LMemberPolicies>(entity =>
            {
                entity.ToTable("L_MEMBER_POLICIES");

                entity.Property(e => e.CardTypeId).HasColumnName("CardType_ID");

                entity.Property(e => e.Desc).HasMaxLength(200);

                entity.Property(e => e.DiscountRate)
                    .HasColumnName("Discount_Rate")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DiscountType).HasColumnName("Discount_type");

                entity.Property(e => e.ServiceId)
                    .IsRequired()
                    .HasColumnName("Service_ID")
                    .HasMaxLength(30);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<LMemberTypeList>(entity =>
            {
                entity.HasKey(e => e.MemberTypeId);

                entity.ToTable("L_MemberTypeList");

                entity.Property(e => e.MemberTypeId).HasColumnName("MemberType_ID");

                entity.Property(e => e.Desc).HasMaxLength(200);

                entity.Property(e => e.MemberTypeName)
                    .HasColumnName("MemberType_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LMulist>(entity =>
            {
                entity.HasKey(e => e.MuId);

                entity.ToTable("L_MUList");

                entity.Property(e => e.MuId).HasColumnName("MU_ID");

                entity.Property(e => e.MuName)
                    .IsRequired()
                    .HasColumnName("MU_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LPaymentMethodList>(entity =>
            {
                entity.HasKey(e => e.PaymentMethodId);

                entity.ToTable("L_PaymentMethodList");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethod_ID");

                entity.Property(e => e.Desc).HasMaxLength(100);

                entity.Property(e => e.IntStt)
                    .HasColumnName("intSTT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentMethodName)
                    .IsRequired()
                    .HasColumnName("PaymentMethod_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LPlayerDetail>(entity =>
            {
                entity.HasKey(e => e.PlayerDetailId)
                    .HasName("PK_L_PLAYER_DETAIL_1");

                entity.ToTable("L_PLAYER_DETAIL");

                entity.Property(e => e.PlayerDetailId)
                    .HasColumnName("Player_Detail_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CouponSerie)
                    .HasColumnName("Coupon_Serie")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .HasColumnName("Create_By")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateByStaffId).HasColumnName("Create_By_Staff_ID");

                entity.Property(e => e.DiscountPrice)
                    .HasColumnName("Discount_Price")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.DiscountRate)
                    .HasColumnName("Discount_Rate")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.DiscountType).HasColumnName("Discount_Type");

                entity.Property(e => e.InputDate)
                    .HasColumnName("Input_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemberCode)
                    .HasColumnName("Member_code")
                    .HasMaxLength(50);

                entity.Property(e => e.MemberId)
                    .HasColumnName("Member_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("Modify_By")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("Modify_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NmrFromTime)
                    .HasColumnName("nmrFromTime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NmrToTime)
                    .HasColumnName("nmrToTime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OriginPrice)
                    .HasColumnName("Origin_Price")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.PlayerCode)
                    .IsRequired()
                    .HasColumnName("Player_code")
                    .HasMaxLength(10);

                entity.Property(e => e.PlayerId)
                    .HasColumnName("Player_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.ServiceId)
                    .IsRequired()
                    .HasColumnName("Service_ID")
                    .HasMaxLength(30);

                entity.Property(e => e.ServiceTime)
                    .HasColumnName("Service_Time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<LPlayerInfo>(entity =>
            {
                entity.HasKey(e => e.PlayerId);

                entity.ToTable("L_PLAYER_INFO");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("Player_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BagTag).HasMaxLength(50);

                entity.Property(e => e.BeginTime)
                    .HasColumnName("Begin_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.CardTypeId).HasColumnName("CardType_ID");

                entity.Property(e => e.CheckOutUser)
                    .HasColumnName("CheckOut_User")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasColumnName("Country_ID")
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("Create_User")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DinhDanhCaNhanId).HasColumnName("DinhDanhCaNhan_Id");

                entity.Property(e => e.DiscountType).HasColumnName("Discount_Type");

                entity.Property(e => e.EndTime)
                    .HasColumnName("End_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.FDiscountRate)
                    .HasColumnName("fDiscountRate")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceNote)
                    .HasColumnName("Invoice_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.LaneId).HasColumnName("Lane_ID");

                entity.Property(e => e.MemberCode)
                    .HasColumnName("Member_code")
                    .HasMaxLength(10);

                entity.Property(e => e.MemberId)
                    .HasColumnName("Member_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MemberTypeId).HasColumnName("MemberType_ID");

                entity.Property(e => e.PaymentId)
                    .HasColumnName("Payment_ID")
                    .HasMaxLength(7);

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnName("PaymentMethod_ID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.PlayerCode)
                    .IsRequired()
                    .HasColumnName("Player_code")
                    .HasMaxLength(7);

                entity.Property(e => e.PlayerName)
                    .IsRequired()
                    .HasColumnName("Player_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PlayerType).HasColumnName("Player_Type");

                entity.Property(e => e.SDiscountType)
                    .HasColumnName("sDiscountType")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'%')");

                entity.Property(e => e.ServiceChargeRate).HasColumnName("Service_Charge_Rate");

                entity.Property(e => e.SignRate)
                    .HasColumnName("Sign_Rate")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SignRateId).HasColumnName("SignRate_ID");

                entity.Property(e => e.StaffId).HasColumnName("Staff_ID");

                entity.Property(e => e.TotalDiscount).HasColumnType("money");

                entity.Property(e => e.TotalMoney).HasColumnType("money");

                entity.Property(e => e.VatRate).HasColumnName("VAT_Rate");
            });

            modelBuilder.Entity<LReportConfig>(entity =>
            {
                entity.HasKey(e => e.ReportCode);

                entity.ToTable("L_Report_Config");

                entity.Property(e => e.ReportCode)
                    .HasColumnName("Report_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasColumnName("Report_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ReportRptFileName)
                    .IsRequired()
                    .HasColumnName("Report_Rpt_File_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LServiceListV2>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.ToTable("L_ServiceListV2");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("Service_ID")
                    .HasMaxLength(30);

                entity.Property(e => e.Announce).HasDefaultValueSql("((0))");

                entity.Property(e => e.Desc).HasMaxLength(100);

                entity.Property(e => e.DiscountRate)
                    .HasColumnName("Discount_Rate")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscountType)
                    .HasColumnName("Discount_Type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnServiceName)
                    .HasColumnName("EnService_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.FromTime).HasColumnType("datetime");

                entity.Property(e => e.MuId).HasColumnName("MU_ID");

                entity.Property(e => e.NmrFromTime).HasColumnName("nmrFromTime");

                entity.Property(e => e.NmrToTime).HasColumnName("nmrToTime");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ServiceSequence).HasColumnName("Service_Sequence");

                entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceType_ID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.ToTime).HasColumnType("datetime");

                entity.Property(e => e.VnServiceName)
                    .IsRequired()
                    .HasColumnName("VnService_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LServiceTypeList>(entity =>
            {
                entity.HasKey(e => e.ServiceTypeId);

                entity.ToTable("L_ServiceTypeList");

                entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceType_ID");

                entity.Property(e => e.Desc)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'''')");

                entity.Property(e => e.ServiceTypeName)
                    .IsRequired()
                    .HasColumnName("ServiceType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ServiceTypeSequence).HasColumnName("ServiceType_Sequence");
            });

            modelBuilder.Entity<LStaffList>(entity =>
            {
                entity.HasKey(e => e.StaffId);

                entity.ToTable("L_StaffList");

                entity.Property(e => e.StaffId).HasColumnName("Staff_ID");

                entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceType_ID");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<LStaffType>(entity =>
            {
                entity.HasKey(e => e.StaffTypeId);

                entity.ToTable("L_StaffType");

                entity.Property(e => e.StaffTypeId).HasColumnName("StaffType_ID");

                entity.Property(e => e.StaffTypeName)
                    .HasColumnName("StaffType_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.StaffTypeSequence).HasColumnName("StaffType_Sequence");
            });

            modelBuilder.Entity<LStaffs>(entity =>
            {
                entity.HasKey(e => e.StaffId);

                entity.ToTable("L_Staffs");

                entity.Property(e => e.StaffId).HasColumnName("Staff_ID");

                entity.Property(e => e.DiscountRate)
                    .HasColumnName("Discount_Rate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(255);

                entity.Property(e => e.StaffAddress)
                    .HasColumnName("Staff_Address")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StaffCode)
                    .HasColumnName("Staff_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.StaffDob)
                    .HasColumnName("Staff_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.StaffEmail)
                    .HasColumnName("Staff_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaffName)
                    .IsRequired()
                    .HasColumnName("Staff_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.StaffNationalId)
                    .HasColumnName("Staff_National_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaffPhone)
                    .HasColumnName("Staff_Phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaffSequence).HasColumnName("Staff_Sequence");

                entity.Property(e => e.StaffSex).HasColumnName("Staff_Sex");

                entity.Property(e => e.StaffTypeId).HasColumnName("StaffType_ID");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LUidFunction>(entity =>
            {
                entity.HasKey(e => new { e.Uid, e.FunctionCode });

                entity.ToTable("L_UID_Function");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionCode)
                    .HasColumnName("Function_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LUser>(entity =>
            {
                entity.ToTable("L_User");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DiaChi)
                    .HasColumnName("dia_chi")
                    .HasMaxLength(4000);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GioiTinh).HasColumnName("gioi_tinh");

                entity.Property(e => e.HoTen)
                    .HasColumnName("ho_ten")
                    .HasMaxLength(255);

                entity.Property(e => e.NgaySinh)
                    .HasColumnName("ngay_sinh")
                    .HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.SoDienThoai)
                    .IsRequired()
                    .HasColumnName("so_dien_thoai")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TrangThai).HasColumnName("trang_thai");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<LUserServiceType>(entity =>
            {
                entity.HasKey(e => new { e.Uid, e.ServiceTypeId });

                entity.ToTable("L_User_ServiceType");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceType_ID");
            });

            modelBuilder.Entity<SysAdministrator>(entity =>
            {
                entity.HasKey(e => new { e.PkSAdminId, e.FpSBranchId })
                    .HasName("PK_tbl_Administrator");

                entity.ToTable("Sys_Administrator");

                entity.Property(e => e.PkSAdminId)
                    .HasColumnName("PK_sAdminID")
                    .HasMaxLength(50);

                entity.Property(e => e.FpSBranchId)
                    .HasColumnName("FP_sBranchID")
                    .HasMaxLength(10);

                entity.Property(e => e.IMonth).HasColumnName("iMonth");

                entity.Property(e => e.IYear).HasColumnName("iYear");

                entity.Property(e => e.PkSCreator)
                    .HasColumnName("PK_sCreator")
                    .HasMaxLength(50);

                entity.Property(e => e.SPwd)
                    .HasColumnName("sPWD")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SysConfigRadio>(entity =>
            {
                entity.HasKey(e => e.SysId);

                entity.Property(e => e.SysId).HasColumnName("Sys_ID");

                entity.Property(e => e.Domain).HasMaxLength(50);

                entity.Property(e => e.PassWord).HasMaxLength(50);

                entity.Property(e => e.PathUnc)
                    .HasColumnName("PathUNC")
                    .HasMaxLength(200);

                entity.Property(e => e.UserName)
                    .HasColumnName("User_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysDelegateUser>(entity =>
            {
                entity.ToTable("Sys_DelegateUser");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("BranchID")
                    .HasMaxLength(10);

                entity.Property(e => e.DelegateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MainUser)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysFormColor>(entity =>
            {
                entity.HasKey(e => e.SystemColorId);

                entity.ToTable("Sys_FormColor");

                entity.Property(e => e.SystemColorId).HasColumnName("SystemColor_ID");

                entity.Property(e => e.ColorValue).HasMaxLength(50);
            });

            modelBuilder.Entity<SysFunctions>(entity =>
            {
                entity.HasKey(e => new { e.PkIId, e.FpSBranchId })
                    .HasName("PK_tbl_Functions");

                entity.ToTable("Sys_Functions");

                entity.Property(e => e.PkIId)
                    .HasColumnName("PK_iID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FpSBranchId)
                    .HasColumnName("FP_sBranchID")
                    .HasMaxLength(10);

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.SAssemblyName)
                    .HasColumnName("sAssemblyName")
                    .HasMaxLength(100);

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(255);

                entity.Property(e => e.SDllname)
                    .IsRequired()
                    .HasColumnName("sDLLname")
                    .HasMaxLength(100);

                entity.Property(e => e.SFormName)
                    .IsRequired()
                    .HasColumnName("sFormName")
                    .HasMaxLength(100);

                entity.Property(e => e.SFunctionName)
                    .IsRequired()
                    .HasColumnName("sFunctionName")
                    .HasMaxLength(150);

                entity.Property(e => e.SParameterList)
                    .HasColumnName("sParameterList")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<SysGridViewOptions>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sys_GridViewOptions");

                entity.Property(e => e.Alignment).HasColumnName("ALIGNMENT");

                entity.Property(e => e.Branchid)
                    .IsRequired()
                    .HasColumnName("BRANCHID")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Colname)
                    .IsRequired()
                    .HasColumnName("COLNAME")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Container)
                    .IsRequired()
                    .HasColumnName("CONTAINER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Datagridview)
                    .IsRequired()
                    .HasColumnName("DATAGRIDVIEW")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalWidth)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Subsystem)
                    .IsRequired()
                    .HasColumnName("SUBSYSTEM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysGroupRoles>(entity =>
            {
                entity.HasKey(e => new { e.BranchId, e.GroupId, e.RoleId, e.ParentRoleId })
                    .HasName("PK_tbl_GroupRoles");

                entity.ToTable("Sys_GroupRoles");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.ParentRoleId).HasColumnName("ParentRoleID");
            });

            modelBuilder.Entity<SysGroupUser>(entity =>
            {
                entity.HasKey(e => new { e.BranchId, e.GroupId, e.UserId })
                    .HasName("PK_tbl_GroupUser");

                entity.ToTable("Sys_GroupUser");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysGroups>(entity =>
            {
                entity.HasKey(e => new { e.BranchId, e.GroupId })
                    .HasName("PK_tbl_Groups");

                entity.ToTable("Sys_Groups");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Desc)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SysImgAndIcon>(entity =>
            {
                entity.ToTable("Sys_ImgAndIcon");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("image");

                entity.Property(e => e.SFileName)
                    .HasColumnName("sFileName")
                    .HasMaxLength(50);

                entity.Property(e => e.SFilePath)
                    .HasColumnName("sFilePath")
                    .HasMaxLength(250);

                entity.Property(e => e.SSize)
                    .HasColumnName("sSize")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SType)
                    .HasColumnName("sType")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysLockObject>(entity =>
            {
                entity.HasKey(e => e.ObjectId)
                    .HasName("PK_LockObject");

                entity.ToTable("Sys_LockObject");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("ObjectID")
                    .HasMaxLength(10);

                entity.Property(e => e.LockTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<SysManagementUnit>(entity =>
            {
                entity.HasKey(e => e.PkSBranchId)
                    .HasName("PK_tbl_ManagementUnit");

                entity.ToTable("Sys_ManagementUnit");

                entity.Property(e => e.PkSBranchId)
                    .HasColumnName("PK_sBranchID")
                    .HasMaxLength(10);

                entity.Property(e => e.FpSUpBranchId)
                    .HasColumnName("FP_sUpBranchID")
                    .HasMaxLength(10);

                entity.Property(e => e.IntLevel).HasColumnName("intLevel");

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.SAccountId)
                    .HasColumnName("sAccountID")
                    .HasMaxLength(15);

                entity.Property(e => e.SAddress)
                    .HasColumnName("sAddress")
                    .HasMaxLength(100);

                entity.Property(e => e.SBankCode)
                    .HasColumnName("sBankCode")
                    .HasMaxLength(7);

                entity.Property(e => e.SBussinessPhone)
                    .HasColumnName("sBussinessPhone")
                    .HasMaxLength(20);

                entity.Property(e => e.SDutyPhone)
                    .HasColumnName("sDutyPhone")
                    .HasMaxLength(20);

                entity.Property(e => e.SEmail)
                    .HasColumnName("sEMAIL")
                    .HasMaxLength(30);

                entity.Property(e => e.SFax)
                    .HasColumnName("sFAX")
                    .HasMaxLength(13);

                entity.Property(e => e.SHotPhone)
                    .HasColumnName("sHotPhone")
                    .HasMaxLength(20);

                entity.Property(e => e.SLandSurveyUnitCode)
                    .HasColumnName("sLandSurveyUnitCode")
                    .HasMaxLength(7);

                entity.Property(e => e.SMandateUnitAddress)
                    .HasColumnName("sMandateUnitAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.SMandateUnitName)
                    .HasColumnName("sMandateUnitName")
                    .HasMaxLength(50);

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasColumnName("sName")
                    .HasMaxLength(100);

                entity.Property(e => e.SParentBranchName)
                    .HasColumnName("sParentBranchName")
                    .HasMaxLength(100);

                entity.Property(e => e.SPhone)
                    .HasColumnName("sPhone")
                    .HasMaxLength(20);

                entity.Property(e => e.SPosition)
                    .HasColumnName("sPosition")
                    .HasMaxLength(50);

                entity.Property(e => e.SProxyNumber)
                    .HasColumnName("sProxyNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.SRepresentative)
                    .HasColumnName("sRepresentative")
                    .HasMaxLength(50);

                entity.Property(e => e.STaxCode)
                    .HasColumnName("sTaxCode")
                    .HasMaxLength(17);

                entity.Property(e => e.STyper)
                    .HasColumnName("sTyper")
                    .HasMaxLength(20);

                entity.Property(e => e.TDateMandate)
                    .HasColumnName("tDateMandate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TInputDate)
                    .HasColumnName("tInputDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TInvalidDate)
                    .HasColumnName("tInvalidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SysMessages>(entity =>
            {
                entity.HasKey(e => e.MsgCode)
                    .HasName("PK_Sys_Message");

                entity.ToTable("Sys_Messages");

                entity.Property(e => e.MsgCode)
                    .HasColumnName("Msg_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ActionType)
                    .IsRequired()
                    .HasColumnName("Action_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EnMsgContent)
                    .IsRequired()
                    .HasColumnName("EnMsg_Content")
                    .HasMaxLength(200);

                entity.Property(e => e.EnMsgTitle)
                    .IsRequired()
                    .HasColumnName("EnMsg_Title")
                    .HasMaxLength(100);

                entity.Property(e => e.MsgType)
                    .IsRequired()
                    .HasColumnName("Msg_Type")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(200);

                entity.Property(e => e.SubsystemId).HasColumnName("Subsystem_ID");

                entity.Property(e => e.VnMsgContent)
                    .IsRequired()
                    .HasColumnName("VnMsg_Content")
                    .HasMaxLength(200);

                entity.Property(e => e.VnMsgTitle)
                    .IsRequired()
                    .HasColumnName("VnMsg_Title")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SysMultiLanguage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sys_MultiLanguage");

                entity.Property(e => e.SControlName)
                    .HasColumnName("sControlName")
                    .HasMaxLength(50);

                entity.Property(e => e.SDllName)
                    .HasColumnName("sDllName")
                    .HasMaxLength(50);

                entity.Property(e => e.SEn)
                    .HasColumnName("sEn")
                    .HasMaxLength(255);

                entity.Property(e => e.SEnText)
                    .HasColumnName("sEnText")
                    .HasMaxLength(255);

                entity.Property(e => e.SFormName)
                    .HasColumnName("sFormName")
                    .HasMaxLength(50);

                entity.Property(e => e.SVn)
                    .HasColumnName("sVN")
                    .HasMaxLength(255);

                entity.Property(e => e.SVnText)
                    .HasColumnName("sVnText")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SysRoles>(entity =>
            {
                entity.HasKey(e => new { e.IRole, e.FpSBranchId })
                    .HasName("PK_tbl_Roles");

                entity.ToTable("Sys_Roles");

                entity.Property(e => e.IRole)
                    .HasColumnName("iRole")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FpSBranchId)
                    .HasColumnName("FP_sBranchID")
                    .HasMaxLength(10);

                entity.Property(e => e.FkIFunctionId).HasColumnName("FK_iFunctionID");

                entity.Property(e => e.IOrder).HasColumnName("iOrder");

                entity.Property(e => e.IParentRole).HasColumnName("iParentRole");

                entity.Property(e => e.IntShortCutKey).HasColumnName("intShortCutKey");

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(255);

                entity.Property(e => e.SEngRoleName)
                    .HasColumnName("sEngRoleName")
                    .HasMaxLength(100);

                entity.Property(e => e.SIconPath)
                    .HasColumnName("sIconPath")
                    .HasMaxLength(255);

                entity.Property(e => e.SImgPath)
                    .HasColumnName("sImgPath")
                    .HasMaxLength(255);

                entity.Property(e => e.SRoleName)
                    .IsRequired()
                    .HasColumnName("sRoleName")
                    .HasMaxLength(100);

                entity.Property(e => e.TDateCreated)
                    .HasColumnName("tDateCreated")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SysRolesForUsers>(entity =>
            {
                entity.HasKey(e => new { e.SUid, e.IRoleId, e.IParentRoleId, e.FpSBranchId })
                    .HasName("PK_tbl_RolesForUsers");

                entity.ToTable("Sys_RolesForUsers");

                entity.Property(e => e.SUid)
                    .HasColumnName("sUID")
                    .HasMaxLength(50);

                entity.Property(e => e.IRoleId).HasColumnName("iRoleID");

                entity.Property(e => e.IParentRoleId).HasColumnName("iParentRoleID");

                entity.Property(e => e.FpSBranchId)
                    .HasColumnName("FP_sBranchID")
                    .HasMaxLength(10);

                entity.Property(e => e.IOrder).HasColumnName("iOrder");
            });

            modelBuilder.Entity<SysScreen>(entity =>
            {
                entity.ToTable("Sys_Screen");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("Role_ID");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysSecurity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sys_Security");

                entity.Property(e => e.SPwd)
                    .IsRequired()
                    .HasColumnName("sPWD")
                    .HasMaxLength(100);

                entity.Property(e => e.SUid)
                    .IsRequired()
                    .HasColumnName("sUID")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SysSystemParameters>(entity =>
            {
                entity.ToTable("Sys_SystemParameters");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FpSBranchId)
                    .IsRequired()
                    .HasColumnName("FP_sBranchID")
                    .HasMaxLength(10);

                entity.Property(e => e.IMonth).HasColumnName("iMonth");

                entity.Property(e => e.IStatus).HasColumnName("iStatus");

                entity.Property(e => e.IYear).HasColumnName("iYear");

                entity.Property(e => e.SDataType)
                    .IsRequired()
                    .HasColumnName("sDataType")
                    .HasMaxLength(100);

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(255);

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasColumnName("sName")
                    .HasMaxLength(100);

                entity.Property(e => e.SValue)
                    .IsRequired()
                    .HasColumnName("sValue")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SysToolbarButton>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sys_ToolbarButton");

                entity.Property(e => e.FpIntRoleId).HasColumnName("FP_intRoleID");

                entity.Property(e => e.FpSBranchId)
                    .IsRequired()
                    .HasColumnName("FP_sBranchID")
                    .HasMaxLength(10);

                entity.Property(e => e.IntDisplayText).HasColumnName("intDisplayText");

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IntRolePerformed).HasColumnName("intRolePerformed");

                entity.Property(e => e.IntStyle).HasColumnName("intStyle");

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(255);

                entity.Property(e => e.SIconPath)
                    .HasColumnName("sIconPath")
                    .HasMaxLength(255);

                entity.Property(e => e.SName)
                    .HasColumnName("sName")
                    .HasMaxLength(10);

                entity.Property(e => e.SRoleName)
                    .HasColumnName("sRoleName")
                    .HasMaxLength(100);

                entity.Property(e => e.SText)
                    .HasColumnName("sText")
                    .HasMaxLength(50);

                entity.Property(e => e.STtt)
                    .HasColumnName("sTTT")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SysTrace>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.BranchId })
                    .HasName("PK_tbl_Trace");

                entity.ToTable("Sys_Trace");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Desc)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Dllname)
                    .IsRequired()
                    .HasColumnName("DLLName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionId).HasColumnName("FunctionID");

                entity.Property(e => e.FunctionName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lot).HasColumnName("LOT");

                entity.Property(e => e.SubSystemName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysTrinhky>(entity =>
            {
                entity.HasKey(e => new { e.ReportName, e.ObjectName });

                entity.ToTable("Sys_Trinhky");

                entity.Property(e => e.ReportName).HasMaxLength(300);

                entity.Property(e => e.ObjectName).HasMaxLength(100);

                entity.Property(e => e.FontName)
                    .HasColumnName("Font_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.FontSize).HasColumnName("Font_Size");

                entity.Property(e => e.FontStype)
                    .HasColumnName("Font_Stype")
                    .HasMaxLength(50);

                entity.Property(e => e.ObjectContent).HasMaxLength(4000);
            });

            modelBuilder.Entity<SysUpdateVersion>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_Sys_Config_PathUNC");

                entity.ToTable("Sys_UpdateVersion");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PathUnc)
                    .HasColumnName("PathUNC")
                    .HasMaxLength(50);

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ServerName)
                    .HasColumnName("Server_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .HasColumnName("User_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysUserPrinter>(entity =>
            {
                entity.HasKey(e => e.SysUserName);

                entity.Property(e => e.SysUserName)
                    .HasColumnName("Sys_UserName")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountName).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.HospitalBy).HasMaxLength(50);

                entity.Property(e => e.InsuranceBy).HasMaxLength(50);

                entity.Property(e => e.PrinterName)
                    .HasColumnName("Printer_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysUsers>(entity =>
            {
                entity.HasKey(e => new { e.PkSUid, e.FpSBranchId })
                    .HasName("PK_tbl_Users");

                entity.ToTable("Sys_Users");

                entity.Property(e => e.PkSUid)
                    .HasColumnName("PK_sUID")
                    .HasMaxLength(50);

                entity.Property(e => e.FpSBranchId)
                    .HasColumnName("FP_sBranchID")
                    .HasMaxLength(10);

                entity.Property(e => e.DelegateUser).HasMaxLength(50);

                entity.Property(e => e.ISecurityLevel).HasColumnName("iSecurityLevel");

                entity.Property(e => e.SDepart)
                    .HasColumnName("sDepart")
                    .HasMaxLength(100);

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(255);

                entity.Property(e => e.SFullName)
                    .HasColumnName("sFullName")
                    .HasMaxLength(100);

                entity.Property(e => e.SPwd)
                    .HasColumnName("sPwd")
                    .HasMaxLength(50);

                entity.Property(e => e.TDateCreated)
                    .HasColumnName("tDateCreated")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SysVersion>(entity =>
            {
                entity.HasKey(e => e.PkIntId)
                    .HasName("PK_tbl_Version");

                entity.ToTable("Sys_Version");

                entity.Property(e => e.PkIntId).HasColumnName("PK_intID");

                entity.Property(e => e.DblCapacity).HasColumnName("dblCapacity");

                entity.Property(e => e.IntPatch).HasColumnName("intPatch");

                entity.Property(e => e.IntRar).HasColumnName("intRar");

                entity.Property(e => e.ObjData)
                    .IsRequired()
                    .HasColumnName("objData")
                    .HasColumnType("image");

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(255);

                entity.Property(e => e.SFileName)
                    .IsRequired()
                    .HasColumnName("sFileName")
                    .HasMaxLength(50);

                entity.Property(e => e.SRarFileName)
                    .HasColumnName("sRarFileName")
                    .HasMaxLength(50);

                entity.Property(e => e.SVersion)
                    .HasColumnName("sVersion")
                    .HasMaxLength(30);

                entity.Property(e => e.TUpdatedDate)
                    .HasColumnName("tUpdatedDate")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TBooking>(entity =>
            {
                entity.HasKey(e => e.BookingId);

                entity.ToTable("T_Booking");

                entity.Property(e => e.BookingId).HasColumnName("Booking_ID");

                entity.Property(e => e.BookingDateTime)
                    .HasColumnName("Booking_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BookingFinishTime)
                    .HasColumnName("Booking_Finish_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.BookingGuestCount).HasColumnName("Booking_Guest_Count");

                entity.Property(e => e.BookingNote)
                    .HasColumnName("Booking_Note")
                    .HasMaxLength(50);

                entity.Property(e => e.BookingStartTime)
                    .HasColumnName("Booking_Start_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.BookingStatus).HasColumnName("Booking_Status");

                entity.Property(e => e.BookingTypeId).HasColumnName("Booking_Type_ID");

                entity.Property(e => e.CreateBy).HasColumnName("Create_By");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("Create_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TBookingDetail>(entity =>
            {
                entity.HasKey(e => e.BookingDetailId);

                entity.ToTable("T_Booking_Detail");

                entity.Property(e => e.BookingDetailId).HasColumnName("Booking_Detail_ID");

                entity.Property(e => e.BookingId).HasColumnName("Booking_ID");

                entity.Property(e => e.CustomerBagTag)
                    .HasColumnName("Customer_BagTag")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerContact)
                    .HasColumnName("Customer_Contact")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerEmail)
                    .HasColumnName("Customer_Email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerNote)
                    .HasColumnName("Customer_Note")
                    .HasMaxLength(100);

                entity.Property(e => e.MemberId).HasColumnName("Member_ID");
            });

            modelBuilder.Entity<TCoupon>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceDetailId, e.CouponSerie })
                    .HasName("PK_T_Coupon_1");

                entity.ToTable("T_Coupon");

                entity.Property(e => e.InvoiceDetailId).HasColumnName("Invoice_Detail_ID");

                entity.Property(e => e.CouponSerie)
                    .HasColumnName("Coupon_Serie")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CouponContent)
                    .IsRequired()
                    .HasColumnName("Coupon_Content")
                    .HasMaxLength(100);

                entity.Property(e => e.CouponDetailId)
                    .HasColumnName("Coupon_Detail_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CouponId).HasColumnName("Coupon_ID");

                entity.Property(e => e.CouponInvoiceDetailId).HasColumnName("Coupon_Invoice_Detail_ID");

                entity.Property(e => e.CouponProportion)
                    .HasColumnName("Coupon_Proportion")
                    .HasColumnType("numeric(5, 3)");

                entity.Property(e => e.CouponTime)
                    .HasColumnName("Coupon_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.CouponTypeCode)
                    .IsRequired()
                    .HasColumnName("Coupon_Type_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CouponValue)
                    .HasColumnName("Coupon_Value")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CreateBy).HasColumnName("Create_By");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.ServiceProportion)
                    .HasColumnName("Service_Proportion")
                    .HasColumnType("numeric(5, 3)");
            });

            modelBuilder.Entity<TGolfBag>(entity =>
            {
                entity.HasKey(e => e.BagId);

                entity.ToTable("T_GolfBag");

                entity.Property(e => e.BagId).HasColumnName("Bag_ID");

                entity.Property(e => e.BagImagePath)
                    .HasColumnName("Bag_Image_Path")
                    .HasMaxLength(150);

                entity.Property(e => e.BagStatus).HasColumnName("Bag_Status");

                entity.Property(e => e.BagTag)
                    .IsRequired()
                    .HasColumnName("Bag_Tag")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClubCount).HasColumnName("Club_Count");

                entity.Property(e => e.CreateBy).HasColumnName("Create_By");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("Create_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemberId).HasColumnName("Member_ID");
            });

            modelBuilder.Entity<TGolfBagDetail>(entity =>
            {
                entity.HasKey(e => e.BagDetailId);

                entity.ToTable("T_GolfBag_Detail");

                entity.Property(e => e.BagDetailId).HasColumnName("Bag_Detail_ID");

                entity.Property(e => e.BagId).HasColumnName("Bag_ID");

                entity.Property(e => e.ClubBrandId)
                    .IsRequired()
                    .HasColumnName("Club_Brand_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClubNote)
                    .HasColumnName("Club_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.ClubTypeId)
                    .IsRequired()
                    .HasColumnName("Club_Type_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TGolfBagLog>(entity =>
            {
                entity.HasKey(e => e.BagLogId);

                entity.ToTable("T_GolfBag_Log");

                entity.Property(e => e.BagLogId).HasColumnName("Bag_Log_ID");

                entity.Property(e => e.BagId).HasColumnName("Bag_ID");

                entity.Property(e => e.BagLogNote)
                    .HasColumnName("Bag_Log_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.BagLogTime)
                    .HasColumnName("Bag_Log_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.BagLogTypeId).HasColumnName("Bag_Log_Type_ID");

                entity.Property(e => e.CreateBy).HasColumnName("Create_By");
            });

            modelBuilder.Entity<TLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Log");

                entity.Property(e => e.LogInfo)
                    .IsRequired()
                    .HasColumnName("Log_Info")
                    .HasColumnType("ntext");

                entity.Property(e => e.LogTime)
                    .HasColumnName("Log_Time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TPaymentDetail>(entity =>
            {
                entity.HasKey(e => e.PaymentDetailId);

                entity.ToTable("T_Payment_Detail");

                entity.Property(e => e.PaymentDetailId).HasColumnName("PaymentDetail_ID");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.PaymentAmount)
                    .HasColumnName("Payment_Amount")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PaymentMethodId).HasColumnName("Payment_Method_ID");

                entity.Property(e => e.PaymentTime)
                    .HasColumnName("Payment_Time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PaymentTransactionId)
                    .HasColumnName("Payment_Transaction_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VPatientExamSearch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PatientExamSearch");

                entity.Property(e => e.DeleteBy)
                    .HasColumnName("Delete_By")
                    .HasMaxLength(50);

                entity.Property(e => e.DeleteDate)
                    .HasColumnName("Delete_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Desc).HasMaxLength(500);

                entity.Property(e => e.DiscountRate)
                    .HasColumnName("Discount_Rate")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DiscountType).HasColumnName("Discount_Type");

                entity.Property(e => e.HosStatus).HasColumnName("Hos_status");

                entity.Property(e => e.HosTrans).HasColumnName("Hos_Trans");

                entity.Property(e => e.IndentityNo).HasColumnName("Indentity_No");

                entity.Property(e => e.InputDate)
                    .HasColumnName("Input_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsClinicCode)
                    .HasColumnName("InsClinic_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsObjectCode)
                    .HasColumnName("InsObject_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceFromDate)
                    .HasColumnName("Insurance_FromDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsuranceNum)
                    .HasColumnName("Insurance_Num")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceSupply)
                    .HasColumnName("Insurance_Supply")
                    .HasMaxLength(100);

                entity.Property(e => e.InsuranceToDate)
                    .HasColumnName("Insurance_ToDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastMoney).HasColumnType("money");

                entity.Property(e => e.ObjectTypeId).HasColumnName("ObjectType_ID");

                entity.Property(e => e.ObjectTypeName)
                    .IsRequired()
                    .HasColumnName("Object_Type_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.OrgirinMoney).HasColumnType("money");

                entity.Property(e => e.PatientCode)
                    .IsRequired()
                    .HasColumnName("Patient_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.ReasonBy)
                    .HasColumnName("Reason_By")
                    .HasMaxLength(255);

                entity.Property(e => e.RelativeAddress)
                    .HasColumnName("Relative_Address")
                    .HasMaxLength(255);

                entity.Property(e => e.RelativeName)
                    .HasColumnName("Relative_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.RelativePhone)
                    .HasColumnName("Relative_Phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(30);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VPatientSearch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PatientSearch");

                entity.Property(e => e.IdentifyNum)
                    .HasColumnName("Identify_Num")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InputDate)
                    .HasColumnName("Input_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PatientAddr)
                    .HasColumnName("Patient_Addr")
                    .HasMaxLength(200);

                entity.Property(e => e.PatientBirth)
                    .HasColumnName("Patient_Birth")
                    .HasColumnType("datetime");

                entity.Property(e => e.PatientEmail)
                    .HasColumnName("Patient_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientId)
                    .HasColumnName("Patient_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PatientName)
                    .HasColumnName("Patient_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PatientPhone)
                    .HasColumnName("Patient_Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientSex).HasColumnName("Patient_Sex");

                entity.Property(e => e.PinputDate)
                    .HasColumnName("PInputDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex).HasMaxLength(10);

                entity.Property(e => e.SurveyName).HasMaxLength(100);

                entity.Property(e => e.YearOfBirth).HasColumnName("Year_Of_Birth");
            });

            modelBuilder.Entity<VinHospitalPatientInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VInHospitalPatientInfo");

                entity.Property(e => e.HosStatus).HasColumnName("Hos_status");

                entity.Property(e => e.InsuranceNum)
                    .HasColumnName("Insurance_Num")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectTypeName)
                    .IsRequired()
                    .HasColumnName("ObjectType_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PatientCode)
                    .IsRequired()
                    .HasColumnName("Patient_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.PatientJob)
                    .HasColumnName("Patient_Job")
                    .HasMaxLength(100);

                entity.Property(e => e.PatientName)
                    .HasColumnName("Patient_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PatientSex).HasColumnName("Patient_Sex");

                entity.Property(e => e.ProvinceName)
                    .HasColumnName("Province_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.YearOfBirth).HasColumnName("Year_Of_Birth");
            });

            modelBuilder.Entity<VpatientInfoSearch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VPatientInfoSearch");

                entity.Property(e => e.HosStatus).HasColumnName("Hos_status");

                entity.Property(e => e.InputDate)
                    .HasColumnName("Input_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsurranceNum)
                    .HasColumnName("Insurrance_Num")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectTypeId).HasColumnName("ObjectType_ID");

                entity.Property(e => e.ObjectTypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PatientAddr)
                    .HasColumnName("Patient_Addr")
                    .HasMaxLength(200);

                entity.Property(e => e.PatientCode)
                    .IsRequired()
                    .HasColumnName("Patient_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientDob)
                    .HasColumnName("PatientDOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.PatientJob)
                    .HasColumnName("Patient_Job")
                    .HasMaxLength(100);

                entity.Property(e => e.PatientName)
                    .HasColumnName("Patient_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PatientSex).HasColumnName("Patient_Sex");

                entity.Property(e => e.PatientYob).HasColumnName("PatientYOB");

                entity.Property(e => e.PaymentStatus).HasColumnName("Payment_Status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
