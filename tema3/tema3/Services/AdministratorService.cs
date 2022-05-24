using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema3.Views;

namespace tema3.Services
{
    public class AdministratorService
    {
        public void EditRooms(Object sender)
        {
            EditView view = new EditView("Rooms");
            view.Show();
        }

        public void EditFacilities(Object sender)
        {
            EditView view = new EditView("Facilities");
            view.Show();
        }

        public void EditServices(Object sender)
        {
            EditView view = new EditView("Services");
            view.Show();
        }

        public void EditOffers(Object sender)
        {
            EditView view = new EditView("Offers");
            view.Show();
        }

        public void EditImages(Object sender)
        {
            EditView view = new EditView("Images");
            view.Show();
        }
    }
}
