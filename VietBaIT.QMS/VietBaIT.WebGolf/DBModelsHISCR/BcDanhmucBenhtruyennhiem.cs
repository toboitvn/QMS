using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class BcDanhmucBenhtruyennhiem
    {
        public int Id { get; set; }
        public string MaDm { get; set; }
        public string TenDmBenhTruyenNhiem { get; set; }
        public string TenBenh { get; set; }
        public string NhomBenh { get; set; }
        public string DanhSachIcd { get; set; }
        public string GhiChu { get; set; }
        public bool? HieuLuc { get; set; }
        public int? Stt { get; set; }
        public int? ParentId { get; set; }
    }
}
