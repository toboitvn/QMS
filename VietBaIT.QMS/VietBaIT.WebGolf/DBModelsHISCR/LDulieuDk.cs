using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LDulieuDk
    {
        public int IdDuLieuDk { get; set; }
        public int? ThuTuIn { get; set; }
        public string TenKq { get; set; }
        public string TenThongSo { get; set; }
        public string DonVi { get; set; }
        public string TbNam { get; set; }
        public string TbNu { get; set; }
        public int? ChoPhepHienThi { get; set; }
        public int? ChoPhepIn { get; set; }
        public string GhiChu { get; set; }
        public int? IdLoaiXn { get; set; }
    }
}
