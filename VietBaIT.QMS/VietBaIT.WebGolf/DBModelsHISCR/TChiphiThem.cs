using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TChiphiThem
    {
        public int Id { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public int? TreatId { get; set; }
        public string TenChiphiThem { get; set; }
        public string UnitName { get; set; }
        public decimal? TongTien { get; set; }
        public int? PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Sdesc { get; set; }
        public int? XacNhan { get; set; }
        public string NguoiKe { get; set; }
        public DateTime? NgayKe { get; set; }
    }
}
