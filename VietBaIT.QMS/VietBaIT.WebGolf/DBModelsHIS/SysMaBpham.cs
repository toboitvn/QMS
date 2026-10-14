using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class SysMaBpham
    {
        public int Id { get; set; }
        public string MaChiDinh { get; set; }
        public int? SoStt { get; set; }
        public bool? NoiTru { get; set; }
        public short? DepartmentId { get; set; }
        public DateTime? NgayTao { get; set; }
        public bool? KhoaLai { get; set; }
        public string MaKhoaThien { get; set; }
        public bool? Loai { get; set; }
        public string MaCoSo { get; set; }
        public string MaKhoaBpham { get; set; }
    }
}
