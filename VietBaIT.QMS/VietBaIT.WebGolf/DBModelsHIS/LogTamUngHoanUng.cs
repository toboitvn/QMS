using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LogTamUngHoanUng
    {
        public long DepositId { get; set; }
        public int? PatientId { get; set; }
        public string PatientCode { get; set; }
        public decimal? ToTalMoney { get; set; }
        public byte Status { get; set; }
        public DateTime? DepositDate { get; set; }
        public byte? DepositType { get; set; }
        public string SDesc { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public short? DepartmentId { get; set; }
        public string DepositCode { get; set; }
        public string MaCoSo { get; set; }
        public string NguoiXoa { get; set; }
        public DateTime? NgayXoa { get; set; }
        public string IpXoa { get; set; }
        public string LyDoXoa { get; set; }
        public int? IdGoiDvu { get; set; }
        public int? IdPhieuGoiDvu { get; set; }
        public int? Transactionid { get; set; }
        public bool? TrucTuyen { get; set; }
        public short? IdHinhThuc { get; set; }
        public bool? DaChotHuy { get; set; }
        public DateTime? NgayChotHuy { get; set; }
        public int? PaymentId { get; set; }
    }
}
