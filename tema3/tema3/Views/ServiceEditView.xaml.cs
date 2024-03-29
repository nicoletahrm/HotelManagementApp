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
using tema3.ViewModels;

namespace tema3.Views
{
    /// <summary>
    /// Interaction logic for ServicesEditView.xaml
    /// </summary>
    public partial class ServiceEditView : Window
    {
        ServiceEditViewModel vm;
        public ServiceEditView(string pageName, ObservableCollection<Models.Entity.Service> Services)
        {
            InitializeComponent();
            vm = new ServiceEditViewModel(this);
            Title = pageName;
            ListBox.ItemsSource = Services;
            this.DataContext = vm;
        }
    }
}
