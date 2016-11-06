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
    /// Interaction logic for Help.xaml
    /// </summary>
    public partial class Help : Window
    {
        public Help()
        {
            InitializeComponent();

            StackPanel stackPanel = new StackPanel();
            stackPanel.Height = 450;
            stackPanel.Width = 900;
            Content = stackPanel;

            TextBlock textBlock = new TextBlock();
            textBlock.Text = "HELP";
            textBlock.FontSize = 24;
            textBlock.Foreground = new SolidColorBrush(Colors.Pink);
            textBlock.FontFamily = new System.Windows.Media.FontFamily("Verdana");
            textBlock.TextAlignment = System.Windows.TextAlignment.Center;
            textBlock.Height = 40;
            textBlock.Width = 100;
            textBlock.Margin = new Thickness(5);
            stackPanel.Children.Add(textBlock);

            TextBlock helpText = new TextBlock();
            helpText.Text = "Your god can't help you now";
            helpText.FontSize = 24;
            helpText.Foreground = new SolidColorBrush(Colors.Black);
            helpText.FontFamily = new System.Windows.Media.FontFamily("Helvetica MS");
            helpText.TextAlignment = System.Windows.TextAlignment.Center;
            helpText.Height = 40;
            helpText.Width = 250;
            helpText.Margin = new Thickness(5);
            stackPanel.Children.Add(helpText);

            var myParentCanvas = new Canvas();
            myParentCanvas.Width = 400;
            myParentCanvas.Height = 400;

            var myCanvas1 = new Canvas();
            myCanvas1.Background = Brushes.Red;
            myCanvas1.Height = 100;
            myCanvas1.Width = 100;
            Canvas.SetTop(myCanvas1, 0);
            Canvas.SetLeft(myCanvas1, 0);

            Button button = new Button();
            button.Content = "Jaa";
            button.Height = 40;
            button.Width = 150;
            button.FontSize = 24;
            button.Margin = new Thickness(20);
            stackPanel.Children.Add(button);

            Button button2 = new Button();
            button2.Content = "OK.";
            button2.Height = 40;
            button2.Width = 150;
            button2.FontSize = 24;
            button2.Margin = new Thickness(20);
            stackPanel.Children.Add(button2);

            myParentCanvas.Children.Add(myCanvas1);

            this.Content = myParentCanvas;
        }
    }
}
