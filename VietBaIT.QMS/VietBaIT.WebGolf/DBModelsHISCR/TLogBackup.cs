using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TLogBackup
    {
        public decimal LogId { get; set; }
        public string LogSource { get; set; }
        public string LogFunctionName { get; set; }
        public short? LogActionId { get; set; }
        public string LogUser { get; set; }
        public string LogInfo { get; set; }
        public string LogIp { get; set; }
        public string LogMacAddress { get; set; }
        public DateTime LogTime { get; set; }
    }
}
