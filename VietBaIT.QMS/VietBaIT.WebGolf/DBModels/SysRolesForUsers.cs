using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class SysRolesForUsers
    {
        public string SUid { get; set; }
        public long IRoleId { get; set; }
        public long IParentRoleId { get; set; }
        public string FpSBranchId { get; set; }
        public bool? AutoStart { get; set; }
        public int? IOrder { get; set; }
    }
}
