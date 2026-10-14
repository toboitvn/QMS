using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DThuocChiadonvi
    {
        public int IdThuoc { get; set; }
        public short SluongBdau { get; set; }
        public string IdDonviBdau { get; set; }
        public short SluongDvi { get; set; }
        public short IdDonviChia { get; set; }
        public decimal DonGia { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
    }
}
