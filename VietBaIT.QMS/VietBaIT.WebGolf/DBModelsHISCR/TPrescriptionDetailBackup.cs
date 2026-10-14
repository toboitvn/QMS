using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TPrescriptionDetailBackup
    {
        public int PresDetailId { get; set; }
        public int PresId { get; set; }
        public int DrugId { get; set; }
        public DateTime ExpireDate { get; set; }
        public double? Quantity { get; set; }
        public double? SluongSua { get; set; }
        public double? SluongLinh { get; set; }
        public decimal Price { get; set; }
        public decimal? SurchargePrice { get; set; }
        public string SDesc { get; set; }
        public byte? PaymentStatus { get; set; }
        public int? QuantityCancel { get; set; }
        public byte? IsCancel { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public byte? IsPayment { get; set; }
        public int? StockId { get; set; }
        public byte? HasComfirm { get; set; }
        public byte? BhytStatus { get; set; }
        public short? ThuTuIn { get; set; }
        public decimal? GiaBhytCt { get; set; }
        public decimal? GiaBnct { get; set; }
        public string MaDtuong { get; set; }
        public int? PaymentId { get; set; }
        public byte? XacNhan { get; set; }
        public int? ComfirmDeposit { get; set; }
        public int? IdGoiDvu { get; set; }
        public byte? TrongGoi { get; set; }
        public string CachDung { get; set; }
        public string ChiDanThem { get; set; }
        public string DviDung { get; set; }
        public string SoLanDung { get; set; }
        public string SoLuongDung { get; set; }
        public string IpMacSua { get; set; }
        public string IpMacTao { get; set; }
        public string IpMaySua { get; set; }
        public string IpMayTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public byte? TtChuyen { get; set; }
        public decimal? PtramBhyt { get; set; }
        public string ChiDanHtml { get; set; }
        public bool? DaThop { get; set; }
        public bool? TheoDoi { get; set; }
        public int? IdCapphat { get; set; }
        public int? IdThuocKho { get; set; }
        public bool? QuayKe { get; set; }
        public decimal? MienGiam { get; set; }
        public long? IdThe { get; set; }
        public decimal? TyleTt { get; set; }
    }
}
