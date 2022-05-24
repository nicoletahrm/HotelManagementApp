using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema3.Models.Entity
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomType { get; set; }
        public int Price { get; set; }
        public int NumberOfRooms { get; set; }
        public bool IsActive { get; set; }
    }
}
