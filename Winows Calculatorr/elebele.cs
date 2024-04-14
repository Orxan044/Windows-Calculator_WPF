//using System;
//using System.Windows;
//using System.Windows.Controls;
//namespace Winows_Calculatorr;

//public partial class MainWindow : Window
//{
//    double number = 0;
//    char proses = ' ';

//    public MainWindow()
//    {
//        InitializeComponent();
//    }

//    private void CheckProcess()
//    {
//        if (number == 0)
//            number = double.Parse(Output.Text);
//        else
//            switch (proses)
//            {
//                case '+':
//                    number += double.Parse(Output.Text);

//                    break;
//                case '-':
//                    number -= double.Parse(Output.Text);
//                    break;
//                case '/':
//                    number /= double.Parse(Output.Text);
//                    break;
//                case '*':
//                    number *= double.Parse(Output.Text);
//                    break;
//                case '^':
//                    number *= number;
//                    break;
//                case '#':
//                    number = Math.Sqrt(double.Parse(Output.Text));
//                    break;
//                case '?':
//                    number = 1 / (double.Parse(Output.Text));
//                    break;
//                default:
//                    break;
//            }
//    }

//    private void btntoTextBox_Click(object sender, RoutedEventArgs e)
//    {

//        Button? button = sender as Button;
//        if (proses == '=')
//        {
//            number = 0;   
//            proses = ' ';
//            Output.Text = " ";
//            OutputSmall.Text = " ";
//        }
//        //if (Output.Text == "0") Output.Text = " ";
//        //if(proses != ' ') { Output.Text = " "; }
//        //Output.Text += button.Content.ToString();
//        if (Output.Text == "0")
//            Output.Text = button.Content.ToString();
//        else if (proses != ' ')
//            Output.Text = button.Content.ToString();
//        else
//            Output.Text += button.Content;
//    }

//    private void faizbtn_Click(object sender, RoutedEventArgs e)
//    {
//        if (proses == ' ')
//            Output.Text = "0";
//        else
//            number = (double.Parse(Output.Text) / number) * 100;
//        Output.Text = number.ToString();
//        OutputSmall.Text = proses + "( " + number + " )";
//    }

//    private void CEbtn_Click(object sender, RoutedEventArgs e)
//    {
//        Output.Text = "0";
//        OutputSmall.Text = "";
//        proses = ' ';
//    }
//    private void deletbtn_Click(object sender, RoutedEventArgs e)
//    {
//        if (Output.Text.Length > 0)
//            Output.Text = Output.Text.Remove(Output.Text.Length - 1, 1);
//        if (Output.Text.Length == 0)
//        {
//            number = 0;
//            proses = ' ';
//        }
//    }

//    private void btn1bolx_Click(object sender, RoutedEventArgs e)
//    {
//        number = double.Parse(Output.Text);
//        proses = '?';
//        CheckProcess();
//        Output.Text = number.ToString();
//        OutputSmall.Text = proses + "( " + number + " )";
//        OutputSmall.Text = "1/" + "( " + number + " )";
//    }
//    private void btnkvadat_Click(object sender, RoutedEventArgs e)
//    {
//        proses = '^';
//        CheckProcess();
//        Output.Text = number.ToString();
//        OutputSmall.Text = number + "( " + number + " )";
//    }

//    private void btnkokalti_Click(object sender, RoutedEventArgs e)
//    {
//        number = double.Parse(Output.Text);
//        proses = '#';
//        CheckProcess();
//        Output.Text = number.ToString();
//        OutputSmall.Text = proses + "( " + number + " )";
//    }

//    private void btnbolme_Click(object sender, RoutedEventArgs e)
//    {
//        CheckProcess();
//        proses = '/';
//        OutputSmall.Text = (number.ToString() + " " + proses);
//    }
//    private void vurmabtn_Click(object sender, RoutedEventArgs e)
//    {
//        CheckProcess();
//        proses = '*';
//        OutputSmall.Text = (number.ToString() + " " + proses);
//    }
//    private void btncix_Click(object sender, RoutedEventArgs e)
//    {
//        CheckProcess();
//        proses = '-';
//        OutputSmall.Text = (number.ToString() + " " + proses);
//    }

//    private void buttonAddition_Click(object sender, RoutedEventArgs e)
//    {
//        CheckProcess();
//        proses = '+';
//        OutputSmall.Text = (number.ToString() + " " + proses);
//        proses = ' ';
//    }

//    private void btnnoqte_Click(object sender, RoutedEventArgs e)
//    {
//        if (!Output.Text.Contains('.'))
//            Output.Text += btnnoqte.Content;
//    }



//    private void btnberaber_Click(object sender, RoutedEventArgs e)
//    {
//        CheckProcess();
//        proses = '=';
//        Output.Text = number.ToString();
//    }

//    private void btnpluscix_Click(object sender, RoutedEventArgs e)
//    {
//        number = double.Parse(Output.Text);
//        proses = '?';
//        CheckProcess();
//        Output.Text = number.ToString();

//    }

//}
