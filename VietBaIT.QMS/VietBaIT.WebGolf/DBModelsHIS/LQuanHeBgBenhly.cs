using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LQuanHeBgBenhly
    {
        public int Id { get; set; }
        public int? DepartmentId { get; set; }
        public int? RoomId { get; set; }
        public int? BedId { get; set; }
        public int? IdBenhLy { get; set; }
        public int? IdGoiDvu { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? PhuThu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string MaDtuong { get; set; }
        public string KieuThue { get; set; }
        public string TenHienThi { get; set; }
        public decimal? PhuThuTrongGoi { get; set; }
    }
}
