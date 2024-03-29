﻿using System;
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
    /// Interaction logic for FacilityRoomEditView.xaml
    /// </summary>
    public partial class FacilityRoomEditView : Window
    {
        FacilityRoomEditViewModel vm;
        public FacilityRoomEditView(string pageName, ObservableCollection<Room> Rooms, ObservableCollection<Facility> Facilities)
        {
            InitializeComponent();
            vm = new FacilityRoomEditViewModel(this);
            Title = pageName;
            FacilitiesListBox.ItemsSource = Facilities;
            RoomsListBox.ItemsSource = Rooms;
            this.DataContext = vm;
        }
    }
}
