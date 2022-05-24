using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema3.Models.Entity;
using tema3.Repositories;
using tema3.Views;

namespace tema3.Services
{
    public class SignInService
    {
        private readonly IGenericRepository<User> _userRepo;
        public SignInView signInView { get; set; }
        public HomeView homeView { get; set; }
        public MainWindow mainWindow { get; set; }

        public SignInService(SignInView view)
        {
            signInView = view;
            _userRepo = new GenericRepository<User>(new AppDbContext());
            homeView = new HomeView();
        }

        public void SignIn(Object sender)
        {
            User user = new User() { Username = signInView.UsernameTextBox.Text, Password = signInView.PasswordTextBox.Text, Role="Client", IsActive = true };
            _userRepo.Insert(user);
            signInView.Close();
        }

        public void LogIn(Object sender)
        {
            User user = new User() { Username = signInView.UsernameTextBox.Text, Password = signInView.PasswordTextBox.Text };
            User FoundUser = _userRepo.GetByCondition(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
            
            if (FoundUser != default)
            {
                signInView.Close();
                homeView.Show();
            }
        }
    }
}
