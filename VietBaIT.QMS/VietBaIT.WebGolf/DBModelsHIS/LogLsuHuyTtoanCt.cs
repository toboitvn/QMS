using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LogLsuHuyTtoanCt
    {
        public long PaymentDetailId { get; set; }
        public int PaymentId { get; set; }
        public double? Quantity { get; set; }
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
        public bool? IsPayment { get; set; }
        public short? DepartmentId { get; set; }
        public short? DoctorAssignId { get; set; }
        public short? ThuTuIn { get; set; }
        public string DonViTinh { get; set; }
        public string MaDv { get; set; }
        public decimal? PtramBh { get; set; }
        public string MaKieuTtoan { get; set; }
        public bool? TrongGoi { get; set; }
        public byte? DaThien { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public bool? NoiTru { get; set; }
        public string IpMacTao { get; set; }
        public string IpMayTao { get; set; }
        public string TenHienThi { get; set; }
        public short? IdNvienThien { get; set; }
        public int? IdGoiDvu { get; set; }
    }
}
