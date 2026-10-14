using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DPhieuXuatBnhanCt
    {
        public int IdPhieuXuatCt { get; set; }
        public int IdPhieuXuatBn { get; set; }
        public short? IdKhoXuat { get; set; }
        public int IdThuoc { get; set; }
        public double SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal GiaBan { get; set; }
        public string ChiDan { get; set; }
        public string SoLo { get; set; }
        public int Vat { get; set; }
        public DateTime NgayHetHan { get; set; }
        public int IdPhieuNhapCt { get; set; }
        public int? IdThuocKho { get; set; }
    }
}
