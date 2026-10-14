using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class THeathCareDetail
    {
        public int HeathDetailId { get; set; }
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public int? HeathId { get; set; }
        public string NhipTho { get; set; }
        public string HuyetApTren { get; set; }
        public string HuyetApDuoi { get; set; }
        public string NhietDo { get; set; }
        public string ChieuCao { get; set; }
        public string CanNang { get; set; }
        public string Mach { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public int? TreatId { get; set; }
        public short? DepartmentId { get; set; }
        public string Spo2 { get; set; }
        public string Bmi { get; set; }
        public string TheodoiNuoctieu { get; set; }
        public string TheodoiThem { get; set; }
        public bool? DaIn { get; set; }
        public string ThetichNuoctieu { get; set; }
        public string DuntichHongcau { get; set; }
        public string AplucTinhmachTrungtam { get; set; }
    }
}
