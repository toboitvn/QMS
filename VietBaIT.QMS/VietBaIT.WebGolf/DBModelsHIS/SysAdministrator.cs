using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class SysAdministrator
    {
        public string PkSAdminId { get; set; }
        public string FpSBranchId { get; set; }
        public string PkSCreator { get; set; }
        public string SPwd { get; set; }
        public int? IMonth { get; set; }
        public int? IYear { get; set; }
    }
}
