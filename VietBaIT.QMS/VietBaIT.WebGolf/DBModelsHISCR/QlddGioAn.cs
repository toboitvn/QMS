using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class QlddGioAn
    {
        public short IdGio { get; set; }
        public string MaGio { get; set; }
        public string TenGio { get; set; }
        public short? ThuTu { get; set; }
        public string GhiChu { get; set; }
        public bool? HienThi { get; set; }
    }
}
