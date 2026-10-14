using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class QheGioihanSoluong
    {
        public short IdKho { get; set; }
        public int IdThuoc { get; set; }
        public int? IdThuockho { get; set; }
        public decimal SoLuong { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string IpMacTao { get; set; }
        public string IpMacSua { get; set; }
        public string NoiDung { get; set; }
    }
}
