using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class ViewNoitruLoadToanboThongtinGoiDichvu
    {
        public int IdPhieu { get; set; }
        public decimal? SoTienTraLai { get; set; }
        public int? DaHuy { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public string MaDtuong { get; set; }
        public int? IdGoiDvu { get; set; }
        public int? SoNgay { get; set; }
        public decimal? SoTien { get; set; }
        public DateTime? NgayHethan { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public int? TrangThai { get; set; }
        public int? IdNhanVien { get; set; }
        public byte? DaTtoan { get; set; }
        public DateTime? NgayKhoat { get; set; }
        public string NguoiKhoat { get; set; }
        public int? PaymentId { get; set; }
        public int NoiTru { get; set; }
        public string GhiChu { get; set; }
        public int? DepartmentId { get; set; }
        public int? RegId { get; set; }
        public int? FromIdGoiDvu { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string LyDoChuyen { get; set; }
        public string NguoiKthuc { get; set; }
        public DateTime? NgayKthuc { get; set; }
        public int DatTruoc { get; set; }
        public decimal? SoDanop { get; set; }
        public string TenGoiDvu { get; set; }
        public string MaGoiDvu { get; set; }
        public int? ThuTu { get; set; }
        public string FromTenGoiDvu { get; set; }
        public string StaffName { get; set; }
        public string DepartmentName { get; set; }
        public string UnitName { get; set; }
    }
}
