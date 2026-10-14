using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LPpChebien
    {
        public int IdPpChebien { get; set; }
        public string MaPpChebien { get; set; }
        public string TenPpChebien { get; set; }
        public int IdNhomPpChebien { get; set; }
        public byte? HienThi { get; set; }
    }
}
