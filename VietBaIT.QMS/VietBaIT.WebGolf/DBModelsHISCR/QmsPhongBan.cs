using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class QmsPhongBan
    {
        public short IdPhong { get; set; }
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public short Stt { get; set; }
        public bool HienThi { get; set; }
        public string TenBs { get; set; }
    }
}
