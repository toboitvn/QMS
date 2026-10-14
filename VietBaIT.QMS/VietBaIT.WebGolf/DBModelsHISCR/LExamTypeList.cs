using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LExamTypeList
    {
        public short ExamTypeId { get; set; }
        public string ExamtypeCode { get; set; }
        public string ExamTypeName { get; set; }
        public short? IntOrder { get; set; }
        public string MaDtuong { get; set; }
        public bool? KhamCacPhong { get; set; }
    }
}
