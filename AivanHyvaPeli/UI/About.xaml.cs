using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace UI
{
    /// <summary>
    /// Interaction logic for Help.xaml
    /// </summary>
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();

            StackPanel stackPanel = new StackPanel();
            stackPanel.Height = 250;
            stackPanel.Width = 550;
            Content = stackPanel;

            TextBlock headline = new TextBlock();
            headline.Text = "ABOUT";
            headline.FontSize = 24;
            headline.Foreground = new SolidColorBrush(Colors.Black);
            headline.FontFamily = new System.Windows.Media.FontFamily("Verdana");
            headline.TextAlignment = System.Windows.TextAlignment.Center;
            headline.Height = 30;
            headline.Width = 100;
            headline.Margin = new Thickness(5);
            stackPanel.Children.Add(headline);


            TextBlock aboutInfo = new TextBlock();
            aboutInfo.Text = "This software was created as practical work for the course \"KLO\".";
            aboutInfo.FontSize = 12;
            aboutInfo.Foreground = new SolidColorBrush(Colors.Black);
            aboutInfo.FontFamily = new System.Windows.Media.FontFamily("Verdana");
            aboutInfo.TextAlignment = System.Windows.TextAlignment.Center;
            aboutInfo.Height = 15;
            aboutInfo.Width = 500;
            aboutInfo.Margin = new Thickness(5);
            stackPanel.Children.Add(aboutInfo);


            TextBlock aboutInfo2 = new TextBlock();
            aboutInfo2.Text = "The purpose of this software is to demonstrate using WPF for UI development.";
            aboutInfo2.FontSize = 12;
            aboutInfo2.Foreground = new SolidColorBrush(Colors.Black);
            aboutInfo2.FontFamily = new System.Windows.Media.FontFamily("Verdana");
            aboutInfo2.TextAlignment = System.Windows.TextAlignment.Center;
            aboutInfo2.Height = 15;
            aboutInfo2.Width = 500;
            aboutInfo2.Margin = new Thickness(5);
            stackPanel.Children.Add(aboutInfo2);

            TextBlock aboutInfo3 = new TextBlock();
            aboutInfo3.Text = "The software isn't meant for resolutions lower than 800x600.";
            aboutInfo3.FontSize = 12;
            aboutInfo3.Foreground = new SolidColorBrush(Colors.Black);
            aboutInfo3.FontFamily = new System.Windows.Media.FontFamily("Verdana");
            aboutInfo3.TextAlignment = System.Windows.TextAlignment.Center;
            aboutInfo3.Height = 15;
            aboutInfo3.Width = 500;
            aboutInfo3.Margin = new Thickness(5);
            stackPanel.Children.Add(aboutInfo3);

            TextBlock aboutInfo4 = new TextBlock();
            aboutInfo4.Text = "© Jari Hyvönen & Juho Toratti";
            aboutInfo4.FontSize = 12;
            aboutInfo4.Foreground = new SolidColorBrush(Colors.Black);
            aboutInfo4.FontFamily = new System.Windows.Media.FontFamily("Verdana");
            aboutInfo4.TextAlignment = System.Windows.TextAlignment.Center;
            aboutInfo4.Height = 15;
            aboutInfo4.Width = 500;
            aboutInfo4.Margin = new Thickness(5);
            stackPanel.Children.Add(aboutInfo4);

            Button button = new Button();
            button.Content = "Back";
            button.Height = 40;
            button.Width = 80;
            button.FontSize = 20;
            button.Margin = new Thickness(20);
            button.Click += Back;
            stackPanel.Children.Add(button);
        }


        void Back(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}



