using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using tema3.Models.Entity;
using tema3.Repositories;
using tema3.Views;

namespace tema3.Services
{
    public class SignInService
    {
        private readonly IGenericRepository<User> _userRepo;
        private readonly IGenericRepository<Room> _roomRepo;
        public SignInView signInView { get; set; }
        public HomeView homeView { get; set; }
        public MainWindow mainWindow { get; set; }

        public ObservableCollection<Room> Rooms;

        public SignInService(SignInView view)
        {
            signInView = view;
            _userRepo = new GenericRepository<User>(new AppDbContext());
            _roomRepo = new GenericRepository<Room>(new AppDbContext());

            var myObservableCollection = new ObservableCollection<Room>(_roomRepo.GetByCondition(u => u.IsActive == true));

            Rooms = myObservableCollection;

            homeView = new HomeView(Rooms);
        }

        public void SignIn(Object sender)
        {
            User user = new User() { Username = signInView.UsernameTextBox.Text, Password = signInView.PasswordBox.Password.ToString(), Role="Client", IsActive = true };
            _userRepo.Insert(user);
            signInView.Close();
        }

        public void LogIn(Object sender)
        {
            User user = new User() { Username = signInView.UsernameTextBox.Text, Password = signInView.PasswordBox.Password.ToString() };
            User FoundUser = _userRepo.GetByCondition(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();

            if (FoundUser.Role != "admin")
            {
                homeView.AdminButton.Visibility = Visibility.Hidden;
            }


            if (FoundUser != default)
            {
                signInView.Close();
                homeView.Show();
            }
        }
    }
}
