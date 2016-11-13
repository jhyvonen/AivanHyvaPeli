﻿using PlatformManager;
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

namespace UI
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class SettingsView : Window
    {
        public SettingsView()
        {
            InitializeComponent();
            DataContext = Settings.Instance;
        }

        private void VolumeSlide_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Settings settings = new Settings();
            settings.MyVolume = currentVolume.Value;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.MyMusic = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.MyMusic = false;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

        private void setRes_800x600(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.MyWidth = 800;
            settings.MyHeight = 600;
        }

        private void setRes_1024x768(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.MyWidth = 1024;
            settings.MyHeight = 768;
        }

        private void setRes_1280x720(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.MyWidth = 1280;
            settings.MyHeight = 720;
        }

        private void setRes_1600x900(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.MyWidth = 1600;
            settings.MyHeight = 900;
        }

        private void setRes_1920x1080(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.MyWidth = 1920;
            settings.MyHeight = 1080;
        }
    }
}