using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LStaffList
    {
        public short StaffId { get; set; }
        public short? ServiceTypeId { get; set; }
        public short Status { get; set; }
        public string Uid { get; set; }
    }
}
