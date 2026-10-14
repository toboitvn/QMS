using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DDmucChung
    {
        public string Ma { get; set; }
        public string Loai { get; set; }
        public string Ten { get; set; }
        public int SttHthi { get; set; }
        public int TrangThai { get; set; }
        public string MotaThem { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string TenVietTat { get; set; }
        public bool? NgoaiTruChon { get; set; }
        public bool? NoiTruChon { get; set; }
        public byte? TrangthaiMacdinh { get; set; }
    }
}
