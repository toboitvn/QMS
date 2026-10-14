using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DHoatChat
    {
        public short IdHoatChat { get; set; }
        public string MaHoatChat { get; set; }
        public string TenHoatChat { get; set; }
        public short? Stt { get; set; }
        public bool? HienThi { get; set; }
        public string MoTa { get; set; }
        public string DuongDung { get; set; }
        public string MaAtc { get; set; }
        public string MaBietduoc { get; set; }
    }
}
