using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DmPtgtGiadung
    {
        public double? Id { get; set; }
        public string MaDv { get; set; }
        public string MaAx { get; set; }
        public string TenDvkt { get; set; }
        public string TenBhyt { get; set; }
        public string NhomDv { get; set; }
        public string NhomBc { get; set; }
        public double? ManhomAx { get; set; }
        public string TenNhomax { get; set; }
        public double? GiaBhyt { get; set; }
        public double? PhuthuBhyt { get; set; }
        public double? GiaVienphi { get; set; }
        public double? GiaYeucau { get; set; }
        public double? GiaKsk { get; set; }
        public string Hienthi { get; set; }
        public string GiaBhytDung { get; set; }
    }
}
