using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TPhieuGiuTheBh
    {
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public DateTime NgayNhanThe { get; set; }
        public DateTime? NgayTraThe { get; set; }
        public string NguoiTraThe { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public bool DaTraThe { get; set; }
        public short SoLanIn { get; set; }
    }
}
