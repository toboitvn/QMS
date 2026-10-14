using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LFormRadio
    {
        public int FormId { get; set; }
        public string FormName { get; set; }
        public string FormDesc { get; set; }
        public string KetLuan { get; set; }
        public int? IntOrder { get; set; }
        public int? IsView { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string FormCode { get; set; }
        public string FormDocName { get; set; }
        public string FormType { get; set; }
    }
}
