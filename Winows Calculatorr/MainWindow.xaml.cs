using System;
using System.Windows;
using System.Windows.Controls;

namespace Winows_Calculatorr;

public partial class MainWindow : Window
{
    char process = ' ';
    double number = 0;
    private bool checkNumber { get; set; }

    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnClear_Click(object sender, RoutedEventArgs e)
    {
        Output.Text = "0";
        OutputSmall.Text = " ";
        number = 0;
        process = ' ';
    }

    private void btn_Click(object sender, RoutedEventArgs e)
    {
        if (checkNumber) Output.Text = null;
        
        if (sender is Button btn)
        {
            if (Output.Text == "0" || Output.Text == "-0") Output.Text = btn.Content.ToString();            
            else Output.Text += btn.Content;
            
        }
        checkNumber = false;
    }
    private void btnDot_Click(object sender, RoutedEventArgs e)
    {
        if (!Output.Text.Contains('.'))
            Output.Text += btnComman.Content;

    }

    private void btnBackSpace_Click(object sender, RoutedEventArgs e)
    {
        if (Output.Text.Length > 0)
            Output.Text = Output.Text.Remove(Output.Text.Length - 1, 1);
        if (Output.Text.Length == 0)
        {
            number = 0;
            process = ' ';
        }
        OutputSmall.Text = " ";
    }

    private void CheckProcess()
    {
        if (number == 0)
        {
            number = double.Parse(Output.Text);
            OutputSmall.Text = number.ToString() + process;
        }
        else
            switch (process)
            {
                case '+':
                    number += double.Parse(Output.Text);
                    Output.Text = number.ToString();
                    OutputSmall.Text = number.ToString() + process;
                    break;
                case '-':
                    number -= double.Parse(Output.Text);
                    Output.Text = number.ToString();
                    OutputSmall.Text = number.ToString() + process;
                    break;
                case '÷':
                    number /= double.Parse(Output.Text);
                    Output.Text = number.ToString();
                    OutputSmall.Text = number.ToString() + process;
                    break;
                case 'x':
                    number *= double.Parse(Output.Text);
                    Output.Text = number.ToString();
                    OutputSmall.Text = number.ToString() + process;
                    break;
                case '^':
                    number *= number;
                    OutputSmall.Text = $"sqr({Output.Text})";
                    Output.Text = number.ToString();
                    break;
                case '#':
                    number = Math.Sqrt(double.Parse(Output.Text));
                    OutputSmall.Text = $"√({Output.Text})";
                    Output.Text = number.ToString();
                    break;
                case '?':
                    number = 1 / (double.Parse(Output.Text));
                    OutputSmall.Text =$"1/({Output.Text})";
                    Output.Text = number.ToString();
                    break;
                default:
                    break;
            }
        
    }

    private void btnPlus_Click(object sender, EventArgs e)
    {
        process = '+';
        CheckProcess();
        checkNumber = true;
    }

    private void btnMult_Click(object sender, EventArgs e)
    {
        process = 'x';
        CheckProcess();
        checkNumber = true;
    }
    private void btnDivide_Click(object sender, EventArgs e)
    {
        process = '÷';
        CheckProcess();
        checkNumber = true;
    }
    private void btnMinus_Click(object sender, EventArgs e)
    {
        process = '-';
        CheckProcess();
        checkNumber = true;
    }

    private void btnEqual_Click(object sender, EventArgs e)
    {
        process = '=';
        CheckProcess();
        Output.Text = number.ToString();
        checkNumber = true;
    }

    private void btnPower_Click(object sender, EventArgs e)
    {
        process = '^';
        number = double.Parse(Output.Text);
        CheckProcess();
        Output.Text = number.ToString();
        checkNumber = true;
    }

    private void btnSqrt_Click(object sender, EventArgs e)
    {
        number = double.Parse(Output.Text);
        process = '#';
        CheckProcess();
        Output.Text = number.ToString();
        checkNumber = true;
    }

    private void btnPercentage_Click(object sender, EventArgs e)
    {
        if (process == ' ')
            Output.Text = "0";
        else
            number = (double.Parse(Output.Text) / number) * 100;
        Output.Text = number.ToString();
        OutputSmall.Text = $"{Output.Text}";
        checkNumber = true;
    }

    private void bntOneDivivdedBy_Click(object sender, EventArgs e)
    {
        OutputSmall.Text = "1/x";
        number = double.Parse(Output.Text);
        process = '?';
        CheckProcess();
        Output.Text = number.ToString();
        checkNumber = true;
    }

    private void btnPlusMinus_Click(Object sender, EventArgs e)
    {
        if (double.Parse(Output.Text) > 0)
            Output.Text = Output.Text.Insert(0, "-");
        else
            Output.Text = (0 - double.Parse(Output.Text)).ToString();
    }

}


