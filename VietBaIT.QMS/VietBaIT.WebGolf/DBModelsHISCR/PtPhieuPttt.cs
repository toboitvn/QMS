using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class PtPhieuPttt
    {
        public int IdPhieuPttt { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public short DepartmentId { get; set; }
        public short? RoomId { get; set; }
        public short? BedId { get; set; }
        public DateTime NgayPttt { get; set; }
        public string ChanDoan { get; set; }
        public string TruocPttt { get; set; }
        public string SauPttt { get; set; }
        public string PphapPttt { get; set; }
        public short IdLoaiPttt { get; set; }
        public string PphapVoCam { get; set; }
        public string IdBacSiPttt { get; set; }
        public string IdBacSiGayMe { get; set; }
        public string LuocDoPttt { get; set; }
        public string DanLuu { get; set; }
        public string Bac { get; set; }
        public DateTime? NgayRut { get; set; }
        public DateTime? NgayCatChi { get; set; }
        public string Khac { get; set; }
        public string TrinhTuPttt { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public int? TrangThai { get; set; }
        public DateTime? NgayXoa { get; set; }
        public string NguoiXoa { get; set; }
        public bool? NoiTru { get; set; }
        public bool? KetThucPttt { get; set; }
        public DateTime? NgayTuVong { get; set; }
        public string LyDoTaiBien { get; set; }
        public string LyDoTuVong { get; set; }
        public string IdBacSiPtttPhu { get; set; }
        public DateTime? NgayPtttKetThuc { get; set; }
        public bool? TaiBien { get; set; }
        public bool? TuVong { get; set; }
        public long AssignDetailId { get; set; }
        public string MaIcd9 { get; set; }
        public string IdGiupviec { get; set; }

        public virtual PtLoaiPttt IdLoaiPtttNavigation { get; set; }
    }
}
