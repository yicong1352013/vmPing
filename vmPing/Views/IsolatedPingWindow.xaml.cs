﻿using System.Windows;
using vmPing.Classes;

namespace vmPing.Views
{
    /// <summary>
    /// Interaction logic for IsolatedPingWindow.xaml
    /// </summary>
    public partial class IsolatedPingWindow : Window
    {
        public IsolatedPingWindow(Probe pingItem)
        {
            InitializeComponent();
            pingItem.IsolatedWindow = this;
            DataContext = pingItem;
        }
    }
}
