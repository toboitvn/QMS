using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class SysUsers
    {
        public string PkSUid { get; set; }
        public string FpSBranchId { get; set; }
        public string SPwd { get; set; }
        public string SFullName { get; set; }
        public string SDepart { get; set; }
        public DateTime? TDateCreated { get; set; }
        public short? ISecurityLevel { get; set; }
        public string SDesc { get; set; }
        public string DelegateUser { get; set; }
    }
}
