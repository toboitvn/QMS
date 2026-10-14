using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TCapsoGiaybaotu
    {
        public int IdQuyen { get; set; }
        public string MaQuyen { get; set; }
        public string KiHieu { get; set; }
        public string MauBaotu { get; set; }
        public string SerieDau { get; set; }
        public string SerieCuoi { get; set; }
        public string SerieHientai { get; set; }
        public DateTime? NgayBatdau { get; set; }
        public DateTime? NgayKetthuc { get; set; }
        public short? TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
    }
}
