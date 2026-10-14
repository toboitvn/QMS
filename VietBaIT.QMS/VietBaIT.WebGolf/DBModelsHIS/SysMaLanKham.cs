using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class SysMaLanKham
    {
        public int Id { get; set; }
        public string PatientCode { get; set; }
        public int? Stt { get; set; }
        public int? Nam { get; set; }
        public DateTime? NgayTao { get; set; }
        public bool? KhoaLai { get; set; }
    }
}
