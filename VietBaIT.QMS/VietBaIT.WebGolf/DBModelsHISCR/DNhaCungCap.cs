using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DNhaCungCap
    {
        public short IdNhaCcap { get; set; }
        public string MaNhaCcap { get; set; }
        public string TenNhaCcap { get; set; }
        public short? ThuTu { get; set; }
        public string GhiChu { get; set; }
        public string KieuThuocVt { get; set; }
        public bool? HienThi { get; set; }
    }
}
