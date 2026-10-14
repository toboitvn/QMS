using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LHoadonMau
    {
        public decimal HdonMauId { get; set; }
        public string MauHdon { get; set; }
        public string KiHieu { get; set; }
        public string MaQuyen { get; set; }
        public string SerieDau { get; set; }
        public string SerieCuoi { get; set; }
        public DateTime NgayHluc { get; set; }
        public DateTime NgayHhluc { get; set; }
        public short TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string MaCoSo { get; set; }
        public string SerieHtai { get; set; }
    }
}
