using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewLayMaBenhPhamXetNghiem
    {
        public long AssignDetailId { get; set; }
        public long? ExamId { get; set; }
        public long AssignId { get; set; }
        public short? ServiceId { get; set; }
        public int ServiceDetailId { get; set; }
        public short? DiagPerson { get; set; }
        public string UserId { get; set; }
        public DateTime? InputDate { get; set; }
        public byte PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public byte? IsPayment { get; set; }
        public int? Quantity { get; set; }
        public byte? AssignDetailStatus { get; set; }
        public string AssignDetailCode { get; set; }
        public int? TestId { get; set; }
        public string GhiChu { get; set; }
        public byte? XacNhan { get; set; }
        public int? PaymentId { get; set; }
        public short? Stt { get; set; }
        public string PatientCode { get; set; }
        public string ServiceName { get; set; }
        public string AssignCode { get; set; }
        public string MaChidinh { get; set; }
        public string Barcode { get; set; }
        public long PatientId { get; set; }
        public short GroupOrder { get; set; }
        public string ServiceDetailName { get; set; }
        public int? IntOrder { get; set; }
        public short ServiceTypeId { get; set; }
    }
}
