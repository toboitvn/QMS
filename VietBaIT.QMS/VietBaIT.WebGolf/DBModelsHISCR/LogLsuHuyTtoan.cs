using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LogLsuHuyTtoan
    {
        public int PaymentId { get; set; }
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public short? StaffId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string PaymentCode { get; set; }
        public byte? KieuThanhToan { get; set; }
        public string MaCoSo { get; set; }
        public string IpMacTao { get; set; }
        public string IpMayTao { get; set; }
        public string NguoiHuy { get; set; }
        public DateTime? NgayHuy { get; set; }
        public string LyDoHuy { get; set; }
        public string MaKhoaThien { get; set; }
        public int? Transactionid { get; set; }
        public bool? TrucTuyen { get; set; }
        public bool? DaChot { get; set; }
        public short? HtThanhtoan { get; set; }
        public DateTime? NgayChot { get; set; }
        public bool? DaChotHuy { get; set; }
        public DateTime? NgayChotHuy { get; set; }
        public decimal? SoTienThanhtoan { get; set; }
        public short? HtThanhtoanHuy { get; set; }
    }
}
