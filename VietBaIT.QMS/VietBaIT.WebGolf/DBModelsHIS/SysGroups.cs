using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class SysGroups
    {
        public string BranchId { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public short IsAdmin { get; set; }
        public string Desc { get; set; }
    }
}
