using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TDrugEnd
    {
        public int EndId { get; set; }
        public short StockId { get; set; }
        public short SignUserId { get; set; }
        public DateTime InputDate { get; set; }
        public byte Status { get; set; }
        public short ReasonId { get; set; }
        public string Createdby { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public short? ObjectTypeId { get; set; }
        public short? IdKhoa { get; set; }
    }
}
