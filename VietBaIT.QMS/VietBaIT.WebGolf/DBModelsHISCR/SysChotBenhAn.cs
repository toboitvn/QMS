using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class SysChotBenhAn
    {
        public int Id { get; set; }
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public DateTime? NgayChot { get; set; }
        public bool? NoiTru { get; set; }
    }
}
