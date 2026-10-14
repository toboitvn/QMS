using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TPhieuKhamChuyenvienSxh
    {
        public int IdPhieuChuyenvien { get; set; }
        public string SoChuyenVien { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public short? IdBenhvienCden { get; set; }
        public string DiachiBenhvien { get; set; }
        public string Benhsu { get; set; }
        public string Tiensu { get; set; }
        public string NhapvienTrigiac { get; set; }
        public string NhapvienMach { get; set; }
        public string NhapvienHuyetap { get; set; }
        public string NhapvienNhiptho { get; set; }
        public string NhapvienSpo2 { get; set; }
        public string XnKetqua { get; set; }
        public string XnDungtichHongcau { get; set; }
        public string XnTieucau { get; set; }
        public string XnKhac { get; set; }
        public string ChanDoan { get; set; }
        public string ChanDoanDoSxh { get; set; }
        public DateTime? ChanDoanNgay { get; set; }
        public string TongketDieutri { get; set; }
        public string DiengiaiMl { get; set; }
        public string DiengiaiGio { get; set; }
        public string DiengiaiMlKg { get; set; }
        public string CaophantuMl { get; set; }
        public string CaophantuGio { get; set; }
        public string CaophantuMlKg { get; set; }
        public string HotroHohap { get; set; }
        public string Mau { get; set; }
        public string VanmachDopamineTu { get; set; }
        public string VanmachDopamineDen { get; set; }
        public string VanmachDobutamineTu { get; set; }
        public string VanmachDobutamineDen { get; set; }
        public string VanmachKhac { get; set; }
        public string LyDoChuyen { get; set; }
        public DateTime NgaygioChuyen { get; set; }
        public string PhuongTien { get; set; }
        public string NhanvienChuyen { get; set; }
        public string TtrangKhichuyenMach { get; set; }
        public string TtrangKhichuyenHuyeap { get; set; }
        public string TtrangKhichuyenNhiptho { get; set; }
        public string TtrangKhichuyenSpo2 { get; set; }
        public string DieutriKhichuyenDich { get; set; }
        public string DieutriKhichuyenTocdo { get; set; }
        public string DieutriKhichuyenThetichBandau { get; set; }
        public string DieutriKhichuyenThetichConlai { get; set; }
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
