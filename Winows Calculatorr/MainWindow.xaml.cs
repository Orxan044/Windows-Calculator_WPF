using System;
using System.Windows;
using System.Windows.Controls;
namespace Winows_Calculatorr;

public partial class MainWindow : Window
{
    double totalNumber;
    char proses = ' ';
    bool check = true;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnToOutbut_Click(object sender, RoutedEventArgs e)
    {

        Button? button = sender as Button;
        if (proses == '=')
        {
            totalNumber = 0;
            proses = ' ';
            Output.Text = " ";
            OutputSmall.Text = " ";
        }
        if (Output.Text == "0") Output.Text = " ";
        if (check == false && Output.Text != " ") { Output.Text = " "; check = true; } 
        Output.Text += button.Content;

    }

    private void btnToProses_Click(object sender, RoutedEventArgs e)
    {
        Button? button = sender as Button;
        proses = char.Parse(button.Content.ToString());
        check = false;
        Console.WriteLine(proses);
        switch (proses)
        {
            case '+':
                totalNumber += double.Parse(Output.Text);
                break;
            case '-':
                totalNumber -= double.Parse(Output.Text);
                break;
            case '=':
                OutputSmall.Text = totalNumber.ToString();
                Output.Text = totalNumber.ToString();
                break;

        }

        OutputSmall.Text = (totalNumber + " " + proses);
        Output.Text = totalNumber.ToString();
        proses = ' ';
    }
}