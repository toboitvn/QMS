using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DPhieuDtruCt
    {
        public int IdPhieuDtruCt { get; set; }
        public int IdPhieuDtru { get; set; }
        public int IdThuoc { get; set; }
        public double SoLuong { get; set; }
        public DateTime NgayHetHan { get; set; }
        public decimal DonGia { get; set; }
        public decimal GiaBan { get; set; }
        public decimal? Vat { get; set; }
        public short? IdSoQdinh { get; set; }
        public string SttQdinh { get; set; }
        public string MaSoDky { get; set; }
        public decimal? GiaBhyt { get; set; }
        public decimal? PhuThu { get; set; }
        public string SoLo { get; set; }
        public string GhiChu { get; set; }
    }
}
