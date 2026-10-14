using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LStaffType
    {
        public int StaffTypeId { get; set; }
        public string StaffTypeName { get; set; }
        public int? StaffTypeSequence { get; set; }
    }
}
