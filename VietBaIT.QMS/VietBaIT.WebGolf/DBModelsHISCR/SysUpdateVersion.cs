using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class SysUpdateVersion
    {
        public string Code { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PathUnc { get; set; }
        public string ServerName { get; set; }
        public string SDesc { get; set; }
        public int? IsUpdate { get; set; }
    }
}
