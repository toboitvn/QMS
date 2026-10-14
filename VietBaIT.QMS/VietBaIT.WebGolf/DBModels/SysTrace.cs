using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class SysTrace
    {
        public long Id { get; set; }
        public string BranchId { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string IpAddress { get; set; }
        public string ComputerName { get; set; }
        public string AccountName { get; set; }
        public string Dllname { get; set; }
        public string SubSystemName { get; set; }
        public int FunctionId { get; set; }
        public string FunctionName { get; set; }
        public string TableName { get; set; }
        public string Desc { get; set; }
        public short Lot { get; set; }
    }
}
