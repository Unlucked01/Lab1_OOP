﻿namespace Lab_OOP_.Lab4
{
    partial class ListLINQ
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
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(1057, 824);
            button1.Name = "button1";
            button1.Size = new Size(296, 46);
            button1.TabIndex = 0;
            button1.Text = "Создать коллекцию";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(901, 882);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Enabled = false;
            button2.Location = new Point(1081, 772);
            button2.Name = "button2";
            button2.Size = new Size(272, 46);
            button2.TabIndex = 2;
            button2.Text = "Выполнить операции";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(1156, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 39);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(897, 21);
            label1.Name = "label1";
            label1.Size = new Size(223, 64);
            label1.TabIndex = 4;
            label1.Text = "Введите значение \r\nдля поиска";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(897, 98);
            label2.Name = "label2";
            label2.Size = new Size(253, 64);
            label2.TabIndex = 5;
            label2.Text = "Введите размерность\r\nдля поиска";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown1.Location = new Point(1156, 108);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(197, 39);
            numericUpDown1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(715, 123);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 7;
            // 
            // ListLINQ
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 882);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "ListLINQ";
            Text = "ListLINQ";
            Load += ListLINQ_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
    }
}