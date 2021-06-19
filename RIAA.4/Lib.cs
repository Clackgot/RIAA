using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIAA._4
{
    public static class Lib
    {
        private static double Integ(double a, double b, int n, double y)
        {
            return ((b - a) / (2 * n) * y);
        }
        private static double IntegrateLeft(double a, double b, int n)
        {
            double x, h = (b - a) / n; double sum = 0.0;
            double fx;
            for (int i = 0; i < n; i++)
            { x = a + i * h; fx = f(x); sum += fx; }
            return (sum * h);
        }
        private static double IntegrateRight(double a, double b, int n)
        {
            double x, h; double sum = 0.0; double fx;
            h = (b - a) / n;
            for (int i = 1; i <= n; i++)
            { x = a + i * h; fx = f(x); sum += fx; }
            return (sum * h);
        }
        /// <summary>
        /// Основная функция
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static double f(double x)
        {
            return x * Math.Pow(Math.E, x);
        }
        //<summary>
        // Метод средних прямоугольников.
        //</summary>
        public static double MiddleRectangleMethod(double a, double b, double eps, double n)
        {
            double s, s1, h = b - a;
            s = h * f(((a + b) / 2));
            do
            {
                h = (b - a) / n;
                s1 = s;
                s = 0;
                for (int k = 0; k <= n - 1; k++)
                {
                    s = s + f((a + h / 2 + k * h));
                }
                s = s * h;
            } while (((Math.Abs(s - s1)) / 3) > eps);
            return s;
        }
        /// <summary>
        /// Метод правых прямоугольников
        /// </summary>
        public static double RightRectangleMethod(double a, double b, double eps)
        {
            //double a = ((double)tabPage4_numericUpDown7.Value), b = ((double)tabPage4_numericUpDown8.Value), eps = ((double)tabPage4_numericUpDown9.Value);
            double s1, s; int n = 1;
            s1 = IntegrateRight(a, b, n);
            do
            {
                s = s1;
                n = 2 * n;
                s1 = IntegrateRight(a, b, n);
            } while (Math.Abs(s1 - s) > eps);
            return s1;
        }
        /// <summary>
        /// Метод левых прямоугольников
        /// </summary>
        public static double LeftRectangleMethod(double a, double b, double eps)
        {

            double s1, s;
            int n = 1;
            s1 = IntegrateLeft(a, b, n);
            do
            {
                s = s1;
                n = 2 * n;
                s1 = IntegrateLeft(a, b, n);
            } while (Math.Abs(s1 - s) > eps);
            return s1;
        }
        /// <summary>
        /// Метод трапеций
        /// </summary>
        public static double TrapezoidMethod(double a, double b, int n)
        {

            double In, dy = (b - a) / n, y = 0; y += f(a) + f(b);
            for (int i = 1; i < n; i++)
            {
                y += 2 * (f(a + dy * i));
            }
            In = Integ(a, b, n, y);

            return In;
        }
        /// <summary>
        /// Метод Симпсона
        /// </summary>
        public static double SimpsonMethod(double a, double b, double eps)
        {
            double I, I1;

            I = eps + 1; I1 = 0;
            for (int N = 2; (N <= 4) || (Math.Abs(I1 - I) > eps); N *= 2)
            {
                double h, sum2 = 0, sum4 = 0, sum = 0;
                h = (b - a) / (2 * N);
                for (int i = 1; i <= 2 * N - 1; i += 2)
                {
                    sum4 += f(a + h * i);
                    sum2 += f(a + h * (i + 1));
                }
                sum = f(a) + 4 * sum4 + 2 * sum2 - f(b); I = I1; I1 = (h / 3) * sum;
            }
            return I1;
        }
    }
}
