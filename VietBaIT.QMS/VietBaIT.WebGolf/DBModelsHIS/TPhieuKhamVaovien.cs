using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TPhieuKhamVaovien
    {
        public int IdPhieuVaovien { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public string LyDoVaoVien { get; set; }
        public string ChandoanTuyenDuoi { get; set; }
        public string TsuBanThan { get; set; }
        public string TsuGiaDinh { get; set; }
        public string BenhSu { get; set; }
        public string KhamToanThan { get; set; }
        public string KhamPhuKhoa { get; set; }
        public string ChandoanKhiVaovien { get; set; }
        public string XuTri { get; set; }
        public int? IdKhoaNtru { get; set; }
        public string CheDoTdoi { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string ChuY { get; set; }
        public string DauHieuLs { get; set; }
        public string ThuocDaDung { get; set; }
        public string BenhNhan { get; set; }
        public string TheTrang { get; set; }
        public string Bmi { get; set; }
        public string Eo { get; set; }
        public string HachNgoaiVi { get; set; }
        public string TuyenGiap { get; set; }
        public string Tim { get; set; }
        public string TanSo { get; set; }
        public string HuyetAp { get; set; }
        public string Phoi { get; set; }
        public string Bung { get; set; }
        public string GanLaNach { get; set; }
        public string PhanXaGanXuong { get; set; }
        public string Mat { get; set; }
        public string KhamBphanKhac { get; set; }
        public string KquaXnghiem { get; set; }
        public string TtKetquaLamsang { get; set; }
        public string DaXuLy { get; set; }
        public byte? NoiTru { get; set; }
        public int? RegId { get; set; }
        public string MaLyDoVnt { get; set; }
        public string IdBacsi { get; set; }
    }
}
