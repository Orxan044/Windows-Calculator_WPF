using System;
using System.Windows;
using System.Windows.Controls;
namespace Winows_Calculatorr;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private bool TrueFalse { get; set; }
    int count_command, count_add, count_negative, count_multi, count_divide, count_minus, count_sqrt = 0;
    private double _Result { get; set; }
    private double Resultcopy { get; set; }
    private double X { get; set; }
    private string Symbol { get; set; }


    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (Output.Text == "Invalid input")
        {
            btnDivision.IsEnabled = true;
            btnMinus.IsEnabled = true;
            btnMulti.IsEnabled = true;
            btnSqrt.IsEnabled = true;
            btnPlus.IsEnabled = true;
            btnComman.IsEnabled = true;
            btnNeqative.IsEnabled = true;
            btnDoubleMulti.IsEnabled = true;
            btnFraction.IsEnabled = true;
        }

        if (TrueFalse)
        {
            Output.Text = null;
        }
        if (sender is Button btn)
        {
            if (Output.Text == "0" || Output.Text == "-0") Output.Text = btn.Content.ToString();
            else
            {
                Output.Text += btn.Content;
            }
        }
        if (TrueFalse) X = Convert.ToDouble(Output.Text);
        TrueFalse = false;
    }


    private void btn_comman_Click(object sender, RoutedEventArgs e)
    {
        if (count_command == 0)
        {
            Output.Text += ".";
            ++count_command;
        }
    }

    private void btn_removeall_Click(object sender, RoutedEventArgs e)
    {
        if (Output.Text == "Invalid input")
        {
            btnDivision.IsEnabled = true;
            btnMinus.IsEnabled = true;
            btnMulti.IsEnabled = true;
            btnSqrt.IsEnabled = true;
            btnPlus.IsEnabled = true;
            btnComman.IsEnabled = true;
            btnNeqative.IsEnabled = true;
            btnDoubleMulti.IsEnabled = true;
            btnFraction.IsEnabled = true;
        }
        Output.Text = null;
        count_command = 0;
        count_negative = 0;
    }

    private void btn_deleteone_Click(object sender, RoutedEventArgs e)
    {
        if (Output.Text.Length == 1)
        {
            Output.Text = "0";
        }
        else
        {
            Output.Text = Output.Text.Remove(Output.Text.Length - 1, 1); 

            if (Output.Text[Output.Text.Length - 1] == '.')
            {
                Output.Text = Output.Text.Remove(Output.Text.Length - 1, 1);
                count_command = 0;

            }
            if (Output.Text[Output.Text.Length - 1] == '-')
            {
                Output.Text = Output.Text.Remove(Output.Text.Length - 1, 1);
                count_negative = 0;
            }

        }

    }

    private void btn_negative_Click(object sender, RoutedEventArgs e)
    {
        if (count_negative == 0)
        {
            Output.Text = Output.Text.Insert(0, "-");
            ++count_negative;
        }
        else if (count_negative == 1)
        {
            Output.Text = Output.Text.Remove(0, 1);
            count_negative = 0;
        }
    }


    private void btn_operator_Click(object sender, RoutedEventArgs e)
    {
        if (sender is Button btn)
        {
            if (btn.Content.ToString() == "+")
            {
                Resultcopy = Convert.ToDouble(Output.Text);
                Symbol = "+";
                TrueFalse = true;
                count_command = 0;
                count_negative = 0;
                count_add = 0;
            }
            else if (btn.Content.ToString() == "-")
            {
                Resultcopy = Convert.ToDouble(Output.Text);
                Symbol = "-";
                TrueFalse = true;
                count_command = 0;
                count_negative = 0;
                count_minus = 0;
            }
            else if (btn.Content.ToString() == "x")
            {
                Resultcopy = Convert.ToDouble(Output.Text);
                Symbol = "x";
                TrueFalse = true;
                count_command = 0;
                count_negative = 0;
                count_multi = 0;

            }
            else if (btn.Content.ToString() == "÷")
            {
                Resultcopy = Convert.ToDouble(Output.Text);
                Symbol = "÷";
                TrueFalse = true;
                count_command = 0;
                count_negative = 0;
                count_divide = 0;
            }
            else if (btn.Content.ToString() == "x²")
            {
                TrueFalse = true;
                count_command = 0;
                count_negative = 0;
                Resultcopy = Convert.ToDouble(Output.Text);

                Output.Text = (Resultcopy * Resultcopy).ToString();
            }
            else if (btn.Content.ToString() == "√х")
            {
                TrueFalse = true;
                count_command = 0;
                count_negative = 0;

                Resultcopy = Convert.ToDouble(Output.Text);

                if (Resultcopy > 0)
                {
                    Output.Text = Math.Sqrt(Resultcopy).ToString();

                }
                else if (Resultcopy < 0)
                {
                    Output.Text = "Invalid input";
                    btnDivision.IsEnabled = false;
                    btnMinus.IsEnabled = false;
                    btnMulti.IsEnabled = false;
                    btnSqrt.IsEnabled = false;
                    btnPlus.IsEnabled = false;
                    btnComman.IsEnabled = false;
                    btnNeqative.IsEnabled = false;
                    btnDoubleMulti.IsEnabled = false;
                    btnFraction.IsEnabled = false;
                }

            }

        }
    }

    private void Result_Click(object sender, RoutedEventArgs e)
    {
        if (Output.Text == "Invalid input")
        {
            btnDivision.IsEnabled = true;
            btnMinus.IsEnabled = true;
            btnMulti.IsEnabled = true;
            btnSqrt.IsEnabled = true;
            btnPlus.IsEnabled = true;
            btnComman.IsEnabled = true;
            btnNeqative.IsEnabled = true;
            btnDoubleMulti.IsEnabled = true;
            btnFraction.IsEnabled = true;
            Output.Text = "0";
        }
        ++count_add;
        ++count_minus;
        ++count_multi;
        ++count_divide;
        ++count_sqrt;

        _Result = Convert.ToDouble(Output.Text);



        if (Symbol == "+")
        {
            if (count_add == 1)
            {
                Output.Text = (Resultcopy + _Result).ToString();
            }
            else if (count_add != 1)
            {
                Output.Text = (X + _Result).ToString();
            }

        }
        else if (Symbol == "-")
        {
            if (count_minus == 1)
            {
                Output.Text = (Resultcopy - _Result).ToString();
            }
            else if (count_minus != 1)
            {
                Output.Text = (_Result - X).ToString();
            }

        }
        else if (Symbol == "x")
        {
            if (count_multi == 1)
            {
                Output.Text = (Resultcopy * _Result).ToString();
            }
            else if (count_multi != 1)
            {
                Output.Text = (X * _Result).ToString();
            }

        }
        else if (Symbol == "√х")
        {
            if (count_multi == 1)
            {
                Output.Text = (Math.Sqrt(_Result)).ToString();
            }
            else if (count_multi != 1)
            {
                Output.Text = (X * _Result).ToString();
            }

        }
        else if (Symbol == "÷")
        {
            if (count_divide == 1)
            {
                if (_Result == 0)
                {
                    MessageBox.Show("Error");
                }
                else Output.Text = (Resultcopy / _Result).ToString();
            }
            else if (count_divide != 1)
            {
                if (X == 0)
                {
                    MessageBox.Show("Error");
                }
                else Output.Text = (_Result / X).ToString();
            }

        }
    }


}
