using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TBenhanDanhmuc
    {
        public int Id { get; set; }
        public string NhomBa { get; set; }
        public string MaBenhan { get; set; }
        public string TenBenhan { get; set; }
        public short? IdGioitinh { get; set; }
        public byte? NoiTru { get; set; }
        public short? SttHienthi { get; set; }
        public int? SoHientai { get; set; }
        public byte? TrangThai { get; set; }
        public string FormBenhan { get; set; }
        public string MotaThem { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
    }
}
