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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowsApplication
{
    /// <summary>
    /// Interaction logic for OldView.xaml
    /// </summary>
    public partial class OldView : Window
    {
        public OldView()
        {
            InitializeComponent();
        }

        private void TextChangedHandler(object sender, TextChangedEventArgs e)
        {
            if (MessageTextBox.Text.Equals("") == true)
                SendButton.IsEnabled = false;
            else
                SendButton.IsEnabled = true;
        }

        private void ClickHander(object sender, RoutedEventArgs e)
        {
            HistoryTextBox.Text += "You: " + MessageTextBox.Text + "\n";
            MessageTextBox.Text = String.Empty;
        }

        private void KeyUpHandler(object sender, KeyEventArgs e)
        {
            //TMP
            Console.WriteLine("Test key");

            if (e.Key == Key.Enter)
            {
                HistoryTextBox.Text += "You: " + MessageTextBox.Text + "\n";
                MessageTextBox.Text = String.Empty;
            }
        }
    }
}
