using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LHinhThucTt
    {
        public short IdHinhThuc { get; set; }
        public string MaHinhThuc { get; set; }
        public string TenHinhThuc { get; set; }
        public string MoTa { get; set; }
        public int? SttHienThi { get; set; }
        public bool? HienThi { get; set; }
        public bool? ChonNganHang { get; set; }
    }
}
