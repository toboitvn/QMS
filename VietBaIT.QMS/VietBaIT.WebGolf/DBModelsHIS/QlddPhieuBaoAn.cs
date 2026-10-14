using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class QlddPhieuBaoAn
    {
        public int IdPhieuBaoAn { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public DateTime NgayBaoAn { get; set; }
        public short IdKhoaNoiTru { get; set; }
        public short? RoomId { get; set; }
        public short? BedId { get; set; }
        public short IdNhanVien { get; set; }
        public bool BoSung { get; set; }
        public string MonBnKhongAn { get; set; }
        public string GhiChu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public int? IdPhieuLinhSuat { get; set; }
        public bool? DaThop { get; set; }
    }
}
