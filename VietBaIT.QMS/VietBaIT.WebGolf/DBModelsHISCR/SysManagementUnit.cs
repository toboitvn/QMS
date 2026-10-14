using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class SysManagementUnit
    {
        public string PkSBranchId { get; set; }
        public string MaCoSo { get; set; }
        public string SName { get; set; }
        public string SParentBranchName { get; set; }
        public string FpSUpBranchId { get; set; }
        public int? IntLevel { get; set; }
        public string SAddress { get; set; }
        public string SPhone { get; set; }
        public string SBussinessPhone { get; set; }
        public string SHotPhone { get; set; }
        public string SDutyPhone { get; set; }
        public string SFax { get; set; }
        public string SEmail { get; set; }
        public string STaxCode { get; set; }
        public string SAccountId { get; set; }
        public string SRepresentative { get; set; }
        public string SPosition { get; set; }
        public string SProxyNumber { get; set; }
        public DateTime? TDateMandate { get; set; }
        public string SMandateUnitName { get; set; }
        public string SMandateUnitAddress { get; set; }
        public DateTime? TInvalidDate { get; set; }
        public DateTime? TInputDate { get; set; }
        public string STyper { get; set; }
        public string SBankCode { get; set; }
        public string SLandSurveyUnitCode { get; set; }
        public string Website { get; set; }
        public byte[] Logo { get; set; }
    }
}
