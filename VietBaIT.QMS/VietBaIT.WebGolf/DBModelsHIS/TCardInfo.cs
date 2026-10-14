using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TCardInfo
    {
        public long IdThe { get; set; }
        public string PatientCode { get; set; }
        public long PatientId { get; set; }
        public string MaThe { get; set; }
        public byte? Dungtuyen { get; set; }
        public decimal? PtramGoc { get; set; }
        public DateTime? GtriTheTu { get; set; }
        public DateTime? GtriTheDen { get; set; }
        public byte? GiayBhyt { get; set; }
        public DateTime? NgayDu5nam { get; set; }
        public decimal? MucHuong { get; set; }
        public byte? Locked { get; set; }
        public string CoQuan { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string IpMacTao { get; set; }
        public string IpMacSua { get; set; }
        public string IpMayTao { get; set; }
        public string IpMaySua { get; set; }
        public byte? TrangThai { get; set; }
        public byte? MaLydoVv { get; set; }
        public string DiachiBhyt { get; set; }
        public string MaDoituongKcb { get; set; }
    }
}
