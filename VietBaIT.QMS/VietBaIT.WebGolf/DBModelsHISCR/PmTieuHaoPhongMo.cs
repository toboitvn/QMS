using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class PmTieuHaoPhongMo
    {
        public int IdTieuHao { get; set; }
        public int IdPhongMo { get; set; }
        public short IdKho { get; set; }
        public int? IdThuocKho { get; set; }
        public int IdThuoc { get; set; }
        public int IdDvt { get; set; }
        public string LoSx { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public double SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal? PhuThu { get; set; }
        public string KieuThuocVt { get; set; }
        public string MaDtuong { get; set; }
        public byte? IsPayment { get; set; }
        public long? IdThe { get; set; }
        public decimal? TyleTt { get; set; }
        public decimal? PtramBhyt { get; set; }
        public decimal? GiaBhytCt { get; set; }
        public decimal? GiaBnct { get; set; }
        public string GhiChu { get; set; }
        public byte? TrangThaiThanhToan { get; set; }
        public int? PaymentId { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public byte? TrongGoi { get; set; }
        public int? IdGoiDvu { get; set; }
        public byte? HasComfirm { get; set; }
        public bool? DaThop { get; set; }
        public int? IdCapphat { get; set; }
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
