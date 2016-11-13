﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using PlatformManager;

namespace UI
{
    public partial class MainWindow : Window
    {
        StackPanel stackPanel;
        public MainWindow()
        {
            Settings settings = new Settings();
            InitializeComponent();
            DataContext = Settings.Instance;
            // Create the StackPanel 
            stackPanel = new StackPanel();
            stackPanel.Height = settings.MyHeight;
            stackPanel.Width = settings.MyWidth;
            Content = stackPanel;
            settings.PropertyChanged += setResolution;
            

            // Create the TextBlock 
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "Aivan Hyvä Peli";
            textBlock.FontSize = 64;
            textBlock.Foreground = new SolidColorBrush(Colors.White);
            textBlock.FontFamily = new System.Windows.Media.FontFamily("Verdana");
            textBlock.TextAlignment = System.Windows.TextAlignment.Center;
            textBlock.Height = 200;
            textBlock.Width = 500;
            textBlock.Margin = new Thickness(5);
            stackPanel.Children.Add(textBlock);

            // Create the Buttons
            stackPanel.Children.Add(mainMenuButtonMaker("START GAME"));
            stackPanel.Children.Add(mainMenuButtonMaker("LOAD GAME"));
            stackPanel.Children.Add(mainMenuButtonMaker("SETTINGS"));
            stackPanel.Children.Add(mainMenuButtonMaker("HELP"));
            stackPanel.Children.Add(mainMenuButtonMaker("EXIT"));
            
            ImageBrush brush = new ImageBrush(new BitmapImage(new Uri(
             AppDomain.CurrentDomain.BaseDirectory + "/tausta.jpg")));
            stackPanel.Background = brush;
        }

        public Button mainMenuButtonMaker(string buttonName)
        {
            Button button = new Button();
            button.Content = buttonName;
            button.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            button.Height = 40;
            button.Width = 150;
            button.FontSize = 24;
            button.Margin = new Thickness(20);
            switch(buttonName)
            {
                case "START GAME":
                    button.Click += startGame;
                    break;
                case "LOAD GAME":
                    button.Click += loadGame;
                    break;
                case "SETTINGS":
                    button.Click += settings;
                    break;
                case "HELP":
                    button.Click += help;
                    break;
                case "EXIT":
                    button.Click += exit;
                    break;
            }
            return button;
        }

        private void startGame(object sender, EventArgs e)
        {
            return;
        }
        private void loadGame(object sender, EventArgs e)
        {
            return;
        }
        private void settings(object sender, EventArgs e)
        {
            SettingsView settings = new SettingsView();
            settings.Show();
        }
        private void help(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
        private void exit(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void setResolution(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            stackPanel.Height = settings.MyHeight;
            stackPanel.Width = settings.MyWidth;
        }
    }
}