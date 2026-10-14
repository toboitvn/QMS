using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LDichVu
    {
        public long Id { get; set; }
        public string IdDichvu { get; set; }
        public DateTime NgayDangKy { get; set; }
        public string MaDichVu { get; set; }
        public long IdKhachhang { get; set; }
        public string TenDichVu { get; set; }
        public string LoaiDichVu { get; set; }
        public decimal DonGia { get; set; }
        public decimal? Khuyenmai { get; set; }
    }
}
