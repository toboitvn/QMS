using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class PmSoMoiHoiChan
    {
        public int IdSoMoiHoiChan { get; set; }
        public int IdPhongMo { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public int IdkhoaMoi { get; set; }
        public DateTime? NgayHoiChan { get; set; }
        public int? GioHoiChan { get; set; }
        public int? PhutHoiChan { get; set; }
        public string DiaDiem { get; set; }
        public int? IdBuong { get; set; }
        public string ChanDoanTuyenDuoi { get; set; }
        public string ChanDoanKhoaKhamBenh { get; set; }
        public string ChanDoanKhoaDieuTri { get; set; }
        public string TinhTrangHienTai { get; set; }
        public string YeuCauHoiChan { get; set; }
        public int? IdTruongKhoa { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string IpMayTao { get; set; }
        public string IpMacTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string IpMaySua { get; set; }
        public string IpMacSua { get; set; }
    }
}
