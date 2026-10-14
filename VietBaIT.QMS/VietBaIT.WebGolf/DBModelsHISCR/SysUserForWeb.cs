using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class SysUserForWeb
    {
        public string PatientEmail { get; set; }
        public string Password { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public byte PatientSex { get; set; }
        public DateTime PatientBirth { get; set; }
        public bool IsActivated { get; set; }
    }
}
