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
using _2SemesterProjekt.DomainView;
using _2SemesterProjekt.SummerHouseMappe;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _2SemesterProjekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void GoToSummerView(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SummerHouseView), null);
        }

        private void GoToCustomerView(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CustomerView), null);
        }

        private void GoToBookingView(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BookingView), null);
        }
        
        private void GoToInspectionView(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InspectionView), null);
        }
        private void GoToFakturaView(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FakturaView), null);
        }
    }
}
