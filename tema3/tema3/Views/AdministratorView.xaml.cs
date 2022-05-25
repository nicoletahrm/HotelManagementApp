﻿using System;
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
    public partial class AdministratorView : Window
    {
        AdministratorViewModel vm;
        public AdministratorView()
        {
            InitializeComponent();
            vm = new AdministratorViewModel();
            this.DataContext = vm;
        }
    }
}
