using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DSoQdinh
    {
        public short IdSoQdinh { get; set; }
        public string MaSoQdinh { get; set; }
        public string TenSoQdinh { get; set; }
        public short Stt { get; set; }
        public bool? HienThi { get; set; }
        public int? IdThuoc { get; set; }
        public string SoDangky { get; set; }
        public decimal? GiaNhap { get; set; }
        public DateTime? NgayCongbo { get; set; }
        public DateTime? Tungay { get; set; }
        public DateTime? Denngay { get; set; }
        public string Loaithau { get; set; }
        public string Nhomthau { get; set; }
        public string Ghichu { get; set; }
        public decimal? SoLuong { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public decimal? GiaBhyt { get; set; }
        public string GoiThau { get; set; }
        public string NhaThau { get; set; }
        public int? IdThau { get; set; }
        public int? IdNhaCc { get; set; }
        public string MaNhaCc { get; set; }
        public int? HtThau { get; set; }
        public int? IdThauCt { get; set; }
        public int? BophanDung { get; set; }
        public string NhomTckt { get; set; }
        public string NguonGoc { get; set; }
        public string DangSoche { get; set; }
        public string Tccl { get; set; }
    }
}
