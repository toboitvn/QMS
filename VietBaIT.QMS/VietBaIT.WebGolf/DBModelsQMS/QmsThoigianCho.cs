using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsQMS
{
    public partial class QmsThoigianCho
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public int Thoigiancho { get; set; }
        public string Ghichu { get; set; }
        public byte? Trangthai { get; set; }
        public int? SobanTiepdon { get; set; }
    }
}
