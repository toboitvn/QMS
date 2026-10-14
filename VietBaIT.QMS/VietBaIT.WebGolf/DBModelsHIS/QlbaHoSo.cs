using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class QlbaHoSo
    {
        public int IdHoSo { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public string MaBaNoiTru { get; set; }
        public DateTime? NgayNhanBenhAn { get; set; }
        public short DepartmentId { get; set; }
        public short? StaffId { get; set; }
        public short? SoSttBenhAn { get; set; }
        public short? SoToBenhAn { get; set; }
        public short? IdLoaiBenhAn { get; set; }
        public string GhiChu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string MaBaNoiTruKhoaNgoai { get; set; }
        public string MaCoSo { get; set; }
    }
}
