using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LNhomPpChebien
    {
        public int IdNhomPpChebien { get; set; }
        public string MaNhomPpChebien { get; set; }
        public string TenNhomPpChebien { get; set; }
        public string LoaiPpChebien { get; set; }
        public byte? HienThi { get; set; }
    }
}
