using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DPhieuNhapTraCt
    {
        public int IdPhieuNhapTraCt { get; set; }
        public int IdPhieuNhapTra { get; set; }
        public int IdThuoc { get; set; }
        public double SoLuong { get; set; }
        public DateTime NgayHetHan { get; set; }
        public decimal DonGia { get; set; }
        public decimal GiaBan { get; set; }
        public decimal Vat { get; set; }
        public decimal ThanhTien { get; set; }
        public string GhiChu { get; set; }
        public int? IdThuocKho { get; set; }
        public int? IdThuocKhoChuyen { get; set; }
        public double? SoLuongChia { get; set; }
        public bool? ThuocChia { get; set; }
    }
}
