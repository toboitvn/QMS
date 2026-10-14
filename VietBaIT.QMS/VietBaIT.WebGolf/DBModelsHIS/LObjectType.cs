using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LObjectType
    {
        public LObjectType()
        {
            LObjectTypeService = new HashSet<LObjectTypeService>();
        }

        public short ObjectTypeId { get; set; }
        public string ObjectTypeName { get; set; }
        public short InsuranceLevel { get; set; }
        public byte ViewType { get; set; }
        public short IntOrder { get; set; }
        public decimal DiscountCorrectLine { get; set; }
        public decimal? DiscountDiscorrectLine { get; set; }
        public byte ObjectTypeType { get; set; }
        public string SDesc { get; set; }
        public string ObjectTypeCode { get; set; }
        public byte? KeTaiQthuoc { get; set; }
        public string TenDonThuoc { get; set; }
        public byte? ThanhToanClsTiepDon { get; set; }
        public byte? ThanhToanKhamTiepDon { get; set; }
        public short? PtramBhytMoi { get; set; }

        public virtual ICollection<LObjectTypeService> LObjectTypeService { get; set; }
    }
}
