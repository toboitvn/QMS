using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class PmDmhoaHongPhauThuat
    {
        public int HoaHongPhauThuatId { get; set; }
        public string LoaiPhauThuat { get; set; }
        public int LoaiKip { get; set; }
        public int MaViTri { get; set; }
        public int? DepartmentId { get; set; }
        public double DonGia { get; set; }
        public DateTime? NgayApDung { get; set; }
        public DateTime? NgayKetThuc { get; set; }
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
