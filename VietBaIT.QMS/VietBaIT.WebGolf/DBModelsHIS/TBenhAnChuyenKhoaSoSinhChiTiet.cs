using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TBenhAnChuyenKhoaSoSinhChiTiet
    {
        public long? Id { get; set; }
        public string Diem { get; set; }
        public string SuDanNoLongNguc { get; set; }
        public string CoKeoCoLienSuon { get; set; }
        public string CoKeoCoMuiUc { get; set; }
        public string DapCanhMui { get; set; }
        public string RenRi { get; set; }
        public long Ids { get; set; }
    }
}
