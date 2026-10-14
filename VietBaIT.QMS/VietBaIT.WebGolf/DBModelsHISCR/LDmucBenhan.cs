using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LDmucBenhan
    {
        public short Id { get; set; }
        public string NhomBa { get; set; }
        public string MaBenhan { get; set; }
        public string TenBenhan { get; set; }
        public short? IdGioitinh { get; set; }
        public short? SttHienthi { get; set; }
        public byte? Trangthai { get; set; }
        public DateTime? NgayTao { get; set; }
        public int? MaxSoHienTai { get; set; }
        public string MaPhieuEmr { get; set; }
        public string TenPhieuEmr { get; set; }
        public string TenForm { get; set; }
        public string GhiChu { get; set; }
    }
}
