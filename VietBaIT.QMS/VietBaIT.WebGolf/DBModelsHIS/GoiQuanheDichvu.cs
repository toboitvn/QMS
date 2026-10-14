using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class GoiQuanheDichvu
    {
        public int IdQhe { get; set; }
        public int IdQly { get; set; }
        public int IdGoiDvu { get; set; }
        public int ServiceId { get; set; }
        public int ServiceDetailId { get; set; }
        public string ServiceDetailName { get; set; }
        public short? SoLuong { get; set; }
        public short? LoaiDv { get; set; }
        public decimal? DonGia { get; set; }
        public byte? TrangThai { get; set; }
        public decimal? SoluongDung { get; set; }
        public decimal? MienGiam { get; set; }
    }
}
