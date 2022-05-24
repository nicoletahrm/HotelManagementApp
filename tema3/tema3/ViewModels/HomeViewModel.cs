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
    public class HomeViewModel
    {
        private HomeService homeService { get; set; }
        public HomeViewModel()
        {
            homeService = new HomeService();
        }

        private ICommand administrator;
        public ICommand Administrator
        {
            get
            {
                if (administrator == null)
                {
                    administrator = new RelayCommand(homeService.Administrator);
                }
                return administrator;
            }
        }
    }
}
