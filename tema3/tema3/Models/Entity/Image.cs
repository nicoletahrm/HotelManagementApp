using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema3.Models.Entity
{
    public class Image
    {
        public int ImageId { get; set; }
        public string Path { get; set; }
        public bool IsActive { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
