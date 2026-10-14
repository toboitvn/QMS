using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TThongtinRavien
    {
        public int SoPhieuRavien { get; set; }
        public int? PatientId { get; set; }
        public string PatientCode { get; set; }
        public string MaBa { get; set; }
        public int? IdKhoaRvien { get; set; }
        public int? IdKhoaNtru { get; set; }
        public int? TrangThai { get; set; }
        public string ChanDoan { get; set; }
        public string CachDtri { get; set; }
        public string TtrangBnhanRvien { get; set; }
        public string YkienDnghi { get; set; }
        public string NxetBvien { get; set; }
        public DateTime NgayRaVien { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public string MaBenh { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgayKetthuc { get; set; }
        public string NguoiKetthuc { get; set; }
        public string LoiDanThaythuoc { get; set; }
        public string MaYte { get; set; }
        public string SoLuuTru { get; set; }
        public int? ChoPhepTtoan { get; set; }
        public string BenhKemTheo { get; set; }
        public short? IdKetQuaDtri { get; set; }
        public short? IdKieuCvien { get; set; }
        public int? IdNoiBvienCden { get; set; }
        public byte ChuyenVien { get; set; }
        public string MbenhPhu { get; set; }
        public string ChanDoanPhu { get; set; }
        public string MbenhBchung { get; set; }
        public string ChanDoanBchung { get; set; }
        public string MbenhNnhan { get; set; }
        public string ChanDoanNnhan { get; set; }
        public string MbenhGphau { get; set; }
        public string ChanDoanGphau { get; set; }
        public byte PhopTthaiLsang { get; set; }
        public byte? DaIn { get; set; }
        public DateTime? NgayCapGiayRvien { get; set; }
        public DateTime? NgayTronVien { get; set; }
        public string LyDoTronVien { get; set; }
        public short? IdNguoiXacNhanTronVien { get; set; }
        public short? IdTtrangRavien { get; set; }
        public DateTime? NgayRaVienAo { get; set; }
        public DateTime? NgayChot { get; set; }
        public bool? DaChot { get; set; }
        public short? IdTaiNanTtich { get; set; }
        public short? SoNgayTkham { get; set; }
        public bool? DaInBaoHiem { get; set; }
        public string MaCoSo { get; set; }
        public DateTime? NgayTuVong { get; set; }
        public string MaLoaiKcb { get; set; }
        public decimal? Sotuoithai { get; set; }
        public int? IdTruongkhoa { get; set; }
        public string MaBenhYhct { get; set; }
        public string MaBenhYhctPhu { get; set; }
        public int? MaDinhChiThai { get; set; }
        public string NguyennhanDinhchi { get; set; }
        public DateTime? ThoigianDinhchi { get; set; }
        public string MaTheTam { get; set; }
        public string MaCha { get; set; }
        public string HoTenCha { get; set; }
        public string MaMe { get; set; }
        public string HoTenMe { get; set; }
        public decimal? SoNgayNghi { get; set; }
        public DateTime? NgoaitruTungay { get; set; }
        public DateTime? NgoaitruDenngay { get; set; }
        public int? MaTtdv { get; set; }
        public string CachDtriYhhd { get; set; }
    }
}
