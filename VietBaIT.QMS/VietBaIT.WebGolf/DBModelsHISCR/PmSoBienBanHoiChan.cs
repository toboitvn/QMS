using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class PmSoBienBanHoiChan
    {
        public int IdSoBienBanHoiChan { get; set; }
        public int IdPhongMo { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public DateTime? NgayHoiChan { get; set; }
        public int? GioHoiChan { get; set; }
        public int? PhutHoiChan { get; set; }
        public int IdhinhThuc { get; set; }
        public int IdkhoaMoi { get; set; }
        public int? IdTruongKhoa { get; set; }
        public string LyDoHoiChan { get; set; }
        public string DiaDiem { get; set; }
        public string ChuToa { get; set; }
        public string ChuToaChucDanh { get; set; }
        public string ChuToaChucVu { get; set; }
        public string ThuKy { get; set; }
        public string ThuKyChucDanh { get; set; }
        public string ThuKyChucVu { get; set; }
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
