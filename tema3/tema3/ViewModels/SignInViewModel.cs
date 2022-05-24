using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using tema3.Help;
using tema3.Models.Entity;
using tema3.Services;
using tema3.Views;

namespace tema3.ViewModels
{
    public class SignInViewModel
    {
        private SignInService signInService { get; set; }
        public SignInView signInView { get; set; }

        public SignInViewModel(SignInView view)
        {
            signInService = new SignInService(view);
            signInView = view;
        }

        private ICommand handleUser;
        public ICommand HandleUser
        {
            get
            {
                if (handleUser == null)
                {
                    if(signInView.Title == "Sign In")
                        handleUser = new RelayCommand(signInService.SignIn);
                    else
                        handleUser = new RelayCommand(signInService.LogIn);
                }
                return handleUser;
            }
        }
    }
}
