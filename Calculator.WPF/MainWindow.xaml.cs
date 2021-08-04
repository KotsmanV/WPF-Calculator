using System.Windows;
using System.Windows.Controls;

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

        private void plusMinusButton_Click(object sender, RoutedEventArgs e)
        {
            bl.PlusMinus();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Button bt = sender as Button;
            if (bt.Name.Equals("btnClearEntry"))
            {
                bl.ClearEntry();
            }
            else if (bt.Name.Equals("btnClear"))
            {
                bl.ClearAll();
            }
            else if (bt.Name.Equals("btnBackspace"))
            {
                bl.Backspace();
            }
        }

        private void btnSquareRoot_Click(object sender, RoutedEventArgs e)
        {
            bl.SquareRoot();
        }

        private void btnPower_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Name.Equals("btnPowerTwo"))
            {
                bl.RaiseToPower(2);
            }
            else if (btn.Name.Equals("btnPower"))
            {

            }
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            bl.Dot();
        }

        private void btnPercentage_Click(object sender, RoutedEventArgs e)
        {
            bl.Percentage();
        }
    }
}
