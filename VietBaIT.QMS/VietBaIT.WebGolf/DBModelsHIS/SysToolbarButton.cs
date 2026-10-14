using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class SysToolbarButton
    {
        public long FpIntRoleId { get; set; }
        public string FpSBranchId { get; set; }
        public string SText { get; set; }
        public string SIconPath { get; set; }
        public string SDesc { get; set; }
        public string STtt { get; set; }
        public long? IntRolePerformed { get; set; }
        public short? IntOrder { get; set; }
        public string SName { get; set; }
        public short? IntStyle { get; set; }
        public string SRoleName { get; set; }
        public short? IntDisplayText { get; set; }
    }
}
