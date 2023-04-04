namespace Lab2_OOP
{
    partial class ShowStationsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1685, 404);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Наименование станции";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Число мест";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Число проданных билетов";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Местоположение";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Количество поездов в день";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Средняя стоимость билета";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Наличие WiFi на станции";
            Column7.MinimumWidth = 10;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(1205, 347);
            button1.Name = "button1";
            button1.Size = new Size(231, 46);
            button1.TabIndex = 1;
            button1.Text = "Изменить объект";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(1442, 347);
            button2.Name = "button2";
            button2.Size = new Size(231, 46);
            button2.TabIndex = 2;
            button2.Text = "Добавить объект";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Enabled = false;
            button3.Location = new Point(958, 295);
            button3.Name = "button3";
            button3.Size = new Size(354, 46);
            button3.TabIndex = 3;
            button3.Text = "Вывести поле в HEX-формате";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.Enabled = false;
            button4.Location = new Point(1318, 295);
            button4.Name = "button4";
            button4.Size = new Size(354, 46);
            button4.TabIndex = 4;
            button4.Text = "Вывести исключение";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.Location = new Point(12, 347);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 5;
            button5.Text = "Выход";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.Enabled = false;
            button6.Location = new Point(691, 294);
            button6.Name = "button6";
            button6.Size = new Size(258, 46);
            button6.TabIndex = 6;
            button6.Text = "Производительность";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button7.Location = new Point(964, 347);
            button7.Name = "button7";
            button7.Size = new Size(234, 46);
            button7.TabIndex = 7;
            button7.Text = "Удалить элемент";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button8.Location = new Point(451, 295);
            button8.Name = "button8";
            button8.Size = new Size(234, 47);
            button8.TabIndex = 8;
            button8.Text = "Очистить таблицу";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(780, 347);
            button9.Name = "button9";
            button9.Size = new Size(178, 46);
            button9.TabIndex = 9;
            button9.Text = "LINQ";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(624, 348);
            button10.Name = "button10";
            button10.Size = new Size(150, 46);
            button10.TabIndex = 10;
            button10.Text = "List-LINQ";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // ShowStationsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1685, 404);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "ShowStationsForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "ЛБ №3 Копылов & Изгарев";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}