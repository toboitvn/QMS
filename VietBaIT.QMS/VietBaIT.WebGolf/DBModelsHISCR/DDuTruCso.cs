using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DDuTruCso
    {
        public int Id { get; set; }
        public int? IdPhieuCso { get; set; }
        public string TenPhieu { get; set; }
        public DateTime? NgayLapPhieu { get; set; }
        public short? IdNhanVien { get; set; }
        public short? IdKhoa { get; set; }
        public short? IdKho { get; set; }
        public int? IdThuoc { get; set; }
        public int? SoLuong { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string GhiChu { get; set; }
    }
}
