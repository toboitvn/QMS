using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DDieuTietThau
    {
        public int IdDieutiet { get; set; }
        public DateTime NgayDieutiet { get; set; }
        public int VienDieutiet { get; set; }
        public int IdThau { get; set; }
        public string SoThau { get; set; }
        public string GhiChu { get; set; }
        public bool? TrangThai { get; set; }
        public bool? DaXacNhan { get; set; }
        public string NguoiXacNhan { get; set; }
        public DateTime? NgayXacNhan { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string SohdDieutiet { get; set; }
        public DateTime? NgayhdDieutiet { get; set; }
        public DateTime? NgayktDieutiet { get; set; }
    }
}
