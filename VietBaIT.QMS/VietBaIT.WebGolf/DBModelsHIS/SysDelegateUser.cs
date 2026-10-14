using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class SysDelegateUser
    {
        public int Id { get; set; }
        public string BranchId { get; set; }
        public string MainUser { get; set; }
        public string DelegateUser { get; set; }
    }
}
