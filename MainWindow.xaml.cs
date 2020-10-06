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
using Pow;
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
            double number = double.Parse(variable_first.Text.Replace(".", ","));
            double pow = double.Parse(variable_second.Text.Replace(".", ","));
            double result = Pow.Pow.FuncPlus(number, pow);
            Output.Text = $"{result}";
        }
    }
}
