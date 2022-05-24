using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema3.Models.Entity
{
    public class ReservationRoom
    {
        public int ReservationRoomId { get; set; }
        public int ReservationId { get; set; }
        public int RoomId { get; set; }
    }
}
