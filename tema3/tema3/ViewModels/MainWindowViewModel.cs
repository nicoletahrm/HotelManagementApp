using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using tema3.Help;
using tema3.Services;

namespace tema3.ViewModels
{
    public class MainWindowViewModel
    {
        private MainWindowService MainWindowService { get; set; }

        public MainWindowViewModel()
        {
            MainWindowService = new MainWindowService();
        }

        private ICommand createAccount;
        public ICommand CreateAccount
        {
            get
            {
                if (createAccount == null)
                {
                    createAccount = new RelayCommand(MainWindowService.CreateAccount);
                }
                return createAccount;
            }
        }

        private ICommand logIn;
        public ICommand LogIn
        {
            get
            {
                if (logIn == null)
                {
                    logIn = new RelayCommand(MainWindowService.LogIn);
                }
                return logIn;
            }
        }
    }
}
