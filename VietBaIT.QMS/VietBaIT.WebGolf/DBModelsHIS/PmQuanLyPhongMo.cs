using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class PmQuanLyPhongMo
    {
        public int IdPhongMo { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public DateTime InputDate { get; set; }
        public short? DepartmentId { get; set; }
        public short? RoomId { get; set; }
        public short? BedId { get; set; }
        public string MaPhongKham { get; set; }
        public string ChanDoan { get; set; }
        public int AssignDetailId { get; set; }
        public short ServiceId { get; set; }
        public int ServiceDetailId { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? PhuThu { get; set; }
        public decimal? GiaBhct { get; set; }
        public decimal? GiaBnct { get; set; }
        public int? StateDuyet { get; set; }
        public DateTime? NgayDuyet { get; set; }
        public string NguoiDuyet { get; set; }
        public string LyDoTuChoi { get; set; }
        public int? CapCuu { get; set; }
        public int? StateKhamTruocMo { get; set; }
        public DateTime? NgayKham { get; set; }
        public int? StateMo { get; set; }
        public DateTime? NgayHoanTatMo { get; set; }
        public string GhiChu { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string IpMayTao { get; set; }
        public string IpMacTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string IpMaySua { get; set; }
        public string IpMacSua { get; set; }
    }
}
