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

namespace T2
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

        private void InputBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (InputBox1.Text != "" && InputBox2.Text != "")
            {
                try
                {
                    double num1 = int.Parse(InputBox1.Text);
                    double num2 = int.Parse(InputBox2.Text);
                    SumBlock.Text = (num1 + num2).ToString();
                }
                catch (OverflowException)
                {
                    SumBlock.Text = "Error";
                    InputBox1.Text = "";
                    InputBox2.Text = "";
                }
            }
            else if (InputBox2.Text != "")
            {
                try
                {
                    SumBlock.Text = InputBox2.Text;
                }
                catch (OverflowException)
                {
                    SumBlock.Text = "Error";
                    InputBox2.Text = "";
                }
            }
            else if (InputBox1.Text != "")
            {
                try
                {
                    SumBlock.Text = InputBox1.Text;
                }
                catch (OverflowException)
                {
                    SumBlock.Text = "Error";
                    InputBox1.Text = "";
                }
            }
            else
            {
                SumBlock.Text = "0";
            }
        }
        private void InputBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (InputBox1.Text != "" && InputBox2.Text!= "")
            {
                try
                {
                    double num1 = int.Parse(InputBox1.Text);
                    double num2 = int.Parse(InputBox2.Text);
                    SumBlock.Text = (num1 + num2).ToString();
                }catch (OverflowException)
                {
                    SumBlock.Text = "Error";
                    InputBox1.Text = "";
                    InputBox2.Text = "";
                }
            }
            else if (InputBox2.Text != "")
            {
                    try{
                        SumBlock.Text = InputBox2.Text;
                    } catch (OverflowException)
                    {
                        InputBox2.Text = "";
                    }
            }
            else if (InputBox1.Text != "")
            {
                try
                {
                    SumBlock.Text = InputBox1.Text;
                }
                catch (OverflowException)
                {
                    InputBox1.Text = "";
                }
            }
            else
            {
                    SumBlock.Text = "0";
            }
        }
    }
}
