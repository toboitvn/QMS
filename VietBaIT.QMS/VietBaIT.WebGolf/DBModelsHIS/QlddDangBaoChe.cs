using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class QlddDangBaoChe
    {
        public short IdDangBche { get; set; }
        public string MaDangBche { get; set; }
        public string TenDangBche { get; set; }
        public short? ThuTu { get; set; }
        public string GhiChu { get; set; }
        public bool? HienThi { get; set; }
    }
}
