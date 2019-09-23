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

namespace v38_Labb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int bgIndex = 0;
        static readonly Color[] backgroundColors = { Colors.White, Colors.Pink, Colors.Red, Colors.Orange, 
            Colors.Yellow, Colors.Green, Colors.Aquamarine, Colors.Blue, Colors.Indigo, Colors.Black, Colors.Gray };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void messageButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Task failed succesfully!", "World take over report", MessageBoxButton.OK , MessageBoxImage.Error);
        }

        private void bgChange_Click(object sender, RoutedEventArgs e)
        {
            if(++bgIndex > backgroundColors.Length - 1)
            {
                bgIndex = 0;
            }
            background.Fill = new SolidColorBrush(backgroundColors[bgIndex]);
        }

        private void splash_Click(object sender, RoutedEventArgs e)
        {
            rec0.Fill = new SolidColorBrush(backgroundColors[(bgIndex + 2) % (backgroundColors.Length)]);
            rec1.Fill = new SolidColorBrush(backgroundColors[(bgIndex + 3) % (backgroundColors.Length)]);
            rec2.Fill = new SolidColorBrush(backgroundColors[(bgIndex + 4) % (backgroundColors.Length)]);
            rec3.Fill = new SolidColorBrush(backgroundColors[(bgIndex++ + 5) % (backgroundColors.Length)]);

            

        }
    }
}
