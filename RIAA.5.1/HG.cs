using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIAA._5._1
{
    class HG
    {
        const int size = 2;
        public double Checking(double[] a1, double[] a2)
        {
            double q = 0;
            for (int i = 0; i < size; i++)
            { q += Math.Pow((a1[i] - a2[i]), 2); }
            return q;
        }
        // Функция
        public double Function(double[] _x, double[] d, double l, int shtraf, double mu)
        {
            double[] x = new double[size];
            for (int i = 0; i < size; i++)
            { x[i] = _x[i] + d[i] * l; }
            // Функции
            if (shtraf == 0)
                // ЦПС, Наискорейший спуск
                return 2 * Math.Pow(x[0], 2) + 5 * x[0] * x[1] + 3 * Math.Pow(x[1], 2) + x[0] - x[1];
            else
                // Штрафных функций
                return (4 * Math.Pow(x[0], 2) + Math.Pow(x[1], 2) - 2 * x[1] + mu * Alfa(x));
        }
        // Функция штрафа 
        public double Alfa(double[] r)
        {
            double a = 0.0;
            var alf1 = r[0] * r[0] + r[1] - 1;
            var alf2 = r[0] - r[1];
            if (alf1 > 0)
            // Обратное допустимой 1 половина области и н же штраф
            { a += alf1; }
            if (alf2 > 0)
            // Обратное допустимой 1 половина области и н же штраф
            { a += alf2; }
            return a;
        }
        public double Nach(double[] x1, double[] d, double e_gold, int shtraf, double mu, double[] tb1, double[] tb2)
        {
            double delta = 1, f2 = 0, f1 = f2 - delta, f3 = f2 + delta, q1, q2, q3;
            while (true)
            {
                q1 = Function(x1, d, f1, shtraf, mu);
                q2 = Function(x1, d, f2, shtraf, mu);
                q3 = Function(x1, d, f3, shtraf, mu);
                if (q1 >= q2 && q2 <= q3)
                {
                    return Gold(x1, f1, f3, d, e_gold, shtraf, mu, tb1, tb2);
                }
                else if (q1 < q3)
                {
                    f3 = f2;
                    f2 = f1;
                    f1 = f1 - delta;
                    q1 = Function(x1, d, f1, shtraf, mu);
                }
                else
                {
                    f1 = f2;
                    f2 = f3;
                    f3 = f3 + delta;
                    q3 = Function(x1, d, f3, shtraf, mu);
                }
            }
        }
        public double Gold(double[] x1, double x00, double x33, double[] d, double e_gold, int shtraf, double mu, double[] tb1, double[] tb2)
        {
            double t = ((1 + Math.Sqrt(5)) / 2), b = 1 / t, a = 1 - b, I, x11, f1, f2, x22;
            I = x33 - x00;
            x11 = x00 + a * I;
            x22 = x00 + b * I;
            f1 = Function(x1, d, x11, shtraf, mu);
            f2 = Function(x1, d, x22, shtraf, mu);
            while (Math.Abs(I) > e_gold)
            {
                if (f2 < f1)
                {
                    I = x33 - x11;
                    x00 = x11;
                    x11 = x22;
                    x22 = x00 + b * I;
                    f1 = f2;
                    f2 = Function(x1, d, x22, shtraf, mu);
                }
                else
                {
                    I = x22 - x00;
                    x33 = x22;
                    x22 = x11;
                    x11 = x00 + a * I;
                    f2 = f1;
                    f1 = Function(x1, d, x11, shtraf, mu);
                }
            }
            if (f2 < f1)
                return x22;
            else
                return x11;
        }
    }
}
