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
using System.Collections.ObjectModel;

namespace tema3.Views
{
    public partial class ImageEditView : Window
    {
        ImageEditViewModel vm;
        public ImageEditView(string pageName, ObservableCollection<Models.Entity.Image> Images)
        {
            InitializeComponent();
            vm = new ImageEditViewModel(this);
            Title = pageName;
            ListBox.ItemsSource = Images;
            this.DataContext = vm;
        }
    }
}
