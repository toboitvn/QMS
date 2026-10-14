using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LSampleAssignDetail
    {
        public long AssignDetailId { get; set; }
        public int? AssignId { get; set; }
        public string AssignCode { get; set; }
        public string AssignName { get; set; }
        public short? ServiceId { get; set; }
        public int ServiceDetailId { get; set; }
        public decimal OriginPrice { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? SurchargePrice { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public string KeyCode { get; set; }
    }
}
