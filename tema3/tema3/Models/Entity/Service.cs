using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema3.Models.Entity
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public List<Reservation> Reservations { get; set; }
        public bool IsActive { get; set; }
    }
}
