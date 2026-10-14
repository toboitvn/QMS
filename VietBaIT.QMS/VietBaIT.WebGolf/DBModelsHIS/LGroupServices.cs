using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LGroupServices
    {
        public int GroupServiceId { get; set; }
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public short? ParentId { get; set; }
        public short? ServiceId { get; set; }
        public short? ServiceDetailId { get; set; }
        public int? IntOrder { get; set; }
        public int? IsView { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
