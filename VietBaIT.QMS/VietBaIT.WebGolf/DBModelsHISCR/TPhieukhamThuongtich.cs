using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TPhieukhamThuongtich
    {
        public int IdPhieu { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public string LydoVaovien { get; set; }
        public string MalydoVnt { get; set; }
        public int? IdBacsi { get; set; }
        public int? IdKhoa { get; set; }
        public DateTime? NgayKham { get; set; }
        public string ChandoanTuyenduoi { get; set; }
        public string TsuBanthan { get; set; }
        public string TsuGiadinh { get; set; }
        public string BenhSu { get; set; }
        public string DauhieuLs { get; set; }
        public string KhamToanthan { get; set; }
        public string KhamPhukhoa { get; set; }
        public string KhamBphanKhac { get; set; }
        public string ChandoanKhiVaovien { get; set; }
        public string TtKetquaLamsang { get; set; }
        public int? IdTainanThuongtich { get; set; }
        public string KquaXnghiem { get; set; }
        public string XuTri { get; set; }
        public string DaXuLy { get; set; }
        public string ChedoTdoi { get; set; }
        public string ChuY { get; set; }
        public string ThuocDadung { get; set; }
        public string BenhNhan { get; set; }
        public string TheTrang { get; set; }
        public string Bmi { get; set; }
        public string Eo { get; set; }
        public string HachNgoaivi { get; set; }
        public string TuyenGiap { get; set; }
        public string Tim { get; set; }
        public string TanSo { get; set; }
        public string HuyetAp { get; set; }
        public string Phoi { get; set; }
        public string Bung { get; set; }
        public string GanLanach { get; set; }
        public string PhanxaGanxuong { get; set; }
        public string Mat { get; set; }
        public byte? NoiTru { get; set; }
        public int? RegId { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
    }
}
