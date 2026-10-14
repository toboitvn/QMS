using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LGoiDvu
    {
        public int IdGoiDvu { get; set; }
        public string MaGoiDvu { get; set; }
        public string TenGoiDvu { get; set; }
        public int ThuTu { get; set; }
        public string MoTa { get; set; }
        public int? UnitId { get; set; }
        public byte? GoiKhongTru { get; set; }
    }
}
