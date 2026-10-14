using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DKieuDmucChung
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public int? Stt { get; set; }
        public byte? TrangThai { get; set; }
        public string MotaThem { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public int Id { get; set; }
        public byte? DungChung { get; set; }
        public byte? CamXoa { get; set; }
    }
}
