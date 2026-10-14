using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TPhieuKhamChuyenvienTcm
    {
        public int IdPhieuChuyenvien { get; set; }
        public string SoChuyenVien { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public short? IdBenhvienCden { get; set; }
        public string DauHieuLs { get; set; }
        public string NhapvienTrigiac { get; set; }
        public string NhapvienMach { get; set; }
        public string NhapvienHuyetap { get; set; }
        public string NhapvienNhiptho { get; set; }
        public string NhapvienSpo2 { get; set; }
        public string CacXetNghiem { get; set; }
        public string ChanDoan { get; set; }
        public string ChanDoanDoSxh { get; set; }
        public DateTime? ChanDoanNgay { get; set; }
        public string DiengiaiMl { get; set; }
        public string DiengiaiGio { get; set; }
        public string DiengiaiMlKg { get; set; }
        public string CaophantuMl { get; set; }
        public string CaophantuGio { get; set; }
        public string CaophantuMlKg { get; set; }
        public string HotroHohap { get; set; }
        public string VanmachDobutamineTu { get; set; }
        public string VanmachDobutamineDen { get; set; }
        public DateTime? VanmachDobutamineNgay { get; set; }
        public string VanmachAdrenalineTu { get; set; }
        public string VanmachAdrenalineDen { get; set; }
        public DateTime? VanmachAdrenalineNgay { get; set; }
        public string VanmachMilrinoneTu { get; set; }
        public string VanmachMilrinoneDen { get; set; }
        public DateTime? VanmachMilrinoneNgay { get; set; }
        public DateTime? IvigLieu1 { get; set; }
        public DateTime? IvigLieu2 { get; set; }
        public DateTime? PhenobarbitaGannhat { get; set; }
        public string PhenobarbitaTong24g { get; set; }
        public string ThuocKhac { get; set; }
        public string TtrangKhichuyenMach { get; set; }
        public string TtrangKhichuyenHuyeap { get; set; }
        public string TtrangKhichuyenNhiptho { get; set; }
        public string TtrangKhichuyenSpo2 { get; set; }
        public string DieutriKhichuyenDich { get; set; }
        public string DieutriKhichuyenTocdo { get; set; }
        public string DieutriKhichuyenThetichBandau { get; set; }
        public string DieutriKhichuyenThetichConlai { get; set; }
        public string DieutriKhichuyenVanmach { get; set; }
        public string LyDoChuyen { get; set; }
        public string SoChuyenVienTtruoc { get; set; }
        public DateTime NgayChuyenVien { get; set; }
        public string PhuongTienChuyen { get; set; }
        public string NhanvienChuyen { get; set; }
        public bool? Noitru { get; set; }
        public string MaCsKcb { get; set; }
        public int IdBacsiDieutri { get; set; }
        public int Status { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string MayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string MaySua { get; set; }
    }
}
