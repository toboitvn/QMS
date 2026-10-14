using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LAssemblyReport
    {
        public string AssemblyReportId { get; set; }
        public string ReportName { get; set; }
        public string SDllname { get; set; }
        public string SAssemblyName { get; set; }
        public string Desc { get; set; }
    }
}
