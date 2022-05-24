using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema3.Models.Entity
{
    public class RoomFacility
    {
        public int RoomFacilityId { get; set; }
        public int RoomId { get; set; }
        public int FacilityId { get; set; }
    }
}
