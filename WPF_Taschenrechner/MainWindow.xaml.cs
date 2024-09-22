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

namespace WPF_Taschenrechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Aufgabe bring ein Komma rein,


        double first, second, result;
        string op;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Button btn = (Button)sender;
            MainText.Text += btn.Content.ToString();
            SecondText.Text += btn.Content.ToString();
            second = double.Parse(MainText.Text);

        }
        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                first = double.Parse(MainText.Text);
                first = double.Parse(SecondText.Text);
                Button btn = (Button)sender;
                SecondText.Text += btn.Content.ToString();
                op = "/";
                MainText.Clear();
            }
            catch
            {
                MainText.Clear();
            }

        }
        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                first = double.Parse(MainText.Text);
                first = double.Parse(SecondText.Text);
                Button btn = (Button)sender;
                SecondText.Text += btn.Content.ToString();
                op = "-";
                MainText.Clear();
            }
            catch
            {
                MainText.Clear();
            }
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            
            
            try
            {
                first = double.Parse(MainText.Text);
                first = double.Parse(SecondText.Text);
                Button btn = (Button)sender;
                SecondText.Text += btn.Content.ToString();  
                op = "+";
                MainText.Clear(); 
                
            }
            catch
            {
                MainText.Clear();
            }
        }
        private void Multi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                first = double.Parse(MainText.Text);
                first = double.Parse(SecondText.Text);
                Button btn = (Button)sender;
                SecondText.Text += btn.Content.ToString();
                op = "*";
                MainText.Clear();
            }
            catch
            {
                MainText.Clear();
            }

        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            SecondText.Clear();
            MainText.Clear();
        }
        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if (MainText.Text != string.Empty || SecondText.Text != string.Empty)
            {
                int txtlength = MainText.Text.Length;
               
                if (txtlength != 1)
                {
                    try
                    {
                        MainText.Text = MainText.Text.Remove(txtlength - 1);

                    }
                    catch
                    {
                        SecondText.Clear();
                    }
                }
                else
                {
                    MainText.Text = 0.ToString();
                    SecondText.Text = 0.ToString();
                }
            }

        }
        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                second = double.Parse(MainText.Text);
                Button btn = (Button)sender;
                SecondText.Text += btn.Content.ToString();
                
            }
            catch
            {
                MainText.Clear();
                SecondText.Clear();
            }

            if (op == "+")
            {
                result = first + second;
            }
            else if(op == "-")
            {
                result = first - second;
            }
            else if(op == "*")
            {
                result = first * second;
            }
            else if(op == "/")
            {
                try
                {
                    result = first / second;
                }
                catch (DivideByZeroException)
                {
                    MainText.Text = "Error";
                }

            }
            else if(op == "")
            {
                MainText.Clear();
                SecondText.Clear();
            }

            if(MainText.Text == "0")
            {
                MainText.Clear();
                SecondText.Clear();
            }
            MainText.Text = result.ToString();
            SecondText.Text = result.ToString();
        }

    }
}
