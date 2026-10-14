using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class KskDanhmucSoloDichvu
    {
        public int IdDichvuLo { get; set; }
        public int IdLo { get; set; }
        public int PaymenttypeId { get; set; }
        public int ServiceId { get; set; }
        public int ServicedetailId { get; set; }
        public decimal Dongia { get; set; }
        public decimal DongiaCongty { get; set; }
        public decimal? Phuthu { get; set; }
        public decimal SoLuong { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
    }
}
