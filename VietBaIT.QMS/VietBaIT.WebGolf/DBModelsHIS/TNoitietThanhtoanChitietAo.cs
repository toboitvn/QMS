using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TNoitietThanhtoanChitietAo
    {
        public long PaymentDetailId { get; set; }
        public int PaymentId { get; set; }
        public int? Quantity { get; set; }
        public decimal? OriginPrice { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? TienBnTra { get; set; }
        public decimal? SurchargePrice { get; set; }
        public int? Id { get; set; }
        public int? IdDetail { get; set; }
        public int? ServiceId { get; set; }
        public int? ServiceDetailId { get; set; }
        public string ServiceDetailName { get; set; }
        public byte? PaymentTypeId { get; set; }
        public int? IsCancel { get; set; }
        public int? IsPayment { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public int? DepartmentId { get; set; }
        public int? DoctorAssignId { get; set; }
        public int? ThuTuIn { get; set; }
        public string DonViTinh { get; set; }
        public string MaDv { get; set; }
        public decimal? PtramBh { get; set; }
        public string MaKieuTtoan { get; set; }
        public int? IdGoiDvu { get; set; }
        public decimal? PtramCkhau { get; set; }
        public int? TrongGoi { get; set; }
        public int? DaThien { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public byte? NoiTru { get; set; }
        public string IpMacTao { get; set; }
        public string IpMayTao { get; set; }
        public string TenHienThi { get; set; }
        public byte? TtChuyen { get; set; }
        public byte? BhytStatus { get; set; }
        public short? IdNvienThien { get; set; }
    }
}
