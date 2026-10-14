using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class PhicongChitieu
    {
        public int IdTieuchi { get; set; }
        public string LoaiTieuchi { get; set; }
        public string LoaiTaubay { get; set; }
        public int CapTieuchi { get; set; }
        public int IdTieuchiCha { get; set; }
        public int Stt { get; set; }
        public string MaChitieu { get; set; }
        public string TenTieuchi { get; set; }
        public string TenTienganh { get; set; }
        public string KetquaTieuchi { get; set; }
        public string KetquaTienganh { get; set; }
        public short? TrangThai { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoitao { get; set; }
        public string Ipmactao { get; set; }
        public DateTime? Ngaysua { get; set; }
        public string Nguoisua { get; set; }
        public string Ipmacsua { get; set; }
    }
}
