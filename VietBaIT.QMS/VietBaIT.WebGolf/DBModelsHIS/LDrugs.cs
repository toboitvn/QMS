using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LDrugs
    {
        public LDrugs()
        {
            DDichVuThuocVtu = new HashSet<DDichVuThuocVtu>();
            DDonThuocMauCt = new HashSet<DDonThuocMauCt>();
            DKiemKeCt = new HashSet<DKiemKeCt>();
            DThuocKho = new HashSet<DThuocKho>();
            DThuocSoDangKy = new HashSet<DThuocSoDangKy>();
            TPrescriptionDetail = new HashSet<TPrescriptionDetail>();
        }

        public int DrugId { get; set; }
        public string DrugCode { get; set; }
        public short DrugTypeId { get; set; }
        public byte DrugNature { get; set; }
        public string DrugName { get; set; }
        public string TenBhyt { get; set; }
        public decimal Price { get; set; }
        public short UnitId { get; set; }
        public string SDesc { get; set; }
        public string Active { get; set; }
        public string Content { get; set; }
        public string Manufacturers { get; set; }
        public string NumberRegister { get; set; }
        public string Producer { get; set; }
        public string ListBhyt { get; set; }
        public byte HieuLuc { get; set; }
        public string DangBche { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string MaKhoaThien { get; set; }
        public string KieuThuocVt { get; set; }
        public string NqTt { get; set; }
        public bool? IsNhapSlkhong { get; set; }
        public string TenHienthi { get; set; }
        public int? SluongChia { get; set; }
        public short? UnitIdChia { get; set; }
        public short? IdNhomThuoc { get; set; }
        public bool? ThuocTheoDoi { get; set; }
        public short? SluongGhan { get; set; }
        public string MaBoYte { get; set; }
        public short? CountryId { get; set; }
        public short? IdDangBaoChe { get; set; }
        public short? IdHoatChat { get; set; }
        public short? IdDuongDung { get; set; }
        public short? IdTthaiLnhap { get; set; }
        public short? IdQuyCach { get; set; }
        public short? IdBoPhan { get; set; }
        public short? IdNhomCphi { get; set; }
        public string CongBo { get; set; }
        public int? DinhMuc { get; set; }
        public decimal? DonGiaTt { get; set; }
        public short? IdPhanLoaiThuoc { get; set; }
        public int? SoLuongThau { get; set; }
        public bool? TuTuc { get; set; }
        public byte? NoiNgoaiTthai { get; set; }
        public short? IdNhaThau { get; set; }
        public bool? CamGuiXml { get; set; }
        public bool? HuySuDung { get; set; }
        public string TenBietDuoc { get; set; }
        public string LoaiThau { get; set; }
        public string NhomThau { get; set; }
        public bool? LaGoi { get; set; }
        public decimal? LieudungToida { get; set; }
        public decimal? GioihanThoigian { get; set; }
        public bool? Kekemdichvu { get; set; }
        public bool? GuiAx { get; set; }
        public int? MaPttt { get; set; }
        public string MaHieuSp { get; set; }
        public bool? TaiSuDung { get; set; }
        public string PhanhangAbc { get; set; }
        public string PhantichVen { get; set; }
        public string MaAtc { get; set; }
        public string MaBietduoc { get; set; }

        public virtual BhThuocVtTyLe BhThuocVtTyLe { get; set; }
        public virtual ICollection<DDichVuThuocVtu> DDichVuThuocVtu { get; set; }
        public virtual ICollection<DDonThuocMauCt> DDonThuocMauCt { get; set; }
        public virtual ICollection<DKiemKeCt> DKiemKeCt { get; set; }
        public virtual ICollection<DThuocKho> DThuocKho { get; set; }
        public virtual ICollection<DThuocSoDangKy> DThuocSoDangKy { get; set; }
        public virtual ICollection<TPrescriptionDetail> TPrescriptionDetail { get; set; }
    }
}
