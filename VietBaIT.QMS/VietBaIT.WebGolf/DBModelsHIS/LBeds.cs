using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LBeds
    {
        public LBeds()
        {
            LGiuongLoaiBg = new HashSet<LGiuongLoaiBg>();
        }

        public short BedId { get; set; }
        public string BedCode { get; set; }
        public string BedName { get; set; }
        public short DepartmentId { get; set; }
        public short RoomId { get; set; }
        public decimal BedFee { get; set; }
        public short MaxPeople { get; set; }
        public string SDesc { get; set; }
        public short? UnitId { get; set; }
        public byte? IsTuNguyen { get; set; }
        public byte? HienThi { get; set; }
        public short? Stt { get; set; }
        public string TenBhyt { get; set; }

        public virtual LRooms Room { get; set; }
        public virtual ICollection<LGiuongLoaiBg> LGiuongLoaiBg { get; set; }
    }
}
