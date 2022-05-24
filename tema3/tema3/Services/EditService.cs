using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema3.Views;

namespace tema3.Services
{
    public class EditService
    {
        public EditView editView { get; set; }

        public EditService(EditView view)
        {
            editView = view;
        }
    }
}
