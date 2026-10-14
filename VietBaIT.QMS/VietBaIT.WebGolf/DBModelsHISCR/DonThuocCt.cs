using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DonThuocCt
    {
        public string NgayKedon { get; set; }
        public int? ExamId { get; set; }
        public int? PatientId { get; set; }
        public string PatientCode { get; set; }
        public string BacSiKeDon { get; set; }
        public string Hdan { get; set; }
        public double? Soluong { get; set; }
        public int? SoIn { get; set; }
        public int DrugId { get; set; }
        public string SDesc { get; set; }
        public string KieuThuocVt { get; set; }
    }
}
