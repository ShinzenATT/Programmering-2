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
        readonly string[] legalCharacters = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ",", "+", "-", "*", "/", "%"};
        readonly static CalcExecution calc = new CalcExecution();

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

        //Button eventhandeler to clear the current or previous entry
        private void CleanEntry_Click(object sender, RoutedEventArgs e)
        {
            if (NumberBox.Text == "0" || NumberBox.Text == "") {
                calc.RemovePreviousObject();
                QueryTextBlock.Text = calc.ToString();
            }
            else
            {
                NumberBox.Text = "";
                NumberBox_LostFocus(null, null);
            }
        }

        // Eventhandeller to check if any unlegal characters are inputed into text box or if any specials characters are inputed
        private void NumberBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            for (int i = NumberBox.Text.Length - 1; i >= 0; i--)
            {
                string LastByte = NumberBox.Text.Substring(i, 1);
                if (NumberBox.Text.Length != 0 && !(legalCharacters.Contains(LastByte)))
                {
                    NumberBox.Text = NumberBox.Text.Replace(LastByte, "");
                }
                else
                {
                    // Checks for a arithmatic character
                    bool stop = false;
                    switch (LastByte)
                    {
                        case "/":
                        case "+":
                        case "-":
                        case "*":
                            double temp = 0;
                            try
                            {
                                temp = double.Parse(NumberBox.Text.Substring(0, i));
                            }
                            catch { }
            
                            calc.AddItemsToQueryHistory(temp, char.Parse(LastByte));
                            if (NumberBox.Text.Length - 1 < 1)
                            {
                                NumberBox.Text = NumberBox.Text.Substring((NumberBox.Text.Length - 1) - i);
                            }
                            else
                            {
                                NumberBox.Text = "";
                            }

                            QueryTextBlock.Text = calc.ToString();
                            stop = true;
                            
                            break;
                        case "%":

                            break;
                    }
                    if (stop)
                    {
                        break;
                    }
                }
            }

            
            
        }
            

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NumberBox.Focus();
        }

        private void Arithmatic_Click(object sender, RoutedEventArgs e)
        {
            double number = double.Parse(NumberBox.Text);
            char sign = sender.ToString().ToCharArray()[sender.ToString().Length - 1];

            calc.AddItemsToQueryHistory(number, sign);
            QueryTextBlock.Text = calc.ToString();
            CleanEntry_Click(null, null);
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            NumberBox.Text = "";
            NumberBox_LostFocus(null, null);

            calc.RemoveAll();

            QueryTextBlock.Text = "";
        }

        /*
        private async void QueryTextBlock_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            TestConsole tCons = new TestConsole();
            await tCons.Input();
        }
        */
    }
}

