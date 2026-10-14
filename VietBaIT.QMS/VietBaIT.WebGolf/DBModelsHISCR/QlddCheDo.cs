using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class QlddCheDo
    {
        public short IdCheDo { get; set; }
        public string MaCheDo { get; set; }
        public string TenCheDo { get; set; }
        public string Kcal { get; set; }
        public string Protein { get; set; }
        public string Gluco { get; set; }
        public short IdDangBche { get; set; }
        public short IdBenh { get; set; }
        public short? IdNhomCheDo { get; set; }
        public short? ThuTu { get; set; }
        public string GhiChu { get; set; }
        public bool? HienThi { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
    }
}
