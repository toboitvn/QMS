using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class QlddNhomCheDo
    {
        public short IdNhomCheDo { get; set; }
        public string MaNhomCheDo { get; set; }
        public string TenNhomCheDo { get; set; }
        public short? ThuTu { get; set; }
        public bool? HienThi { get; set; }
    }
}
