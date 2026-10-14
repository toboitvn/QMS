using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class Temp
    {
        public int? IdDvu { get; set; }
        public string TenDvu { get; set; }
        public string Dvt { get; set; }
        public double? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public string SNgayDky { get; set; }
        public DateTime? NgayDky { get; set; }
        public int PaymentTypeId { get; set; }
        public int? IdLoaiDvu { get; set; }
    }
}
