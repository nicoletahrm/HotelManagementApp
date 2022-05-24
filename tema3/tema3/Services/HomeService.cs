using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema3.Views;

namespace tema3.Services
{
    public class HomeService
    {
        public void Administrator(Object sender)
        {
            AdministratorView view = new AdministratorView();
            view.Show();
        }
    }
}
