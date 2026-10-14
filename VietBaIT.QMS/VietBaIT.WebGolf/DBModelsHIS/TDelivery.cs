using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TDelivery
    {
        public long Id { get; set; }
        public DateTime InputDate { get; set; }
        public string InputUserId { get; set; }
        public int DeliverUserId { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public int Status { get; set; }
        public string SDesc { get; set; }
        public int? ConfirmStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
