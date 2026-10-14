using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LObjectTypeDepartment
    {
        public short ObjectDeptId { get; set; }
        public short ObjectTypeId { get; set; }
        public short DepartmentId { get; set; }
        public decimal? DiscountRate { get; set; }
        public byte? DiscountType { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? Surcharge { get; set; }
        public string SDesc { get; set; }
        public int? ObjectTypeType { get; set; }
        public decimal? GiaCu { get; set; }
    }
}
