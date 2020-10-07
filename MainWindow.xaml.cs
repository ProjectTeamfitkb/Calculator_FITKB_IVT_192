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
using Plus_Cal;

namespace Calculator
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

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(variable_first.Text.Replace(".", ","));
            double y = double.Parse(variable_second.Text.Replace(".", ","));
            double result = Plus_Cal.Plus.FuncPlus(x, y);
            Output.Text = $"{result}";
        }

        private void Exponentiation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(variable_first.Text, out double resultA); //проверка введенных значений
            Double.TryParse(variable_second.Text, out double resultB);
            if (resultA == 0 || resultB == 0) // 0 возвращается после проверки если: ничего не ввели, ввели неправильно, ввели 0
            {
                MessageBox.Show("Введите числа!\n(второе не должно равняться нулю)");
            }
            else
            {
                double A = Convert.ToDouble(variable_first.Text), B = Convert.ToDouble(variable_second.Text);
                double Result = DivisionLibrary.Class1.Division(A, B);
                Output.Text = Convert.ToString(Result);
            }
        }
    }
}
