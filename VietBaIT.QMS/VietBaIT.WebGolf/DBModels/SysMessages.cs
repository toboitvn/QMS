using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class SysMessages
    {
        public string MsgCode { get; set; }
        public string VnMsgContent { get; set; }
        public string EnMsgContent { get; set; }
        public string VnMsgTitle { get; set; }
        public string EnMsgTitle { get; set; }
        public string MsgType { get; set; }
        public string ActionType { get; set; }
        public short SubsystemId { get; set; }
        public string SDesc { get; set; }
    }
}
