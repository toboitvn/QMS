using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewChiPhi
    {
        public int PaymentTypeId { get; set; }
        public int? TreatId { get; set; }
        public long? PatientId { get; set; }
        public string PatientCode { get; set; }
        public long Id { get; set; }
        public long IdDetail { get; set; }
        public decimal? OriginPrice { get; set; }
        public decimal? DongiaTralai { get; set; }
        public decimal? SurchargePrice { get; set; }
        public decimal? PhuthuTralai { get; set; }
        public int? Quantity { get; set; }
        public int? Soluongthuc { get; set; }
        public int? Soluong { get; set; }
        public int? SoluongTralai { get; set; }
        public int? ServiceId { get; set; }
        public int? ServiceDetailId { get; set; }
        public string ServiceDetailName { get; set; }
        public string TenHienThi { get; set; }
        public string DonViTinh { get; set; }
        public short? DoctorId { get; set; }
        public int? PaymentStatus { get; set; }
        public int? IsPayment { get; set; }
        public DateTime NgayDky { get; set; }
        public int Noitru { get; set; }
        public int TrongGoi { get; set; }
        public short? DepartmentId { get; set; }
        public int IsCancel { get; set; }
        public int? Idthe { get; set; }
        public int? TuNguyen { get; set; }
    }
}
