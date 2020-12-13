
namespace Calculator
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
            this.Output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Output.Location = new System.Drawing.Point(2, 3);
            this.Output.MinimumSize = new System.Drawing.Size(218, 44);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(218, 44);
            this.Output.TabIndex = 0;
            this.Output.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "%";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PrintNumberOrOperation);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "√";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AdvancedOperation);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(114, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "x²";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AdvancedOperation);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(170, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "1/x";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AdvancedOperation);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(170, 108);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 49);
            this.button5.TabIndex = 8;
            this.button5.Text = "÷";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.PrintNumberOrOperation);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(114, 108);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 49);
            this.button6.TabIndex = 7;
            this.button6.Text = "←";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.DeleteLastSign);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(58, 108);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 49);
            this.button7.TabIndex = 6;
            this.button7.Text = "C";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ClearCalculations);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(2, 108);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 49);
            this.button8.TabIndex = 5;
            this.button8.Text = "CE";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ClearCalculations);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(170, 163);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 49);
            this.button9.TabIndex = 12;
            this.button9.Text = "×";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.PrintNumberOrOperation);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(114, 163);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 49);
            this.button10.TabIndex = 11;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.PrintNumberOrOperation);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(58, 163);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 49);
            this.button11.TabIndex = 10;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.PrintNumberOrOperation);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(2, 163);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(50, 49);
            this.button12.TabIndex = 9;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.PrintNumberOrOperation);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(170, 218);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(50, 49);
            this.button13.TabIndex = 16;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.PrintNumberOrOperation);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(114, 218);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(50, 49);
            this.button14.TabIndex = 15;
            this.button14.Text = "6";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.PrintNumberOrOperation);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(58, 218);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(50, 49);
            this.button15.TabIndex = 14;
            this.button15.Text = "5";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.PrintNumberOrOperation);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(2, 218);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(50, 49);
            this.button16.TabIndex = 13;
            this.button16.Text = "4";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.PrintNumberOrOperation);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(170, 273);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(50, 49);
            this.button17.TabIndex = 20;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.PrintNumberOrOperation);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(114, 273);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(50, 49);
            this.button18.TabIndex = 19;
            this.button18.Text = "3";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.PrintNumberOrOperation);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(58, 273);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(50, 49);
            this.button19.TabIndex = 18;
            this.button19.Text = "2";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.PrintNumberOrOperation);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(2, 273);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(50, 49);
            this.button20.TabIndex = 17;
            this.button20.Text = "1";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.PrintNumberOrOperation);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(170, 328);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(50, 49);
            this.button21.TabIndex = 24;
            this.button21.Text = "=";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.Calculate);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(114, 328);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(50, 49);
            this.button22.TabIndex = 23;
            this.button22.Text = ",";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.PrintСomma);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(58, 328);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(50, 49);
            this.button23.TabIndex = 22;
            this.button23.Text = "0";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.PrintNumberOrOperation);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(2, 328);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(50, 49);
            this.button24.TabIndex = 21;
            this.button24.Text = "±";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.InvertSign);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 382);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
    }
}

