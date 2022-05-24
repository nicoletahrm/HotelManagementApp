using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema3.Models.Entity
{
    public class Offer
    {
        public int OfferId { get; set; }
        public string OfferType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int OfferPrice { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
