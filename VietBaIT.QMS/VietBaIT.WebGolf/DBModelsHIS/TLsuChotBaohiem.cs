using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TLsuChotBaohiem
    {
        public int Id { get; set; }
        public DateTime? Ngaychot { get; set; }
        public string Nguoichot { get; set; }
        public string Ipmay { get; set; }
        public string MaCoSo { get; set; }
    }
}
