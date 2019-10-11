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

namespace Miniraknare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Execute_Click(object sender, RoutedEventArgs e)
        {

        }

        // Applies/Removes a placeholder from text box when focus changes and there's no user written value.

        private void NumberBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NumberBox.Text.Equals("Write here..."))
            {
                NumberBox.Text = "";
                NumberBox.Foreground = new SolidColorBrush(Color.FromRgb(57,57,57));
            }
        }

        private void NumberBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if(NumberBox.Text == "")
            {
                NumberBox.Foreground = new SolidColorBrush(Color.FromRgb(105,105,105));
                NumberBox.Text = "Write here...";
            }
            
        }

        private void Numpad_Input(object sender, RoutedEventArgs e)
        {
            String a = sender.ToString();
            MessageBox.Show(a.Substring(a.Length - 2));
        }
    }
}

namespace Miniraknare
{
    public class QueryHistory
    {

    }
}