using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DanhsachKsk
    {
        public int? MaNv { get; set; }
        public string Hoten { get; set; }
        public DateTime? NgaySinh { get; set; }
        public byte? GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public int? Lo { get; set; }
        public string Thoigian { get; set; }
        public string MaLk { get; set; }
    }
}
