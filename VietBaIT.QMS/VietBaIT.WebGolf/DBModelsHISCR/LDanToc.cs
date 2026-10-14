using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LDanToc
    {
        public short IdDanToc { get; set; }
        public string MaDanToc { get; set; }
        public string TenDanToc { get; set; }
        public byte HienThi { get; set; }
        public short? Stt { get; set; }
        public string GhiChu { get; set; }
    }
}
