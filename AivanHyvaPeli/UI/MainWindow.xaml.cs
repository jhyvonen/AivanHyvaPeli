using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace XAMLVsCode
{
    /// <summary> 
    /// Interaction logic for MainWindow.xaml 
    /// </summary> 

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            // Create the StackPanel 
            StackPanel stackPanel = new StackPanel();
            stackPanel.Height = 900;
            stackPanel.Width = 1600;
            Content = stackPanel;
            

            // Create the TextBlock 
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "Aivan Hyvä Peli";
            textBlock.FontSize = 64;
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
             "D:/Projects/AivanHyvaPeli/tausta.png")));
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
            return button;
        }
    }
}