using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema3.ViewModels;
using tema3.Views;

namespace tema3.Services
{
    public class MainWindowService
    {
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
            HomeView view = new HomeView();
            view.Show();
        }
    }
}
