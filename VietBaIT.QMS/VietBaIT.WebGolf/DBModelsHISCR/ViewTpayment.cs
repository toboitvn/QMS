using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class ViewTpayment
    {
        public int PaymentId { get; set; }
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? StaffId { get; set; }
        public int? Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public string PaymentCode { get; set; }
        public int? KieuThanhToan { get; set; }
        public int? DaIn { get; set; }
        public DateTime? NgayIn { get; set; }
        public string NguoiIn { get; set; }
        public DateTime? NgayThop { get; set; }
        public string NguoiThop { get; set; }
        public int? TrongGoi { get; set; }
        public string MaKieuTtoan { get; set; }
        public string IpMacSua { get; set; }
        public string IpMacTao { get; set; }
        public string IpMaySua { get; set; }
        public string IpMayTao { get; set; }
        public string LyDoHuy { get; set; }
        public string MaKhoaThien { get; set; }
        public int? TthaiChuyen { get; set; }
        public DateTime? NgayChot { get; set; }
        public string MaCoSo { get; set; }
    }
}
