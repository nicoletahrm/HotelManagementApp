using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema3.Models.Entity;
using tema3.Repositories;
using tema3.Views;

namespace tema3.Services
{
    public class AdministratorService
    {
        private readonly IGenericRepository<Room> _roomRepo;

        public ObservableCollection<Room> Rooms;

        public AdministratorService()
        {
            _roomRepo = new GenericRepository<Room>(new AppDbContext());
        }
        public void EditRooms(Object sender)
        {
            var myObservableCollection = new ObservableCollection<Room>(_roomRepo.GetAll());

            Rooms = myObservableCollection;

            EditView view = new EditView("Rooms", Rooms);
            view.Show();
        }

        public void EditFacilities(Object sender)
        {
            // EditView view = new EditView("Facilities");
            //view.Show();
        }

        public void EditServices(Object sender)
        {
            //EditView view = new EditView("Services");
            //view.Show();
        }

        public void EditOffers(Object sender)
        {
            //EditView view = new EditView("Offers");
            //view.Show();
        }

        public void EditImages(Object sender)
        {
            //EditView view = new EditView("Images");
            //view.Show();
        }
    }
}
