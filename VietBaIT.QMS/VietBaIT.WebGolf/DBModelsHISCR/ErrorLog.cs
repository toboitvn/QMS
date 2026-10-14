using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class ErrorLog
    {
        public int ErrorId { get; set; }
        public string UserName { get; set; }
        public string FormName { get; set; }
        public DateTime? ErrorTime { get; set; }
        public string ApplicationName { get; set; }
        public string ErrorContent { get; set; }
    }
}
