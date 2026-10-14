using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class ExcelDoanhThuTamUng
    {
        public int Id { get; set; }
        public DateTime? NgayDky { get; set; }
        public string TenBn { get; set; }
        public int? NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string DoiTuong { get; set; }
        public decimal? TongTien { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
