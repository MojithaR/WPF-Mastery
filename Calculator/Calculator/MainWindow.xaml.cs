using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        SelectedOperator selectedOperator;

        public MainWindow()
        {
            InitializeComponent();

            lblResult.Content = "0";

        }

        private void btnNumber_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;

            if (sender == btnZero)
                selectedValue = 0;
            if (sender == btnOne)
                selectedValue = 1;
            if (sender == btnTwo)
                selectedValue = 2;
            if (sender == btnThree)
                selectedValue = 3;
            if (sender == btnFour)
                selectedValue = 4;
            if (sender == btnFive)
                selectedValue = 5;
            if (sender == btnSix)
                selectedValue = 6;
            if (sender == btnSeven)
                selectedValue = 7;
            if (sender == btnEight)
                selectedValue = 8;
            if (sender == btnNine)
                selectedValue = 9;



            lblResult.Content = lblResult.Content.ToString() == "0" ? lblResult.Content = $"{selectedValue}" : lblResult.Content = $"{lblResult.Content}{selectedValue}";
        }

        private void btnNegative_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = double.TryParse(lblResult.Content.ToString(), out lastNumber) ? lastNumber = lastNumber * (-1) : lblResult.Content; 
        }

        private void btnPercentage_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = double.TryParse(lblResult.Content.ToString(), out lastNumber) ? lastNumber = lastNumber / (-1) : lblResult.Content;
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;
            if (double.TryParse(lblResult.Content.ToString(), out newNumber))
            {
                switch(selectedOperator)
                {
                    case SelectedOperator.Addition:
                        result = SimpleMath.Add(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Sustraction:
                        result = SimpleMath.Minus(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Multiplicatiom:
                        result = SimpleMath.Multiple(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Division:
                        result = SimpleMath.Divide(lastNumber, newNumber);
                        break;
                }

                lblResult.Content = result.ToString();
            }
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if(!lblResult.Content.ToString().Contains("."))
                lblResult.Content = $"{lblResult.Content}.";
        }

        private void btnOperation_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(lblResult.Content.ToString(), out lastNumber))
            {
                lblResult.Content = "0";
            }

            if (sender == btnMultiple)
                selectedOperator = SelectedOperator.Multiplicatiom;
            if (sender == btnDivide)
                selectedOperator = SelectedOperator.Division;
            if (sender == btnPlus)
                selectedOperator = SelectedOperator.Addition;
            if (sender == btnMinus)
                selectedOperator = SelectedOperator.Sustraction;

        }

        private void btnAc_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = "0";
        }
    }
}
