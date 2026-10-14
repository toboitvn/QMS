using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TondauKhochinh
    {
        public double? DrugId { get; set; }
        public string DrugCode { get; set; }
        public string DrugName { get; set; }
        public string TenBhyt { get; set; }
        public string SoThau { get; set; }
        public string SoDangky { get; set; }
        public double? SoluongTon { get; set; }
        public double? DongiaBhyt { get; set; }
        public double? DongiaVp { get; set; }
        public string SoLo { get; set; }
        public string HanDung { get; set; }
        public string SoHoadon { get; set; }
        public string F13 { get; set; }
        public string F14 { get; set; }
        public string TtThau { get; set; }
    }
}
