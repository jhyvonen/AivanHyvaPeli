using PlatformManager;
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
            if(Settings.MyVolume != null)
                currentVolume = Settings.MyVolume;
            if (Settings.MyVolume != null)
                checkBox = Settings.MyMusic;
            InitializeComponent();
        }

        private void VolumeSlide_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Settings.MyVolume = currentVolume;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Settings.MyMusic = checkBox;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Settings.MyMusic = checkBox;
        }
    }
}
