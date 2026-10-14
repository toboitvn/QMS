using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TPhieuTheoDoi
    {
        public int SoPhieu { get; set; }
        public DateTime? NgayLap { get; set; }
        public int? TreatId { get; set; }
        public string MaHoLy { get; set; }
        public short? IdKhoa { get; set; }
        public short? IdDinhDuong { get; set; }
        public short? IdLoaiDinhDuong { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
    }
}
