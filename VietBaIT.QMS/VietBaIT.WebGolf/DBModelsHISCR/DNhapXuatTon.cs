using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DNhapXuatTon
    {
        public int Id { get; set; }
        public int IdPhieu { get; set; }
        public int IdPhieuCt { get; set; }
        public int IdThuocKho { get; set; }
        public int IdThuoc { get; set; }
        public short IdKho { get; set; }
        public double SoLuong { get; set; }
        public double SoLuongTon { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public string Loai { get; set; }
        public bool? ThanhCong { get; set; }
        public decimal? GiaBan { get; set; }
        public decimal? PhuThu { get; set; }
        public decimal? GiaNhap { get; set; }
        public string LoaiNhapXuat { get; set; }
        public decimal? GiaBhyt { get; set; }
        public string Form { get; set; }
    }
}
