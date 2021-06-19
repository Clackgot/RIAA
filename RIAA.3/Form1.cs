using System;
using System.Windows.Forms;

namespace lab_3
{
    public partial class Form1 : Form
    {
        double[,] BaseMatrix = new double[3, 3]; // матрица коэффициентов
        double[] ResMatrix = new double[3]; // матрица правой части СЛАУ
        double[] Roots = new double[3]; // матрица корней СЛАУ
        double checkSum = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            SLAU slau = new SLAU();

            output.Text = "";
            BaseMatrix[0, 0] = Convert.ToDouble(A11.Value);
            BaseMatrix[0, 1] = Convert.ToDouble(A12.Value);
            BaseMatrix[0, 2] = Convert.ToDouble(A13.Value);
            BaseMatrix[1, 0] = Convert.ToDouble(A21.Value);
            BaseMatrix[1, 1] = Convert.ToDouble(A22.Value);
            BaseMatrix[1, 2] = Convert.ToDouble(A23.Value);
            BaseMatrix[2, 0] = Convert.ToDouble(A31.Value);
            BaseMatrix[2, 1] = Convert.ToDouble(A32.Value);
            BaseMatrix[2, 2] = Convert.ToDouble(A33.Value);
            ResMatrix[0] = Convert.ToInt32(rA1.Value);
            ResMatrix[1] = Convert.ToInt32(rA2.Value);
            ResMatrix[2] = Convert.ToInt32(rA3.Value);
            output.Text += "Решение СЛАУ классическим методом Гаусса.\n ";
            Roots = slau.GaussMethod(BaseMatrix, ResMatrix);
            for (int i = 0; i < 3; i++)
            {
                output.Text += $"x{i + 1} = {Roots[i]}; \n";
            }
            
            output.Text += "\n";
            output.Text += "Решение СЛАУ модификацией метода Гаусса с выбором эл-та по строке. \n";
            Roots = new double[3];
            Roots = slau.GaussMethod_mod1(BaseMatrix, ResMatrix);
            output.Text += "Корни уравнения, полученные алгоритмом: \n";
            for (int i = 0; i < 3; i++)
            {
                output.Text += $"x{i + 1} = {Roots[i]}; \n";
            }
            output.Text += "\n";

            output.Text += $"Решение СЛАУ модификацией метода Гаусса с выбором эл-та по столбцу. \n";
            Roots = new double[3];
            Roots = slau.GaussMethod_mod2(BaseMatrix, ResMatrix);
            output.Text += $"Корни уравнения, полученные алгоритмом: \n";
            for (int i = 0; i < 3; i++)
            {
                output.Text += $"x{i + 1} = {Roots[i]}; \n";
            }
            output.Text += "\n";

            output.Text += $"Решение СЛАУ модификацией метода Гаусса с выбором эл-та по непреобразованной части М-ы. \n";
            Roots = new double[3];
            Roots = slau.GaussMethod_mod3(BaseMatrix, ResMatrix);
            output.Text += $"Корни уравнения, полученные алгоритмом: \n";
            for (int i = 0; i < 3; i++)
            {
                output.Text += $"x{i + 1} = {Math.Round(Roots[i])}; \n"; 
            }
            output.Text += "\n";


            output.Text += $"Решение СЛАУ методом Жордана. \n";
            Roots = new double[3];
            Roots = slau.JordanMethod(BaseMatrix, ResMatrix, output.Text);
            output.Text += $"Корни уравнения, полученные алгоритмом: \n";
            for (int i = 0; i < 3; i++)
            {
                output.Text += $"x{i + 1} = {Math.Round(Roots[i])}; \n";
            }
            output.Text += "\n";
        }       
    }
}
