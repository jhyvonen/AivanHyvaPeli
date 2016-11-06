using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PlatformManager
{
    public class Settings
    {
        private static Settings instance;
        private static Slider volume;
        private static CheckBox musicOn;
        private static System.Media.SoundPlayer player = new System.Media.SoundPlayer();


        private Settings() { }
        private static Settings Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Settings();
                }
                return instance;
            }
        }

        public static Slider MyVolume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
            }
        }
        public static CheckBox MyMusic
        {
            get
            {
                return musicOn;
            }
            set
            {
                if (player.SoundLocation == "")
                    player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "/musiikki.wav";
                musicOn = value;
                if (musicOn.IsChecked == true)
                    player.PlayLooping();
                else if (!musicOn.IsChecked == true)
                    player.Stop();

            }
        }
    }
}
