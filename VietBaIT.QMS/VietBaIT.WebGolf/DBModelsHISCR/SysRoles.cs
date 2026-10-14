using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class SysRoles
    {
        public long IRole { get; set; }
        public string FpSBranchId { get; set; }
        public long IParentRole { get; set; }
        public string SRoleName { get; set; }
        public string SEngRoleName { get; set; }
        public int? IOrder { get; set; }
        public long? FkIFunctionId { get; set; }
        public DateTime? TDateCreated { get; set; }
        public string SImgPath { get; set; }
        public string SDesc { get; set; }
        public string SIconPath { get; set; }
        public int? IntShortCutKey { get; set; }
        public int? IsMid { get; set; }
        public string ParentRoleCode { get; set; }
        public bool? BEnable { get; set; }
    }
}
