using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class ViewThongTinTongHopChiPhiGoiVt
    {
        public int PaymentTypeId { get; set; }
        public int? PatientId { get; set; }
        public string PatientCode { get; set; }
        public int Id { get; set; }
        public int IdDetail { get; set; }
        public decimal? OriginPrice { get; set; }
        public decimal? DongiaTralai { get; set; }
        public decimal? SurchargePrice { get; set; }
        public decimal? PhuthuTralai { get; set; }
        public double Quantity { get; set; }
        public double SoLuong { get; set; }
        public double? SoluongTralai { get; set; }
        public decimal? Soluongthuc { get; set; }
        public int ServiceId { get; set; }
        public int ServiceDetailId { get; set; }
        public string ServiceDetailName { get; set; }
        public string TenHienThi { get; set; }
        public string DonViTinh { get; set; }
        public short? DoctorId { get; set; }
        public short? DepartmentId { get; set; }
        public byte? PaymentStatus { get; set; }
        public int? PaymentId { get; set; }
        public byte? IsPayment { get; set; }
        public DateTime NgayDky { get; set; }
        public byte Noitru { get; set; }
        public byte TrongGoi { get; set; }
        public byte IsCancel { get; set; }
        public byte? XacNhan { get; set; }
        public byte? DaThien { get; set; }
        public long? IdThe { get; set; }
        public decimal? MucHuong { get; set; }
        public decimal? TyleTt { get; set; }
        public decimal? GiaBhytCt { get; set; }
        public decimal? GiaBnct { get; set; }
        public int? IdGoiDvu { get; set; }
        public int? IdGoiVattu { get; set; }
        public decimal? MienGiam { get; set; }
    }
}
