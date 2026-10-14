using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class QmsLayCls
    {
        public short? Stt { get; set; }
        public short? IdNoiThien { get; set; }
        public long AssignId { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public string MaPhongStt { get; set; }
    }
}
