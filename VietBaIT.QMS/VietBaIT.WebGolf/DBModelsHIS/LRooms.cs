using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LRooms
    {
        public LRooms()
        {
            LBeds = new HashSet<LBeds>();
        }

        public short RoomId { get; set; }
        public string RoomCode { get; set; }
        public string RoomName { get; set; }
        public short DepartmentId { get; set; }
        public int RoomFee { get; set; }
        public string SDesc { get; set; }
        public byte? HienThi { get; set; }
        public short? Stt { get; set; }

        public virtual LDepartments Department { get; set; }
        public virtual ICollection<LBeds> LBeds { get; set; }
    }
}
