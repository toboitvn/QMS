using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LLoaikcb
    {
        public int IdLoaikcb { get; set; }
        public string MaLoaikcb { get; set; }
        public string TenLoaikcb { get; set; }
        public byte? HienThi { get; set; }
    }
}
