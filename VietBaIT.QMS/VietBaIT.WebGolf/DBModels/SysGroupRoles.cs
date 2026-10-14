using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class SysGroupRoles
    {
        public string BranchId { get; set; }
        public int GroupId { get; set; }
        public int RoleId { get; set; }
        public int ParentRoleId { get; set; }
    }
}
