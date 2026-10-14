using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TSoKhamSucKhoeDinhKyLog
    {
        public long NId { get; set; }
        public string SttRec { get; set; }
        public string PatientCode { get; set; }
        public string SCode { get; set; }
        public string SControlName { get; set; }
        public string SDescription { get; set; }
        public string SNoiDung { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
    }
}
