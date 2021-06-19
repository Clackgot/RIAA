using System;
using System.Windows.Forms;
namespace RIAA._4
{
    public partial class Form1 : Form
    {
        private Panel inputs;
        private Panel labels;

        private NumericUpDown inputA;
        private NumericUpDown inputB;
        private NumericUpDown inputEps;
        private NumericUpDown inputN;


        public Form1()
        {
            InitializeComponent();
            inputs = panelInputs;
            labels = panelLabels;
        }

        private void Clear()
        {
            inputs.Controls.Clear();
            labels.Controls.Clear();
        }


        /// <summary>
        /// Метод Симпсона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonSimpsonMethod_CheckedChanged(object sender, EventArgs e)
        {
            Clear();

            labels.Controls.Add(new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(0, 2),
                Size = new System.Drawing.Size(46, 17),
                Text = "Левая граница интегрирования",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            });
            labels.Controls.Add(new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(0, 29),
                Size = new System.Drawing.Size(46, 17),
                Text = "Правая граница интегрирования",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            });
            labels.Controls.Add(new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(0, 56),
                Size = new System.Drawing.Size(46, 17),
                Text = "Точность эпсилон",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            });

            inputA = new NumericUpDown()
            {
                DecimalPlaces = 3,
                Increment = new decimal(new int[] {
                    0,
                    0,
                    0,
                    0 }),
                Location = new System.Drawing.Point(3, -1),
                Maximum = new decimal(new int[] {
                    147483648,
                    0,
                    0,
                    0 }),
                Minimum = new decimal(new int[] {
                    147483648,
                    0,
                    0,
                    -2147483648 }),
                Size = new System.Drawing.Size(120, 22),
                Value = 1
            };
            inputB = new NumericUpDown()
            {
                DecimalPlaces = 3,
                Increment = new decimal(new int[] {
            0,
            0,
            0,
            0}),
                Location = new System.Drawing.Point(3, 26),
                Maximum = new decimal(new int[] {
            147483648,
            0,
            0,
            0}),
                Minimum = new decimal(new int[] {
            147483648,
            0,
            0,
            -2147483648}),
                Size = new System.Drawing.Size(120, 22),
                Value = 2
            };
            inputEps = new NumericUpDown()
            {
                DecimalPlaces = 3,
                Increment = new decimal(new int[] {
            0,
            0,
            0,
            0}),
                Location = new System.Drawing.Point(3, 53),
                Maximum = new decimal(new int[] {
            147483648,
            0,
            0,
            0}),
                Minimum = new decimal(new int[] {
            147483648,
            0,
            0,
            -2147483648}),
                Size = new System.Drawing.Size(120, 22),
                Value = 1
            };



            inputs.Controls.Add(inputA);
            inputs.Controls.Add(inputB);
            inputs.Controls.Add(inputEps);
        }



        /// <summary>
        /// Метод трапеций
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonTrapezoidMethod_CheckedChanged(object sender, EventArgs e)
        {
            Clear();

            labels.Controls.Add(new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(0, 2),
                Size = new System.Drawing.Size(46, 17),
                Text = "Левая граница интегрирования",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            });
            labels.Controls.Add(new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(0, 29),
                Size = new System.Drawing.Size(46, 17),
                Text = "Правая граница интегрирования",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            });
            labels.Controls.Add(new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(0, 56),
                Size = new System.Drawing.Size(46, 17),
                Text = "Число отрезков",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            });


            inputA = new NumericUpDown()
            {
                DecimalPlaces = 3,
                Increment = new decimal(new int[] {
            0,
            0,
            0,
            0}),
                Location = new System.Drawing.Point(3, -1),
                Maximum = new decimal(new int[] {
            147483648,
            0,
            0,
            0}),
                Minimum = new decimal(new int[] {
            147483648,
            0,
            0,
            -2147483648}),
                Size = new System.Drawing.Size(120, 22),
                Value = 1
            };
            inputB = new NumericUpDown()
            {
                DecimalPlaces = 3,
                Increment = new decimal(new int[] {
            0,
            0,
            0,
            0}),
                Location = new System.Drawing.Point(3, 26),
                Maximum = new decimal(new int[] {
            147483648,
            0,
            0,
            0}),
                Minimum = new decimal(new int[] {
            147483648,
            0,
            0,
            -2147483648}),
                Size = new System.Drawing.Size(120, 22),
                Value = 2
            };
            inputN = new NumericUpDown()
            {
                DecimalPlaces = 0,
                Increment = new decimal(new int[] {
            0,
            0,
            0,
            0}),
                Location = new System.Drawing.Point(3, 53),
                Maximum = new decimal(new int[] {
            147483648,
            0,
            0,
            0}),
                Minimum = new decimal(new int[] {
            147483648,
            0,
            0,
            -2147483648}),
                Size = new System.Drawing.Size(120, 22),
                Value = 5
            };



            inputs.Controls.Add(inputA);
            inputs.Controls.Add(inputB);
            inputs.Controls.Add(inputN);

        }
        /// <summary>
        /// Метод средних треугольников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonMiddleRectangleMethod_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            labels.Controls.Add(new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(0, 2),
                Size = new System.Drawing.Size(46, 17),
                Text = "Левая граница интегрирования",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            });
            labels.Controls.Add(new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(0, 29),
                Size = new System.Drawing.Size(46, 17),
                Text = "Правая граница интегрирования",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            });
            labels.Controls.Add(new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(0, 56),
                Size = new System.Drawing.Size(46, 17),
                Text = "Число отрезков",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            });
            labels.Controls.Add(new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(0, 83),
                Size = new System.Drawing.Size(46, 17),
                Text = "Точность эпсилон",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            });

            inputA = new NumericUpDown()
            {
                DecimalPlaces = 3,
                Increment = new decimal(new int[] {
            0,
            0,
            0,
            0}),
                Location = new System.Drawing.Point(3, -1),
                Maximum = new decimal(new int[] {
            147483648,
            0,
            0,
            0}),
                Minimum = new decimal(new int[] {
            147483648,
            0,
            0,
            -2147483648}),
                Size = new System.Drawing.Size(120, 22),
                Value = 1
            };
            inputB = new NumericUpDown()
            {
                DecimalPlaces = 3,
                Increment = new decimal(new int[] {
            0,
            0,
            0,
            0}),
                Location = new System.Drawing.Point(3, 26),
                Maximum = new decimal(new int[] {
            147483648,
            0,
            0,
            0}),
                Minimum = new decimal(new int[] {
            147483648,
            0,
            0,
            -2147483648}),
                Size = new System.Drawing.Size(120, 22),
                Value = 2
            };

            inputN = new NumericUpDown()
            {
                DecimalPlaces = 0,
                Increment = new decimal(new int[] {
            0,
            0,
            0,
            0}),
                Location = new System.Drawing.Point(3, 53),
                Maximum = new decimal(new int[] {
            147483648,
            0,
            0,
            0}),
                Minimum = new decimal(new int[] {
            147483648,
            0,
            0,
            -2147483648}),
                Size = new System.Drawing.Size(120, 22),
                Value = 10
            };

            inputEps = new NumericUpDown()
            {
                DecimalPlaces = 3,
                Increment = new decimal(new int[] {
            0,
            0,
            0,
            0}),
                Location = new System.Drawing.Point(3, 80),
                Maximum = new decimal(new int[] {
            147483648,
            0,
            0,
            0}),
                Minimum = new decimal(new int[] {
            147483648,
            0,
            0,
            -2147483648}),
                Size = new System.Drawing.Size(120, 22),
                Value = (decimal)(0.004)
            };


            inputs.Controls.Add(inputA);
            inputs.Controls.Add(inputB);
            inputs.Controls.Add(inputN);
            inputs.Controls.Add(inputEps);

        }
        /// <summary>
        /// Метод левых треугольников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonLeftRectangleMethod_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            labels.Controls.Add(new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(0, 2),
                Size = new System.Drawing.Size(46, 17),
                Text = "Левая граница интегрирования",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            });
            labels.Controls.Add(new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(0, 29),
                Size = new System.Drawing.Size(46, 17),
                Text = "Правая граница интегрирования",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            });
            labels.Controls.Add(new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(0, 56),
                Size = new System.Drawing.Size(46, 17),
                Text = "Точность эпсилон",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            });


            inputA = new NumericUpDown()
            {
                DecimalPlaces = 3,
                Increment = new decimal(new int[] {
            0,
            0,
            0,
            0}),
                Location = new System.Drawing.Point(3, -1),
                Maximum = new decimal(new int[] {
            147483648,
            0,
            0,
            0}),
                Minimum = new decimal(new int[] {
            147483648,
            0,
            0,
            -2147483648}),
                Size = new System.Drawing.Size(120, 22),
                Value = 1
            };
            inputB = new NumericUpDown()
            {
                DecimalPlaces = 3,
                Increment = new decimal(new int[] {
            0,
            0,
            0,
            0}),
                Location = new System.Drawing.Point(3, 26),
                Maximum = new decimal(new int[] {
            147483648,
            0,
            0,
            0}),
                Minimum = new decimal(new int[] {
            147483648,
            0,
            0,
            -2147483648}),
                Size = new System.Drawing.Size(120, 22),
                Value = 2
            };
            inputEps = new NumericUpDown()
            {
                DecimalPlaces = 3,
                Increment = new decimal(new int[] {
            0,
            0,
            0,
            0}),
                Location = new System.Drawing.Point(3, 53),
                Maximum = new decimal(new int[] {
            147483648,
            0,
            0,
            0}),
                Minimum = new decimal(new int[] {
            147483648,
            0,
            0,
            -2147483648}),
                Size = new System.Drawing.Size(120, 22),
                Value = (decimal)(0.004)
            };


            inputs.Controls.Add(inputA);
            inputs.Controls.Add(inputB);
            inputs.Controls.Add(inputEps);
        }
        /// <summary>
        /// Метод правых треугольников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonRightRectangleMethod_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            labels.Controls.Add(new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(0, 2),
                Size = new System.Drawing.Size(46, 17),
                Text = "Левая граница интегрирования",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            });
            labels.Controls.Add(new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(0, 29),
                Size = new System.Drawing.Size(46, 17),
                Text = "Правая граница интегрирования",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            });
            labels.Controls.Add(new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(0, 56),
                Size = new System.Drawing.Size(46, 17),
                Text = "Точность эпсилон",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            });

            inputA = new NumericUpDown()
            {
                DecimalPlaces = 3,
                Increment = new decimal(new int[] {
            0,
            0,
            0,
            0}),
                Location = new System.Drawing.Point(3, -1),
                Maximum = new decimal(new int[] {
            147483648,
            0,
            0,
            0}),
                Minimum = new decimal(new int[] {
            147483648,
            0,
            0,
            -2147483648}),
                Size = new System.Drawing.Size(120, 22),
                Value = 1
            };
            inputB = new NumericUpDown()
            {
                DecimalPlaces = 3,
                Increment = new decimal(new int[] {
            0,
            0,
            0,
            0}),
                Location = new System.Drawing.Point(3, 26),
                Maximum = new decimal(new int[] {
            147483648,
            0,
            0,
            0}),
                Minimum = new decimal(new int[] {
            147483648,
            0,
            0,
            -2147483648}),
                Size = new System.Drawing.Size(120, 22),
                Value = 2
            };
            inputEps = new NumericUpDown()
            {
                DecimalPlaces = 3,
                Increment = new decimal(new int[] {
                    0,
                    0,
                    0,
                    0 }),
                Location = new System.Drawing.Point(3, 53),
                Maximum = new decimal(new int[] {
                    147483648,
                    0,
                    0,
                    0 }),
                Minimum = new decimal(new int[] {
                    147483648,
                    0,
                    0,
                    -2147483648 }),
                Size = new System.Drawing.Size(120, 22),
                Value = (decimal)(0.004)
            };

            inputs.Controls.Add(inputA);
            inputs.Controls.Add(inputB);
            inputs.Controls.Add(inputEps);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButtonSimpsonMethod.Checked == true)
            {
                labelAnswer.Text = Lib.SimpsonMethod((double)inputA.Value, (double)inputB.Value, (double)inputEps.Value).ToString();
            }
            else if(radioButtonTrapezoidMethod.Checked == true)
            {
                labelAnswer.Text = Lib.TrapezoidMethod((double)inputA.Value, (double)inputB.Value, (int)inputN.Value).ToString();
            }
            else if (radioButtonLeftRectangleMethod.Checked == true)
            {
                labelAnswer.Text = Lib.LeftRectangleMethod((double)inputA.Value, (double)inputB.Value, (double)inputEps.Value).ToString();
            }
            else if (radioButtonRightRectangleMethod.Checked == true)
            {
                labelAnswer.Text = Lib.RightRectangleMethod((double)inputA.Value, (double)inputB.Value, (double)inputEps.Value).ToString();
            }
            else if (radioButtonMiddleRectangleMethod.Checked == true)
            {
                labelAnswer.Text = Lib.MiddleRectangleMethod((double)inputA.Value, (double)inputB.Value, (double)inputEps.Value, (int)inputN.Value).ToString();
            }
        }
    }
}