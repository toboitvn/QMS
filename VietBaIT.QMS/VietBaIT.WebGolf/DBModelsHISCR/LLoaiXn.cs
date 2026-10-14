using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LLoaiXn
    {
        public short IdLoaiXn { get; set; }
        public string MaXn { get; set; }
        public string TenLoaiXn { get; set; }
        public byte? XnChitiet { get; set; }
        public byte? HienThi { get; set; }
        public byte? MacDinhChon { get; set; }
        public int? SoThuTu { get; set; }
        public string MoTa { get; set; }
        public decimal? DonGia { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
    }
}
