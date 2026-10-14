using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class VaComPayment
    {
        public int PaymentId { get; set; }
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? StaffId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Status { get; set; }
        public string PaymentCode { get; set; }
        public int? KieuThanhToan { get; set; }
        public string MaCoSo { get; set; }
        public int? Transactionid { get; set; }
        public bool? TrucTuyen { get; set; }
        public byte? DaChot { get; set; }
    }
}
