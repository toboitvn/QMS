using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TLogBhyt
    {
        public int IdLogBhyt { get; set; }
        public int? PatientId { get; set; }
        public string PatientCode { get; set; }
        public string UserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public byte? ThanhCong { get; set; }
        public string MaKetqua { get; set; }
        public string MaGiaodich { get; set; }
        public string Result { get; set; }
    }
}
