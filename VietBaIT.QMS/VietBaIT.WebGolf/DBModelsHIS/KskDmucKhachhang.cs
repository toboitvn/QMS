using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class KskDmucKhachhang
    {
        public long IdKhachHang { get; set; }
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string TenHienThi { get; set; }
        public string DiaChi { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Telephone { get; set; }
        public string Cellphone { get; set; }
        public string MaSoThue { get; set; }
        public string MaBaoCao { get; set; }
        public byte[] Logo { get; set; }
        public byte? TrangThai { get; set; }
        public int? SttHienThi { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
    }
}
