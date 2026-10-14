using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LListSorting
    {
        public short SortingId { get; set; }
        public string SortingName { get; set; }
        public string SortingTableName { get; set; }
        public string SortingIdColumn { get; set; }
        public string SortingSelectColumn { get; set; }
        public string SortingGroupColumn { get; set; }
        public string SortingOrderColumn { get; set; }
        public string SortingWhere { get; set; }
        public short? SortingOrder { get; set; }
    }
}
