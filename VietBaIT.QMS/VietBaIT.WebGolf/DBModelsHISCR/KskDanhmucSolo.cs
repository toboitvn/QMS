using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class KskDanhmucSolo
    {
        public int Id { get; set; }
        public string MaSolo { get; set; }
        public string TenSolo { get; set; }
        public int IdKhachhang { get; set; }
        public int IdHopdong { get; set; }
        public decimal? SoLuong { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public int? LoaiThanhtoan { get; set; }
    }
}
