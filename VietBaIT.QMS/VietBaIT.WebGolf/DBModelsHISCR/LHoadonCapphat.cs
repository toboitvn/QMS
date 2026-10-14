using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LHoadonCapphat
    {
        public decimal HdonId { get; set; }
        public decimal HdonMauId { get; set; }
        public string MaNvien { get; set; }
        public string MauHdon { get; set; }
        public string KiHieu { get; set; }
        public string MaQuyen { get; set; }
        public string SerieDau { get; set; }
        public string SerieCuoi { get; set; }
        public string SerieHtai { get; set; }
        public DateTime NgayCapphat { get; set; }
        public short TrangThai { get; set; }
    }
}
