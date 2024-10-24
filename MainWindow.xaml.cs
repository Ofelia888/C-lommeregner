using System.Windows;

namespace Lommeregner
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Addition_ButtonClicked(object sender, RoutedEventArgs e)
        {
            OperatorCalculate("+");
        }

        private void Subtraction_ButtonClicked(object sender, RoutedEventArgs e)
        {
            OperatorCalculate("-");
        }

        private void Multiplication_ButtonClicked(object sender, RoutedEventArgs e)
        {
            OperatorCalculate("*");
        }

        private void Division_ButtonClicked(object sender, RoutedEventArgs e)
        {
            OperatorCalculate("/");
        }
        private void OperatorCalculate(string operatorStr)
        {
            int input1 = int.Parse(input1_textbox.Text);
            int input2 = int.Parse(input2_textbox.Text);
            int result = 0;

            switch(operatorStr)
            {
                case "+":
                    result = input1 + input2;
                    break;
                case "-":
                    result = input1 - input2;
                    break;
                case "*":
                    result = input1 * input2;
                    break;
                case "/":
                    result = input1 / input2;
                    break;
            }
            result_textbox.Text = result + "";
        }
    }
}