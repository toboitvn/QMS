using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class SysUserPrinter
    {
        public string SysUserName { get; set; }
        public int? PagerCopy { get; set; }
        public string PrinterName { get; set; }
        public string AccountName { get; set; }
        public string CreatedBy { get; set; }
        public string InsuranceBy { get; set; }
        public string HospitalBy { get; set; }
    }
}
