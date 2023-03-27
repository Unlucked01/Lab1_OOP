namespace Lab2_OOP
{
    partial class AddStationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            textBox4 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            comboBox1 = new ComboBox();
            label9 = new Label();
            comboBox2 = new ComboBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 69);
            label1.Name = "label1";
            label1.Size = new Size(277, 32);
            label1.TabIndex = 0;
            label1.Text = "Наименование станции";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 127);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 1;
            label2.Text = "Число мест";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 242);
            label3.Name = "label3";
            label3.Size = new Size(211, 32);
            label3.TabIndex = 2;
            label3.Text = "Местоположение";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 297);
            label4.Name = "label4";
            label4.Size = new Size(322, 32);
            label4.TabIndex = 3;
            label4.Text = "Количество поездов в день";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 353);
            label5.Name = "label5";
            label5.Size = new Size(310, 32);
            label5.TabIndex = 4;
            label5.Text = "Средняя стоимость билета";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 406);
            label6.Name = "label6";
            label6.Size = new Size(303, 32);
            label6.TabIndex = 5;
            label6.Text = "Наличие Wi-Fi на станции";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(353, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 39);
            textBox1.TabIndex = 9;
            textBox1.Leave += textBox1_Leave;
            // 
            // button1
            // 
            button1.Location = new Point(12, 524);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 12;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(322, 524);
            button2.Name = "button2";
            button2.Size = new Size(273, 46);
            button2.TabIndex = 13;
            button2.Text = "Добавить станцию";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 186);
            label7.Name = "label7";
            label7.Size = new Size(310, 32);
            label7.TabIndex = 23;
            label7.Text = "Число проданных билетов";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(353, 239);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(243, 39);
            textBox4.TabIndex = 25;
            textBox4.Leave += textBox4_Leave;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(353, 348);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(243, 39);
            numericUpDown1.TabIndex = 32;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(353, 294);
            numericUpDown2.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(243, 39);
            numericUpDown2.TabIndex = 33;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(353, 176);
            numericUpDown3.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(243, 39);
            numericUpDown3.TabIndex = 34;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(353, 117);
            numericUpDown4.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(243, 39);
            numericUpDown4.TabIndex = 35;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Да", "Нет" });
            comboBox1.Location = new Point(353, 406);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(243, 40);
            comboBox1.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 20);
            label9.Name = "label9";
            label9.Size = new Size(183, 32);
            label9.TabIndex = 37;
            label9.Text = "Выбор станции";
            label9.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(353, 12);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(242, 40);
            comboBox2.TabIndex = 38;
            comboBox2.Visible = false;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(322, 462);
            button3.Name = "button3";
            button3.Size = new Size(273, 46);
            button3.TabIndex = 39;
            button3.Text = "Изменить станцию";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // AddStationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 582);
            Controls.Add(button3);
            Controls.Add(comboBox2);
            Controls.Add(label9);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddStationForm";
            Text = "Добавление\\Изменение станции";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label7;
        private TextBox textBox4;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private ComboBox comboBox1;
        private Label label9;
        private ComboBox comboBox2;
        private Button button3;
    }
}