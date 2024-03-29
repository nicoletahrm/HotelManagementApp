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
    public partial class ImageRoomEditView : Window
    {
        ImageRoomEditViewModel vm;
        public ImageRoomEditView(string pageName, ObservableCollection<Room> Rooms, ObservableCollection<Models.Entity.Image> Images)
        {
            InitializeComponent();
            vm = new ImageRoomEditViewModel(this);
            Title = pageName;
            ImagesListBox.ItemsSource = Images;
            RoomsListBox.ItemsSource = Rooms;
            this.DataContext = vm;
        }
    }
}
