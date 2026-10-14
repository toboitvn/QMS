using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LSoTayMaBenh
    {
        public int IdBenh { get; set; }
        public string UserName { get; set; }
        public string MaBenh { get; set; }
        public string ChanDoan { get; set; }
        public byte Loai { get; set; }
    }
}
