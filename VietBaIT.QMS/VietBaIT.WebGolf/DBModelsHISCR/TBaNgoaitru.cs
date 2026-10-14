using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TBaNgoaitru
    {
        public long Id { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string MaBaNgoaiTru { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public string MaKhoaThien { get; set; }
        public string NgaySinh { get; set; }
        public string ThangSinh { get; set; }
        public short? NgoaiKieu { get; set; }
        public string NgheNghiep { get; set; }
        public string DanToc { get; set; }
        public string NoiLamViec { get; set; }
        public string ThongTinLhe { get; set; }
        public string DthoaiLhe { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public string GioPhutVaoVien { get; set; }
        public DateTime? DtriTuNgay { get; set; }
        public DateTime? DtriDenNgay { get; set; }
        public string CdRvienBchinh { get; set; }
        public string CdRvienBphu { get; set; }
        public string CdMaRvienBchinh { get; set; }
        public string CdMaRvienBphu { get; set; }
        public short? CdTaibienBienChungDo { get; set; }
        public string BaLdvv { get; set; }
        public string BaNgayThu { get; set; }
        public string BaQtbl { get; set; }
        public string BaTsb { get; set; }
        public string BaTsbBanThan { get; set; }
        public string BaTsblGiaDinh { get; set; }
        public string KbToanThan { get; set; }
        public string KbCacBoPhan { get; set; }
        public string KbMach { get; set; }
        public string KbNhietDo { get; set; }
        public string KbHuyetAp { get; set; }
        public string KbNhipTho { get; set; }
        public string KbCanNang { get; set; }
        public string KbXnCls { get; set; }
        public string KbTtba { get; set; }
        public string KbDaXuLy { get; set; }
        public string ChanDoanBanDau { get; set; }
        public string ChanDoanRaVien { get; set; }
        public string TkbaQtbl { get; set; }
        public string TkbaTtkqxn { get; set; }
        public string TkbaTtrv { get; set; }
        public string TkbaPpdt { get; set; }
        public string TkbaHdt { get; set; }
        public string Khoa { get; set; }
        public string Phong { get; set; }
        public string NguoiIn { get; set; }
        public DateTime? NgayIn { get; set; }
        public string MaCoso { get; set; }
    }
}
