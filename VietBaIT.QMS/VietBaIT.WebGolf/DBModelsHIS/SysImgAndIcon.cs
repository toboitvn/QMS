using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class SysImgAndIcon
    {
        public int Id { get; set; }
        public string SFileName { get; set; }
        public string SFilePath { get; set; }
        public byte[] Data { get; set; }
    }
}
