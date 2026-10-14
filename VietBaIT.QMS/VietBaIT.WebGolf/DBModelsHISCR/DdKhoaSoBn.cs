using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DdKhoaSoBn
    {
        public decimal Id { get; set; }
        public short DepartmentId { get; set; }
        public short SoDd { get; set; }
        public short SoBn { get; set; }
        public DateTime NgayTao { get; set; }
        public string SDesc { get; set; }
    }
}
