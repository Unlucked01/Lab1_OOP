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
using static System.Windows.Forms.DataFormats;

namespace Lab2_OOP
{
    public partial class AddStationForm : Form
    {
        private ShowStationsForm showStationsForm;
        private Stack<TrainStation> trainStations;
        
        public AddStationForm(ShowStationsForm form, Stack<TrainStation> stakObj, string type)
        {
            InitializeComponent();
            showStationsForm = form;
            trainStations = stakObj;
            if(type == "Edit")
            {
                foreach (TrainStation elem in trainStations)
                {
                    comboBox2.Items.Add(elem.StationName);
                }
                comboBox2.SelectedIndex = 0;
            }
            else
            {
                label9.Enabled = false;
                comboBox2.Enabled = false;
                button3.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (validate()) 
            {
                trainStations.Push(new(textBox1.Text, Convert.ToInt32(numericUpDown4.Value), 
                    Convert.ToInt32(numericUpDown3.Value), textBox4.Text, Convert.ToInt32(numericUpDown2.Value), 
                    numericUpDown1.Value, (comboBox1.SelectedText == "Да" ? true : false)));

                showStationsForm.ViewGridStation(trainStations);
                this.Close();
            }
            else
            {
                negativeSituation();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void print(TrainStation station)
        {
            textBox1.Text = station.StationName;
            numericUpDown4.Value = station.SeatsNumber;
            numericUpDown3.Value = station.TicketsSold;
            textBox4.Text = station.Location;
            numericUpDown2.Value = station.TrainsPerDay;
            numericUpDown1.Value = station.AverageTicketPrice;
            comboBox1.SelectedIndex = (station.HasWiFi) ? 0 : 1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedStation = comboBox2.SelectedItem as string;
            if (selectedStation != null)
            {
                TrainStation? tempStation = trainStations.FirstOrDefault(s => s.StationName == selectedStation);
                print(tempStation);
            }
        }

        private bool validate()
        {
            
            Regex regexString = new(@"^\p{IsCyrillic}+\s*\p{IsCyrillic}*$", RegexOptions.IgnorePatternWhitespace);
            checkBox1.Checked = UI.Validate(regexString, textBox1.Text);
            checkBox2.Checked = (numericUpDown4.Value >= 0m);
            checkBox3.Checked = (numericUpDown3.Value >= 0m);
            checkBox4.Checked = UI.Validate(regexString, textBox4.Text);
            checkBox5.Checked = (numericUpDown2.Value >= 0m);
            checkBox6.Checked = (numericUpDown1.Value >= 0m);
            checkBox7.Checked = (comboBox1.SelectedIndex != -1);
            return Controls.OfType<CheckBox>().All(c => c.Checked);
        }
        private void negativeSituation()
        {
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    if (checkBox.Checked)
                    {
                        continue;
                    }
                    else
                    {
                        switch (checkBox.Name)
                        {
                            case "checkBox1":
                                MessageBox.Show("Введите корректное название станции(допускаются только символы Кириллицы)!");
                                textBox1.BackColor = Color.Red;
                                break;
                            case "checkBox2":
                                MessageBox.Show("Введите корректное чило сидячих мест!");
                                numericUpDown4.BackColor = Color.Red;
                                break;
                            case "checkBox3":
                                MessageBox.Show("Введите корректное число проданных билетов!");
                                numericUpDown3.BackColor = Color.Red;
                                break;
                            case "checkBox4":
                                MessageBox.Show("Введите корректное местоположение станции(допускаются только символы Кириллицы)!");
                                textBox4.BackColor = Color.Red;
                                break;
                            case "checkBox5":
                                MessageBox.Show("Введите корректное число поездов в день!");
                                numericUpDown2.BackColor = Color.Red;
                                break;
                            case "checkBox6":
                                MessageBox.Show("Введите корректные данные о средней стоимости билета(неотрицательное вещественное число)!");
                                numericUpDown1.BackColor = Color.Red;
                                break;
                            case "checkBox7":
                                MessageBox.Show("Выберите корректную информацию о наличии WIFI на станции (Да или Нет)!");
                                break;
                        }
                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                TrainStation? tempStation = trainStations.FirstOrDefault(s => s.StationName == comboBox2.SelectedItem as string);
                tempStation.StationName = textBox1.Text;
                tempStation.SeatsNumber = Convert.ToInt32(numericUpDown4.Value);
                tempStation.TicketsSold = Convert.ToInt32(numericUpDown3.Value);
                tempStation.Location = textBox4.Text;
                tempStation.TrainsPerDay = Convert.ToInt32(numericUpDown2.Value);
                tempStation.AverageTicketPrice = numericUpDown1.Value;
                tempStation.HasWiFi = (comboBox1.SelectedText == "Да" ? true : false);

                showStationsForm.ViewGridStation(trainStations);
                this.Close();
            }
            else
            {
                negativeSituation();
            }
        }
    }
}
