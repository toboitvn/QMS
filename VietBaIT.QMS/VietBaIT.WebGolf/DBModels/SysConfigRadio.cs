using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class SysConfigRadio
    {
        public int SysId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Domain { get; set; }
        public string PathUnc { get; set; }
    }
}
