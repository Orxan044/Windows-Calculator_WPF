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

namespace Winows_Calculatorr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number = 0;
        char proses = ' ';

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckProcess()
        {
            if (number == 0)
                number = double.Parse(Output.Text);
            else
                switch (proses)
                {
                    case '+':
                        number += double.Parse(Output.Text);
                        break;
                    case '-':
                        number -= double.Parse(Output.Text);
                        break;
                    case '/':
                        number /= double.Parse(Output.Text);
                        break;
                    case '*':
                        number *= double.Parse(Output.Text);
                        break;
                    case '^':
                        number *= number;
                        break;
                    case '#':
                        number = Math.Sqrt(double.Parse(Output.Text));
                        break;
                    case '?':
                        number = 1 / (double.Parse(Output.Text));
                        break;
                    default:
                        break;
                }
        }

        private void faizbtn_Click(object sender, RoutedEventArgs e)
        {
            if (proses == ' ')
                Output.Text = "0";
            else
                number = (double.Parse(Output.Text) / number) * 100;
            Output.Text = number.ToString();
            yariout.Text = proses + "( " + number + " )";
        }

        private void CEbtn_Click(object sender, RoutedEventArgs e)
        {
            Output.Text = "0";
            yariout.Text = "";
        }
        private void deletbtn_Click(object sender, RoutedEventArgs e)
        {
            if (Output.Text.Length > 0)
                Output.Text = Output.Text.Remove(Output.Text.Length - 1, 1);
            if (Output.Text.Length == 0)
            {
                number = 0;
                proses = ' ';
            }
        }

        private void btn1bolx_Click(object sender, RoutedEventArgs e)
        {
            number = double.Parse(Output.Text);
            proses = '?';
            CheckProcess();
            Output.Text = number.ToString();
            yariout.Text = proses + "( " + number + " )";
            yariout.Text = "1/" + "( " + number + " )";
        }
        private void btnkvadat_Click(object sender, RoutedEventArgs e)
        {
            proses = '^';
            CheckProcess();
            Output.Text = number.ToString();
            yariout.Text = number + "( " + number + " )";
        }

        private void btnkokalti_Click(object sender, RoutedEventArgs e)
        {
            number = double.Parse(Output.Text);
            proses = '#';
            CheckProcess();
            Output.Text = number.ToString();
            yariout.Text = proses + "( " + number + " )";
        }

        private void btnbolme_Click(object sender, RoutedEventArgs e)
        {
            CheckProcess();
            proses = '/';
            yariout.Text = (number.ToString() + " " + proses);
        }
        private void vurmabtn_Click(object sender, RoutedEventArgs e)
        {
            CheckProcess();
            proses = '*';
            yariout.Text = (number.ToString() + " " + proses);
        }
        private void btncix_Click(object sender, RoutedEventArgs e)
        {
            CheckProcess();
            proses = '-';
            yariout.Text = (number.ToString() + " " + proses);
        }

        private void buttonAddition_Click(object sender, RoutedEventArgs e)
        {
            CheckProcess();
            proses = '+';
            yariout.Text = (number.ToString() + " " + proses);
        }

        private void btnnoqte_Click(object sender, RoutedEventArgs e)
        {
            if (!Output.Text.Contains('.'))
                Output.Text += btnnoqte.Content;
        }


        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (proses == '=')
            {
                number = 0;
                proses = ' ';
            }
            if (Output.Text == "0")
                Output.Text = button.Content.ToString();
            else if (proses != ' ')
                Output.Text = button.Content.ToString();
            else
                Output.Text += button.Content;
        }

        private void btnberaber_Click(object sender, RoutedEventArgs e)
        {
            CheckProcess();
            proses = '=';
            Output.Text = number.ToString();
        }

        private void btnpluscix_Click(object sender, RoutedEventArgs e)
        {
            number = double.Parse(Output.Text);
            proses = '?';
            CheckProcess();
            Output.Text = number.ToString();
        }
    }
}
