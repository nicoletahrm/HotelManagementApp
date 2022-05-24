using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using tema3.ViewModels;

namespace tema3.Views
{
    /// <summary>
    /// Interaction logic for SignInView.xaml
    /// </summary>
    public partial class SignInView : Window
    {
        SignInViewModel vm;
        public SignInView(string pageName)
        {
            InitializeComponent();
            vm = new SignInViewModel(this);
            this.DataContext = vm;
            Title = pageName;
            AccountButton.Content = pageName;
        }
    }
}
