using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class PmPhieuDemGac
    {
        public long IdPhieuDemGac { get; set; }
        public int IdPhongMo { get; set; }
        public int IdPhieuPttt { get; set; }
        public string LoaiGac { get; set; }
        public decimal? SoLuongXuat { get; set; }
        public decimal? SoLuongThu { get; set; }
        public string KetLuan { get; set; }
        public int? Loai { get; set; }
    }
}
