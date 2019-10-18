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
        readonly string[] legalCharacters = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "+", "-", "*", "/", "%"};
        static CalcExecution calc = new CalcExecution();
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
            if (NumberBox.Text.Equals("0"))
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
                NumberBox.Text = "0";
            }
            
        }

        // Generic eventhandeler to input numbers to text box
        private void Numpad_Input(object sender, RoutedEventArgs e)
        {
            string tempNumber = sender.ToString();
            if (!(NumberBox.IsFocused))
            {
                NumberBox_GotFocus(null, null);
            }
            NumberBox.Text += tempNumber.Substring(tempNumber.Length - 1);
            return;
        }

        //Button eventhandeler to clear the current entry
        private void CleanEntry_Click(object sender, RoutedEventArgs e)
        {
            NumberBox.Text = "";
            NumberBox_LostFocus(null, null);
        }

        // Eventhandeller to check if any unlegal characters are inputed into text box
        private void NumberBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            for (int i = NumberBox.Text.Length - 1; i >= 0; i--)
            {
                string LastByte = NumberBox.Text.Substring(i, 1);
                if (NumberBox.Text.Length != 0 && !(legalCharacters.Contains(LastByte)))
                {
                    NumberBox.Text = NumberBox.Text.Replace(LastByte, "");
                }
            }
            }
            

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NumberBox.Focus();
        }
    }
}

namespace Miniraknare
{
    public class CalcExecution : Calc
    {

    }
}