using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema3.Models.Entity;
using tema3.Repositories;
using tema3.ViewModels;
using tema3.Views;

namespace tema3.Services
{
    public class MainWindowService
    {
        public ObservableCollection<Room> Rooms;

        private readonly IGenericRepository<Room> _roomRepo;

        public MainWindowService()
        {
            _roomRepo = new GenericRepository<Room>(new AppDbContext());
        }

        public void CreateAccount(Object sender)
        {
            SignInView view = new SignInView("Sign In");
            view.Show();
        }

        public void LogIn(Object sender)
        {
            SignInView view = new SignInView("Log In");
            view.Show();
        }

        public void WithoutAccount(Object sender)
        {
            var myObservableCollection = new ObservableCollection<Room>(_roomRepo.GetByCondition(u => u.IsActive == true));
            Rooms = myObservableCollection;

            HomeView view = new HomeView(Rooms);
            view.AdminButton.Visibility = System.Windows.Visibility.Hidden;

            view.Show();
        }
    }
}
