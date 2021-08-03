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

namespace Calculator.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly BusinessLogic bl = new BusinessLogic();
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void numericButton_Click(object sender, RoutedEventArgs e)
        {
            Button bt = sender as Button;
            bl.textBoxTemp = txtDisplay;
            bl.textBoxFinal = txtDisplayFinal;
            var number = bt.Content.ToString();
            bl.GetNumber(number);
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            Button bt = sender as Button;
            var calcSymbol = bt.Content.ToString();
            bl.GetCalculation(calcSymbol);
        }
    }
}
