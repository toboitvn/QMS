using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LStaffs
    {
        public int StaffId { get; set; }
        public string StaffCode { get; set; }
        public string StaffName { get; set; }
        public DateTime? StaffDob { get; set; }
        public byte? StaffSex { get; set; }
        public string StaffNationalId { get; set; }
        public short? StaffSequence { get; set; }
        public short StaffTypeId { get; set; }
        public string Uid { get; set; }
        public byte? Status { get; set; }
        public string SDesc { get; set; }
        public byte? DiscountRate { get; set; }
        public string StaffPhone { get; set; }
        public string StaffEmail { get; set; }
        public string StaffAddress { get; set; }
    }
}
