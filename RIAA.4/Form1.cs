using System;
using System.Windows.Forms;
namespace RIAA._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static string functionName = "(1 + Cos(x))";


        private void tabPage1_button1_Click(object sender, EventArgs e)
        {
            double a = ((double)tabPage1_numericUpDown1.Value);//Левая граница интегрирования
            double b = ((double)tabPage1_numericUpDown2.Value);//Правая граница интегрирования
            double eps = ((double)tabPage1_numericUpDown3.Value);//Точность эпсилон
            tabPage1_richTextBox1.Text = "";
            tabPage1_richTextBox1.Text += $"    dx\n---------------  = {Lib.SimpsonMethod(a, b, eps)}\n{functionName}";
        }


        /// <summary>
        /// Основная функция
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        double f(double x)
        {
            return x * Math.Pow(Math.E, x);
        }
        

        private void tabPage2_button1_Click(object sender, EventArgs e)
        {
            int n = ((int)tabPage2_numericUpDown3.Value);
            double a = ((double)tabPage2_numericUpDown1.Value), b = ((double)tabPage2_numericUpDown2.Value);
            tabPage2_richTextBox1.Text = "";
            tabPage2_richTextBox1.Text += $"    dx\n---------------  = {Lib.TrapezoidMethod(a, b, n)}\n{functionName}";
        }




        private void tabPage3_button2_Click(object sender, EventArgs e)
        {
            double a = ((double)tabPage3_numericUpDown4.Value), b = ((double)tabPage3_numericUpDown5.Value), eps = ((double)tabPage3_numericUpDown6.Value);
            tabPage3_richTextBox2.Text = "";
            tabPage3_richTextBox2.Text += $"    dx\n---------------  = {Lib.LeftRectangleMethod(a, b, eps)}\n{functionName}";
        }



        private void tabPage4_button3_Click(object sender, EventArgs e)
        {
            double a = ((double)tabPage4_numericUpDown7.Value), b = ((double)tabPage4_numericUpDown8.Value), eps = ((double)tabPage4_numericUpDown9.Value);

            
            tabPage4_richTextBox3.Text = "";
            tabPage4_richTextBox3.Text += $"    dx\n---------------  = {Lib.RightRectangleMethod(a, b, eps)}\n{functionName}";
        }


        private void tabPage5_button4_Click(object sender, EventArgs e)
        {
            double a = ((double)tabPage5_numericUpDown10.Value), b = ((double)tabPage5_numericUpDown11.Value), eps = ((double)tabPage5_numericUpDown12.Value), n = ((double)tabPage5_numericUpDown1.Value);

            
            tabPage5_richTextBox4.Text = "";
            tabPage5_richTextBox4.Text += $"    dx\n---------------  = {Lib.MiddleRectangleMethod(a, b, eps, n)}\n{functionName}";
        }


    }
}