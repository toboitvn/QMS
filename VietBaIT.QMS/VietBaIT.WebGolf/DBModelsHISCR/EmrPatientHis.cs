using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class EmrPatientHis
    {
        public int IdEmrHis { get; set; }
        public int? IdBenhanHis { get; set; }
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public string EmrNo { get; set; }
        public string MaDmucBa { get; set; }
        public string MaPhieuEmr { get; set; }
        public string EmrJsondata { get; set; }
        public byte? TrangthaiGui { get; set; }
        public DateTime? ThoigianGui { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string MayTao { get; set; }
        public string MaySua { get; set; }
    }
}
