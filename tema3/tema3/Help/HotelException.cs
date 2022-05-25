using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema3.Help
{
    class HotelException : ApplicationException
    {
        public HotelException(string message) : base(message)
        {

        }
    }
}
