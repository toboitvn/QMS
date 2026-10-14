using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TAssignInfoTemp
    {
        public int? AssignId { get; set; }
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public string MaChidinh { get; set; }
        public string AssignCode { get; set; }
        public DateTime? RegDate { get; set; }
        public int? ExamId { get; set; }
        public bool? NoiTru { get; set; }
    }
}
