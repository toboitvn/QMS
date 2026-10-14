using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DBenhAnKhamSucKhoeLog
    {
        public int IdLog { get; set; }
        public string SttRec { get; set; }
        public int? PatientId { get; set; }
        public string PatientCode { get; set; }
        public string GroupName { get; set; }
        public string StaffCode { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
    }
}
