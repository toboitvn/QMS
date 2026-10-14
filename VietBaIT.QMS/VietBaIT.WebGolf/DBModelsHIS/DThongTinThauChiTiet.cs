using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DThongTinThauChiTiet
    {
        public int IdChiTiet { get; set; }
        public int IdThau { get; set; }
        public int IdThuoc { get; set; }
        public short IdDonVi { get; set; }
        public decimal SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public int? SlDaNhap { get; set; }
        public int? SlDieuTiet { get; set; }
        public string NhomTckt { get; set; }
        public string NguonGoc { get; set; }
        public string DangSoche { get; set; }
        public string Tccl { get; set; }
        public string NhomThau { get; set; }
        public string SoDangky { get; set; }
    }
}
