using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class SysSystemParameters
    {
        public long Id { get; set; }
        public string FpSBranchId { get; set; }
        public string SName { get; set; }
        public string SDataType { get; set; }
        public string SValue { get; set; }
        public int IMonth { get; set; }
        public int IYear { get; set; }
        public short IStatus { get; set; }
        public string SDesc { get; set; }
    }
}
