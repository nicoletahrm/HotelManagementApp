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

        private string _roomType;
        public string RoomType {
            get => _roomType;
            set
            {
                _roomType = value;
                NotifyPropertyChanged(nameof(_roomType));
            }
        }

        private int _price;
        public int Price {
            get => _price;
            set
            {
                _price = value;
                NotifyPropertyChanged(nameof(_price));
            }
        }

        private int _numberOfRooms;
        public int NumberOfRooms {
            get => _numberOfRooms;
            set
            {
                _numberOfRooms = value;
                NotifyPropertyChanged(nameof(_numberOfRooms));
            }
        }

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set
            {
                _isActive = value;
                NotifyPropertyChanged(nameof(_isActive));
            }
        }
        public List<Reservation> Reservations { get; set; }
        public List<Facility> Facilities { get; set; }
        public List<Image> Images { get; set; }
        public List<Offer> Offers { get; set; }

    }
}
