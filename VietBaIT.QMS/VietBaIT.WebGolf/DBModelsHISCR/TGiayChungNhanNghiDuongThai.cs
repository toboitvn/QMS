using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TGiayChungNhanNghiDuongThai
    {
        public int IdPhieu { get; set; }
        public string SoCt { get; set; }
        public string SoSerie { get; set; }
        public DateTime? NgayCt { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string Office { get; set; }
        public string BenhDaiNgay { get; set; }
        public string BenhThongThuong { get; set; }
        public string ChanDoan { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? DenNgay { get; set; }
        public decimal? SoNgayNghi { get; set; }
        public string MaCskcb { get; set; }
        public string ThuTruongCskcb { get; set; }
        public string NguoiHanhNghe { get; set; }
        public byte? TrangThai { get; set; }
        public string LyDoHuy { get; set; }
        public DateTime? NgayHuy { get; set; }
        public string NguoiHuy { get; set; }
        public int? SoLanIn { get; set; }
        public string NguoiInCuoi { get; set; }
        public DateTime? NgayInCuoi { get; set; }
        public short? DaGui { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string IpMayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string IpMaySua { get; set; }
    }
}
