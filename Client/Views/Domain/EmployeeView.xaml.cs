﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Client.Views.Domain
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EmployeeView : Page
    {
        public EmployeeView()
        {
            this.InitializeComponent();
        }

        private void CreateView(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CreateEmployee), null);
        }

        private void DeleteView(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DeleteEmployee), null);
        }

        private void UpdateView(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UpdateView), null);
        }
    }
}
