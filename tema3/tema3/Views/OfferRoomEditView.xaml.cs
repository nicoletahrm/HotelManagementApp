using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using tema3.Models.Entity;
using tema3.ViewModels;

namespace tema3.Views
{
    /// <summary>
    /// Interaction logic for OfferRoomEditView.xaml
    /// </summary>
    public partial class OfferRoomEditView : Window
    {
        OfferRoomEditViewModel vm;
        public OfferRoomEditView(string pageName, ObservableCollection<Room> Rooms, ObservableCollection<Offer> Offers)
        {
            InitializeComponent();
            vm = new OfferRoomEditViewModel(this);
            Title = pageName;
            OffersListBox.ItemsSource = Offers;
            RoomsListBox.ItemsSource = Rooms;
            this.DataContext = vm;
        }
    }
}
