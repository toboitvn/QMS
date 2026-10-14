using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class Bhyt21a
    {
        public string MaBhyt { get; set; }
        public short? ServiceId { get; set; }
        public short? ServiceDetailId { get; set; }
        public string ServiceName { get; set; }
        public string Dvt { get; set; }
        public string ServiceDetailName { get; set; }
        public int? Stt { get; set; }
        public int? SoLuongNgoaitru { get; set; }
        public int? SoLuongNoitru { get; set; }
        public double? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }
        public decimal? PhuThu { get; set; }
        public bool? TuyenXa { get; set; }
    }
}
