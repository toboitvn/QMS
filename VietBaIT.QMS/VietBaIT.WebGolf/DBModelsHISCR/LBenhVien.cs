using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LBenhVien
    {
        public int IdBenhVien { get; set; }
        public string MaBenhVien { get; set; }
        public string TenBenhVien { get; set; }
        public string MaTinh { get; set; }
        public byte? HienThi { get; set; }
    }
}
