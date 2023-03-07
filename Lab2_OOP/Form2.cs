using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1;

namespace Lab2_OOP
{
    public partial class AddStation : Form
    {
        public AddStation()
        {
            InitializeComponent();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Regex regexString = new(@"^\p{IsCyrillic}+\s*\p{IsCyrillic}*$", RegexOptions.IgnorePatternWhitespace);
            Regex regexDecimal = new(@"^\d+,\d+$", RegexOptions.IgnorePatternWhitespace);
            Regex regexBool = new(@"нет|да", RegexOptions.IgnoreCase);
            //1
            if (UI.Validate(regexString, textBox1.Text))
            {
                checkBox1.Text = "OK";
                checkBox1.ForeColor = Color.Green;
                checkBox1.Checked = true;
                textBox1.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Введите корректное название станции(допускаются только символы Кириллицы)!");
                checkBox1.Checked = false;
                textBox1.BackColor = Color.Red;
            }
            //2
            if (UI.Validate(textBox2.Text,0, int.MaxValue))
            {
                checkBox2.Text = "OK";
                checkBox2.ForeColor = Color.Green;
                checkBox2.Checked = true;
                textBox2.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Введите корректное чило сидячих мест!");
                checkBox2.Checked = false;
                textBox2.BackColor = Color.Red;
            }
            //3
            if (UI.Validate(textBox3.Text, 0, int.MaxValue))
            {
                checkBox3.Text = "OK";
                checkBox3.ForeColor = Color.Green;
                checkBox3.Checked = true;
                textBox3.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Введите корректное число проданных билетов!");
                checkBox3.Checked = false;
                textBox3.BackColor = Color.Red;
            }
            //4
            if (UI.Validate(regexString, textBox4.Text))
            {
                checkBox4.Text = "OK";
                checkBox4.ForeColor = Color.Green;
                checkBox4.Checked = true;
                textBox4.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Введите корректное местоположение станции(допускаются только символы Кириллицы)!");
                checkBox3.Checked = false;
                textBox4.BackColor = Color.Red;
            }
            //5
            if (UI.Validate(textBox5.Text, 0, int.MaxValue))
            {
                checkBox5.Text = "OK";
                checkBox5.ForeColor = Color.Green;
                checkBox5.Checked = true;
                textBox5.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Введите корректное число поездов в день!");
                checkBox5.Checked = false;
                textBox5.BackColor = Color.Red;
            }
            //6
            if (UI.Validate(regexDecimal, textBox6.Text))
            {
                checkBox6.Text = "OK";
                checkBox6.ForeColor = Color.Green;
                checkBox6.Checked = true;
                textBox6.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Введите корректные данные о средней стоимости билета(неотрицательное вещественное число)!");
                checkBox6.Checked = false;
                textBox6.BackColor = Color.Red;
            }
            //7
            if (UI.Validate(regexBool, textBox7.Text))
            {
                checkBox7.Text = "OK";
                checkBox7.ForeColor = Color.Green;
                checkBox7.Checked = true;
                textBox7.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Введите корректные данные о наличии WIFI (да или нет)!");
                checkBox7.Checked = false;
                textBox7.BackColor = Color.Red;
            }
            /*Convert.ToDecimal(textBox6)*/ /*UI.Validate(regexBool, textBox7.Text)*/
            TrainStation stn = new(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text), 11.2m, true);
            ShowStations.AddStation(stn);
            ShowStations primalForm = new ShowStations();
            primalForm.Show();
            this.Hide();
            //ShowStations.PrintNewStation();
        }
    }
}
