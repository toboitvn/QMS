using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewInPhieuHoaSinh
    {
        public short? ServiceId { get; set; }
        public long AssignId { get; set; }
        public int ServiceDetailId { get; set; }
        public string ServiceName { get; set; }
        public string AssignCode { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string MaChidinh { get; set; }
        public string Barcode { get; set; }
        public short GroupOrder { get; set; }
        public string ServiceDetailName { get; set; }
        public int? IntOrder { get; set; }
    }
}
