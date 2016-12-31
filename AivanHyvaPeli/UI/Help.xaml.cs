using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace UI
{
    /// <summary>
    /// Interaction logic for Help.xaml
    /// </summary>
    public partial class Help : Window
    {
        public Help()
        {
            InitializeComponent();

            StackPanel stackPanel = new StackPanel();
            stackPanel.Height = 280;
            stackPanel.Width = 500;
            Content = stackPanel;

            TextBlock headline = new TextBlock();
            headline.Text = "HELP";
            headline.FontSize = 24;
            headline.Foreground = new SolidColorBrush(Colors.Black);
            headline.FontFamily = new System.Windows.Media.FontFamily("Verdana");
            headline.TextAlignment = System.Windows.TextAlignment.Center;
            headline.Height = 30;
            headline.Width = 100;
            headline.Margin = new Thickness(5);
            stackPanel.Children.Add(headline);


            TextBlock helpText = new TextBlock();
            helpText.Text = "By pressing 'Start game' your game will start";
            helpText.FontSize = 12;
            helpText.Foreground = new SolidColorBrush(Colors.Black);
            helpText.FontFamily = new System.Windows.Media.FontFamily("Verdana");
            helpText.TextAlignment = System.Windows.TextAlignment.Center;
            helpText.Height = 15;
            helpText.Width = 450;
            helpText.Margin = new Thickness(5);
            stackPanel.Children.Add(helpText);


            TextBlock helpText2 = new TextBlock();
            helpText2.Text = "By pressing 'Load game' your game continues from last savepoint";
            helpText2.FontSize = 12;
            helpText2.Foreground = new SolidColorBrush(Colors.Black);
            helpText2.FontFamily = new System.Windows.Media.FontFamily("Verdana");
            helpText2.TextAlignment = System.Windows.TextAlignment.Center;
            helpText2.Height = 15;
            helpText2.Width = 450;
            helpText2.Margin = new Thickness(5);
            stackPanel.Children.Add(helpText2);

            TextBlock helpText3 = new TextBlock();
            helpText3.Text = "By pressing 'Setting' you can change resolution, sound etc.";
            helpText3.FontSize = 12;
            helpText3.Foreground = new SolidColorBrush(Colors.Black);
            helpText3.FontFamily = new System.Windows.Media.FontFamily("Verdana");
            helpText3.TextAlignment = System.Windows.TextAlignment.Center;
            helpText3.Height = 15;
            helpText3.Width = 450;
            helpText3.Margin = new Thickness(5);
            stackPanel.Children.Add(helpText3);

            TextBlock helpText4 = new TextBlock();
            helpText4.Text = "By pressing 'Exit' you close the game";
            helpText4.FontSize = 12;
            helpText4.Foreground = new SolidColorBrush(Colors.Black);
            helpText4.FontFamily = new System.Windows.Media.FontFamily("Verdana");
            helpText4.TextAlignment = System.Windows.TextAlignment.Center;
            helpText4.Height = 15;
            helpText4.Width = 450;
            helpText4.Margin = new Thickness(5);
            stackPanel.Children.Add(helpText4);

            Button button = new Button();
            button.Content = "Back";
            button.Height = 50;
            button.Width = 100;
            button.FontSize = 24;
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



