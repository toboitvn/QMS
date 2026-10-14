using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TPhieutruyenmau
    {
        public int IdTruyenmau { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public int? DepartmentId { get; set; }
        public int? RoomId { get; set; }
        public int? BedId { get; set; }
        public string DinhNhom { get; set; }
        public string SoPhanungcheo { get; set; }
        public string XnChandoan { get; set; }
        public string XnLoaiChepham { get; set; }
        public int? XnSoluong { get; set; }
        public string XnMachepham { get; set; }
        public DateTime? XnDieuche { get; set; }
        public DateTime? XnHandung { get; set; }
        public string XnPatientAbo { get; set; }
        public string XnPatientRh { get; set; }
        public string XnChephammauAbo { get; set; }
        public string XnChephammauRh { get; set; }
        public string XnKhac { get; set; }
        public string XnMoitruongmuoiOng1 { get; set; }
        public string XnMoitruongmuoiOng2 { get; set; }
        public string XnKhangglobulinOng1 { get; set; }
        public string XnKhangglobulinOng2 { get; set; }
        public DateTime? XnNgay { get; set; }
        public int? XnBacsi { get; set; }
        public int? LsLantruyen { get; set; }
        public string LsDinhnhomChepham { get; set; }
        public string LsDinhnhomNguoibenh { get; set; }
        public string LsPhanungcheoTaigiuong { get; set; }
        public DateTime? LsNgaygioTruyen { get; set; }
        public DateTime? LsNgaygioNgung { get; set; }
        public int? LsSoluongThucte { get; set; }
        public string LsNhanxet { get; set; }
        public int? IdBsydtri { get; set; }
        public int? YtathuchienTdtm { get; set; }
        public bool? TrangthaiIn { get; set; }
        public int? LanIn { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
