using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class SysFunctions
    {
        public long PkIId { get; set; }
        public string FpSBranchId { get; set; }
        public string SFunctionName { get; set; }
        public string SDllname { get; set; }
        public string SFormName { get; set; }
        public string SAssemblyName { get; set; }
        public bool? BEnable { get; set; }
        public string SParameterList { get; set; }
        public string SDesc { get; set; }
    }
}
