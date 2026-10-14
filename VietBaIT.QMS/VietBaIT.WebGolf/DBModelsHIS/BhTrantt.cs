using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class BhTrantt
    {
        public int Id { get; set; }
        public int? IdDichvu { get; set; }
        public decimal? TTrantt { get; set; }
        public bool? HieuLuc { get; set; }
        public DateTime? NgayHieuLucTu { get; set; }
        public DateTime? NgayHieuLucDen { get; set; }
        public int? Loai { get; set; }
        public double? TyLe { get; set; }
        public int? LanThu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
    }
}
