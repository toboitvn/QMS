using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LSotayThuoc
    {
        public int IdSoTay { get; set; }
        public int? IdThuoc { get; set; }
        public int? SoLuong { get; set; }
        public string CachDung { get; set; }
        public string SlanNgay { get; set; }
        public string LdungNgay { get; set; }
        public string DviDung { get; set; }
        public string ChiDanThem { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
    }
}
