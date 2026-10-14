using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class PmPhieuKqsinhThiet
    {
        public long IdPhieu { get; set; }
        public long IdPhieuXn { get; set; }
        public string NguoiPhaBp { get; set; }
        public DateTime? NgayPha { get; set; }
        public string SoManh { get; set; }
        public string PhuongPhapNhuom { get; set; }
        public DateTime? NgayLamTieuBan { get; set; }
        public string NguoiLamTieuBan { get; set; }
        public string NhanXetDaiThe { get; set; }
        public string NhanXetViThe { get; set; }
        public string ChanDoanGiaiPhau { get; set; }
        public string SuPhuHop { get; set; }
        public string BacSyDocKq { get; set; }
        public string BacSyDieuTri { get; set; }
        public DateTime? NgayTraKq { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string IpMayTao { get; set; }
        public string IpMacTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string IpMaySua { get; set; }
        public string IpMacSua { get; set; }
    }
}
