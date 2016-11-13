﻿using System;
using AudioSwitcher.AudioApi.CoreAudio;
using System.ComponentModel;

namespace PlatformManager
{
    public class Settings : INotifyPropertyChanged
    {
        private static Settings instance = new Settings();
        private double screenWidth;
        private double screenHeigth;
        private bool musicOn;
        private System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;

        public Settings()
        {
            screenHeigth = System.Windows.SystemParameters.PrimaryScreenHeight;
            screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            if (player.SoundLocation == "")
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "/musiikki.wav";
        }
        public static Settings Instance
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

        public double MyVolume
        {
            get
            {
                return defaultPlaybackDevice.Volume;
            }
            set
            {
                defaultPlaybackDevice.Volume = value;
            }
        }

        public bool MyMusic
        {
            get
            {
                return musicOn;
            }
            set
            {
                if (musicOn == value)
                    return;
                musicOn = value;
                if (musicOn == true)
                    player.PlayLooping();
                else if (!musicOn == true)
                    player.Stop();
            }
        }

        public double MyWidth
        {
            get
            {
                return screenWidth;
            }
            set
            {
                if (value != screenWidth)
                {
                    screenWidth = value;
                    NotifyPropertyChanged("MyWidth");
                }
            }
        }
        public double MyHeight
        {
            get
            {
                return screenHeigth;
            }
            set
            {
                if (value != screenHeigth)
                {
                    screenHeigth = value;
                    NotifyPropertyChanged("MyHeight");
                }
            }
        }

        protected void NotifyPropertyChanged(string MyProperty)
        {
            NotifyPropertyChanged(new PropertyChangedEventArgs(MyProperty));
        }

        protected void NotifyPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string MyResolution
        {
            get
            {
                return "Resolution: " + screenWidth + "x" + screenHeigth;
            }
        }
    }
}
