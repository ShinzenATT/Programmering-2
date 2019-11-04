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

        // Whebn the equals button is clicked send the current number to the list and calculate all the numbers in the list
        private void Execute_Click(object sender, RoutedEventArgs e)
        {
            object temp = 0.0;
            string target = NumberBox.Text;

            if (target.Contains("%"))
            {
                try
                {
                    temp = Percentage.Parse(target);
                }
                catch
                {
                    temp = 0.0;
                }
            }
            else
            {
                try
                {
                    temp = double.Parse(target);
                }
                catch
                {
                    temp = 0.0;
                }
            }

            calc.AddItem(temp);
            QueryTextBlock.Text = calc.ToString();

            NumberBox.Text = calc.Execute().ToString();
            calc.RemoveAll();
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
            Button tempNumber;
            try
            {
                tempNumber = (Button)sender;
            }
            catch
            {
                tempNumber = new Button();
            }
            if (!(NumberBox.IsFocused))
            {
                NumberBox_GotFocus(null, null);
            }
            try
            {
                NumberBox.Text += tempNumber.Tag.ToString().ToCharArray()[0];
            }
            catch { }
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
                            object temp = 0.0;
                            string target = NumberBox.Text.Substring(0, i);

                            if (target.Contains("%"))
                            {
                                try
                                {
                                    temp = Percentage.Parse(target);
                                }
                                catch
                                {
                                    temp = 0.0;
                                }
                            }
                            else
                            {
                                try
                                {
                                    temp = double.Parse(target);
                                }
                                catch {
                                    temp = 0.0;
                                }
                            }
            
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
                    }
                    if (stop)
                    {
                        break;
                    }
                }
            }

            
            
        }
            
        // Focuses the text field when the textblock is clicked
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NumberBox.Focus();
        }

        // When any arithmatic button is clicked (+, -, /, * and so on) then add the current number and the arithmatic letter to the list
        private void Arithmatic_Click(object sender, RoutedEventArgs e)
        {
            object number = 0.0;
            Button sender2 = (Button)sender;
            char sign = sender2.Tag.ToString().ToCharArray()[0];
            

            if (NumberBox.Text.Contains("%"))
            {
                try
                {
                    number = Percentage.Parse(NumberBox.Text);
                }
                catch
                {
                    number = 0.0;
                }
            }
            else
            {
                try
                {
                    number = double.Parse(NumberBox.Text);
                }
                catch
                {
                    number = 0.0;
                }
            }

            calc.AddItemsToQueryHistory(number, sign);
            QueryTextBlock.Text = calc.ToString();
            CleanEntry_Click(null, null);
        }

        // Clears the text field and the list
        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            NumberBox.Text = "";
            NumberBox_LostFocus(null, null);

            calc.RemoveAll();

            QueryTextBlock.Text = "";
        }

        private void Percent_Click(object sender, RoutedEventArgs e)
        {
            NumberBox.Text += "%";
        }

        private void Root_Click(object sender, RoutedEventArgs e)
        {
            if(NumberBox.Text == "0" || NumberBox.Text == "")
            {
                NumberBox.Text = "2";
            }

            Arithmatic_Click(sender, e);
        }
    }
}

