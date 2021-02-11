namespace fraction_calc
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
            this.textBox_firstNumber = new System.Windows.Forms.TextBox();
            this.textBox_secondNumber = new System.Windows.Forms.TextBox();
            this.button_countResult = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_firstNumber
            // 
            this.textBox_firstNumber.Location = new System.Drawing.Point(15, 111);
            this.textBox_firstNumber.Name = "textBox_firstNumber";
            this.textBox_firstNumber.Size = new System.Drawing.Size(150, 20);
            this.textBox_firstNumber.TabIndex = 1;
            this.textBox_firstNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCheck);
            // 
            // textBox_secondNumber
            // 
            this.textBox_secondNumber.Location = new System.Drawing.Point(267, 111);
            this.textBox_secondNumber.Name = "textBox_secondNumber";
            this.textBox_secondNumber.Size = new System.Drawing.Size(150, 20);
            this.textBox_secondNumber.TabIndex = 6;
            this.textBox_secondNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCheck);
            // 
            // button_countResult
            // 
            this.button_countResult.Location = new System.Drawing.Point(423, 109);
            this.button_countResult.Name = "button_countResult";
            this.button_countResult.Size = new System.Drawing.Size(75, 23);
            this.button_countResult.TabIndex = 7;
            this.button_countResult.Text = "Рассчёт";
            this.button_countResult.UseVisualStyleBackColor = true;
            this.button_countResult.Click += new System.EventHandler(this.button_countResult_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(504, 111);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(200, 20);
            this.textBox_result.TabIndex = 8;
            this.textBox_result.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(176, 77);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Сумма";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(176, 100);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Разность";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(176, 123);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "Умножение";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(176, 146);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(70, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.Text = "Деление";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(15, 25);
            this.trackBar1.Maximum = 6;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(182, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Количество знаков после запятой (0-6):";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(360, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(344, 85);
            this.textBox1.TabIndex = 9;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "     Придерживайтесь формата ±a ± b (Пробелы обязательны)\r\n     Варианты:\r\n     -" +
    "3.5 + 8\r\n     -21/6 + 8\r\n     -3,5 + 8\r\n     3.5 - -3/-5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 176);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_countResult);
            this.Controls.Add(this.textBox_secondNumber);
            this.Controls.Add(this.textBox_firstNumber);
            this.Name = "Form1";
            this.Text = "Калькулятор комплексных чисел";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_firstNumber;
        private System.Windows.Forms.TextBox textBox_secondNumber;
        private System.Windows.Forms.Button button_countResult;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

