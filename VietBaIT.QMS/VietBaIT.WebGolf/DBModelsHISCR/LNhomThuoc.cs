using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LNhomThuoc
    {
        public short IdNhomThuoc { get; set; }
        public string MaNhomThuoc { get; set; }
        public string TenNhomThuoc { get; set; }
        public short? Stt { get; set; }
        public bool? HienThi { get; set; }
        public string GhiChu { get; set; }
    }
}
