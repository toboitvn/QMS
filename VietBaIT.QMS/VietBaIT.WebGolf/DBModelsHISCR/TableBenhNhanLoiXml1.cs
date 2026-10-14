using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TableBenhNhanLoiXml1
    {
        public int? PatientId { get; set; }
        public string PatientName { get; set; }
        public string MaTheBhyt { get; set; }
        public DateTime? NgayVao { get; set; }
        public DateTime? NgayRa { get; set; }
    }
}
