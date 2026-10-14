using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DPhieuDonThuocCt
    {
        public int IdPhieuDonThuocCt { get; set; }
        public int IdPhieuXuatBn { get; set; }
        public int IdThuoc { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal PhuThu { get; set; }
        public decimal Bnct { get; set; }
        public decimal Bhct { get; set; }
        public int? PtramBhyt { get; set; }
        public string ChiDan { get; set; }
        public string CachDung { get; set; }
        public string ChiDanThem { get; set; }
        public string SoLanDung { get; set; }
        public string SoLuongDung { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public int? PresDetailId { get; set; }
        public int? PresId { get; set; }
    }
}
