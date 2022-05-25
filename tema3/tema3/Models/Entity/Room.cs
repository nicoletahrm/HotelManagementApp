using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema3.Help;

namespace tema3.Models.Entity
{
    public class Room : NotifyPropertyChangedBase
    {
        public int RoomId { get; set; }
        public string RoomType { get; set; }
        public int Price { get; set; }
        public int NumberOfRooms { get; set; }
        public bool IsActive { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<Facility> Facilities { get; set; }
        public List<Image> Images { get; set; }
        public List<Offer> Offers { get; set; }

        public Room()
        {
            Facilities = new List<Facility>();
            Offers = new List<Offer>();
            Images = new List<Image>();
            Reservations = new List<Reservation>();
        }

    }
}
