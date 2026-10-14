using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LLanKhamChuyenKhoa
    {
        public short IdLanKham { get; set; }
        public string MaLanKham { get; set; }
        public string TenLanKham { get; set; }
        public byte Stt { get; set; }
        public string GhiChu { get; set; }
        public bool? HienThi { get; set; }
    }
}
