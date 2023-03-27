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
using Lab_OOP_.Lab3;
using Lab1;

namespace Lab2_OOP
{
    public partial class AddStationForm : Form
    {
        private ShowStationsForm showStationsForm;
        private TrainStationStack<TrainStation> trainStations;
        Regex regexString = new(@"^\p{IsCyrillic}+\s*\p{IsCyrillic}*$", RegexOptions.IgnorePatternWhitespace);

        public AddStationForm(ShowStationsForm form, TrainStationStack<TrainStation> stakObj, string type)
        {
            InitializeComponent();
            showStationsForm = form;
            trainStations = stakObj;
            if (type == "Edit")
            {
                label9.Visible = true;
                comboBox2.Visible = true;
                button3.Visible = true;
                button2.Visible = false;
                button3.Location = button2.Location;
                foreach (TrainStation elem in trainStations)
                {
                    comboBox2.Items.Add(elem.StationName);
                }
                comboBox2.SelectedIndex = 0;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            trainStations.Push(
                new(textBox1.Text,
                Convert.ToInt32(numericUpDown4.Value),
                Convert.ToInt32(numericUpDown3.Value),
                textBox4.Text,
                Convert.ToInt32(numericUpDown2.Value),
                numericUpDown1.Value,
                (comboBox1.SelectedText == "Да" ? true : false))
                );

            showStationsForm.ViewGridStation(trainStations);
            this.Close();
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

        private void button3_Click(object sender, EventArgs e)
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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();
            if (!UI.Validate(regexString, input))
            {
                MessageBox.Show("Введите корректное название станции(допускаются только символы Кириллицы)!");
                textBox1.Focus();
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            string input = textBox4.Text.Trim();
            if (!UI.Validate(regexString, input))
            {
                MessageBox.Show("Введите корректное название станции(допускаются только символы Кириллицы)!");
                textBox4.Focus();
            }
        }
    }
}
