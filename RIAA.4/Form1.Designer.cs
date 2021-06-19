
namespace RIAA._4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonSimpsonMethod = new System.Windows.Forms.RadioButton();
            this.radioButtonTrapezoidMethod = new System.Windows.Forms.RadioButton();
            this.radioButtonLeftRectangleMethod = new System.Windows.Forms.RadioButton();
            this.radioButtonRightRectangleMethod = new System.Windows.Forms.RadioButton();
            this.radioButtonMiddleRectangleMethod = new System.Windows.Forms.RadioButton();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.panelInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonSimpsonMethod
            // 
            this.radioButtonSimpsonMethod.AutoSize = true;
            this.radioButtonSimpsonMethod.Location = new System.Drawing.Point(12, 12);
            this.radioButtonSimpsonMethod.Name = "radioButtonSimpsonMethod";
            this.radioButtonSimpsonMethod.Size = new System.Drawing.Size(140, 21);
            this.radioButtonSimpsonMethod.TabIndex = 0;
            this.radioButtonSimpsonMethod.TabStop = true;
            this.radioButtonSimpsonMethod.Text = "Метод Симпсона";
            this.radioButtonSimpsonMethod.UseVisualStyleBackColor = true;
            this.radioButtonSimpsonMethod.CheckedChanged += new System.EventHandler(this.radioButtonSimpsonMethod_CheckedChanged);
            // 
            // radioButtonTrapezoidMethod
            // 
            this.radioButtonTrapezoidMethod.AutoSize = true;
            this.radioButtonTrapezoidMethod.Location = new System.Drawing.Point(12, 39);
            this.radioButtonTrapezoidMethod.Name = "radioButtonTrapezoidMethod";
            this.radioButtonTrapezoidMethod.Size = new System.Drawing.Size(138, 21);
            this.radioButtonTrapezoidMethod.TabIndex = 1;
            this.radioButtonTrapezoidMethod.TabStop = true;
            this.radioButtonTrapezoidMethod.Text = "Метод трапеций";
            this.radioButtonTrapezoidMethod.UseVisualStyleBackColor = true;
            this.radioButtonTrapezoidMethod.CheckedChanged += new System.EventHandler(this.radioButtonTrapezoidMethod_CheckedChanged);
            // 
            // radioButtonLeftRectangleMethod
            // 
            this.radioButtonLeftRectangleMethod.AutoSize = true;
            this.radioButtonLeftRectangleMethod.Location = new System.Drawing.Point(12, 66);
            this.radioButtonLeftRectangleMethod.Name = "radioButtonLeftRectangleMethod";
            this.radioButtonLeftRectangleMethod.Size = new System.Drawing.Size(214, 21);
            this.radioButtonLeftRectangleMethod.TabIndex = 2;
            this.radioButtonLeftRectangleMethod.TabStop = true;
            this.radioButtonLeftRectangleMethod.Text = "Метод левых треугольников";
            this.radioButtonLeftRectangleMethod.UseVisualStyleBackColor = true;
            this.radioButtonLeftRectangleMethod.CheckedChanged += new System.EventHandler(this.radioButtonLeftRectangleMethod_CheckedChanged);
            // 
            // radioButtonRightRectangleMethod
            // 
            this.radioButtonRightRectangleMethod.AutoSize = true;
            this.radioButtonRightRectangleMethod.Location = new System.Drawing.Point(12, 93);
            this.radioButtonRightRectangleMethod.Name = "radioButtonRightRectangleMethod";
            this.radioButtonRightRectangleMethod.Size = new System.Drawing.Size(222, 21);
            this.radioButtonRightRectangleMethod.TabIndex = 3;
            this.radioButtonRightRectangleMethod.TabStop = true;
            this.radioButtonRightRectangleMethod.Text = "Метод правых треугольников";
            this.radioButtonRightRectangleMethod.UseVisualStyleBackColor = true;
            this.radioButtonRightRectangleMethod.CheckedChanged += new System.EventHandler(this.radioButtonRightRectangleMethod_CheckedChanged);
            // 
            // radioButtonMiddleRectangleMethod
            // 
            this.radioButtonMiddleRectangleMethod.AutoSize = true;
            this.radioButtonMiddleRectangleMethod.Location = new System.Drawing.Point(12, 120);
            this.radioButtonMiddleRectangleMethod.Name = "radioButtonMiddleRectangleMethod";
            this.radioButtonMiddleRectangleMethod.Size = new System.Drawing.Size(228, 21);
            this.radioButtonMiddleRectangleMethod.TabIndex = 4;
            this.radioButtonMiddleRectangleMethod.TabStop = true;
            this.radioButtonMiddleRectangleMethod.Text = "Метод средних треугольников";
            this.radioButtonMiddleRectangleMethod.UseVisualStyleBackColor = true;
            this.radioButtonMiddleRectangleMethod.CheckedChanged += new System.EventHandler(this.radioButtonMiddleRectangleMethod_CheckedChanged);
            // 
            // panelLabels
            // 
            this.panelLabels.Controls.Add(this.label4);
            this.panelLabels.Controls.Add(this.label3);
            this.panelLabels.Controls.Add(this.label2);
            this.panelLabels.Controls.Add(this.label1);
            this.panelLabels.Location = new System.Drawing.Point(246, 12);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(242, 128);
            this.panelLabels.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 40, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 40, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 40, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 40, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(0, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(100, 23);
            this.labelResult.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(3, -1);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            147483648,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            147483648,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 3;
            this.numericUpDown2.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(3, 26);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            147483648,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            147483648,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 3;
            this.numericUpDown3.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(3, 53);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            147483648,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            147483648,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown3.TabIndex = 2;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 3;
            this.numericUpDown4.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown4.Location = new System.Drawing.Point(3, 80);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            147483648,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            147483648,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown4.TabIndex = 3;
            // 
            // panelInputs
            // 
            this.panelInputs.Controls.Add(this.numericUpDown4);
            this.panelInputs.Controls.Add(this.numericUpDown3);
            this.panelInputs.Controls.Add(this.numericUpDown2);
            this.panelInputs.Controls.Add(this.numericUpDown1);
            this.panelInputs.Location = new System.Drawing.Point(494, 12);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(133, 129);
            this.panelInputs.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Решить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(352, 155);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(16, 17);
            this.labelAnswer.TabIndex = 9;
            this.labelAnswer.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "x*e^xdx =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 187);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelLabels);
            this.Controls.Add(this.panelInputs);
            this.Controls.Add(this.radioButtonMiddleRectangleMethod);
            this.Controls.Add(this.radioButtonRightRectangleMethod);
            this.Controls.Add(this.radioButtonLeftRectangleMethod);
            this.Controls.Add(this.radioButtonTrapezoidMethod);
            this.Controls.Add(this.radioButtonSimpsonMethod);
            this.Name = "Form1";
            this.Text = "2-5 Леднев Е.В. Курочкин Д.С.";
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.panelInputs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonSimpsonMethod;
        private System.Windows.Forms.RadioButton radioButtonTrapezoidMethod;
        private System.Windows.Forms.RadioButton radioButtonLeftRectangleMethod;
        private System.Windows.Forms.RadioButton radioButtonRightRectangleMethod;
        private System.Windows.Forms.RadioButton radioButtonMiddleRectangleMethod;
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Label label5;
    }
}

