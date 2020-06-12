namespace Task_5
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
            this.A1 = new System.Windows.Forms.NumericUpDown();
            this.M = new System.Windows.Forms.NumericUpDown();
            this.L = new System.Windows.Forms.NumericUpDown();
            this.A3 = new System.Windows.Forms.NumericUpDown();
            this.N = new System.Windows.Forms.NumericUpDown();
            this.A2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).BeginInit();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(39, 13);
            this.A1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.A1.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(120, 20);
            this.A1.TabIndex = 0;
            // 
            // M
            // 
            this.M.Location = new System.Drawing.Point(242, 12);
            this.M.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(120, 20);
            this.M.TabIndex = 1;
            this.M.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // L
            // 
            this.L.Location = new System.Drawing.Point(242, 65);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(120, 20);
            this.L.TabIndex = 2;
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(39, 65);
            this.A3.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.A3.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(120, 20);
            this.A3.TabIndex = 3;
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(242, 39);
            this.N.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(120, 20);
            this.N.TabIndex = 4;
            this.N.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(39, 39);
            this.A2.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.A2.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(120, 20);
            this.A2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "a1 =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "a3 =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "a2 =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "M =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "L =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "N =";
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(289, 108);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 12;
            this.enter.Text = "Ввести";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 108);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 208);
            this.textBox1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Вывод элементов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 328);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.N);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.L);
            this.Controls.Add(this.M);
            this.Controls.Add(this.A1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown A1;
        private System.Windows.Forms.NumericUpDown M;
        private System.Windows.Forms.NumericUpDown L;
        private System.Windows.Forms.NumericUpDown A3;
        private System.Windows.Forms.NumericUpDown N;
        private System.Windows.Forms.NumericUpDown A2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}

