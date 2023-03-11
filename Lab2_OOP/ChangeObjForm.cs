using Lab1;
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

namespace Lab2_OOP
{
    public partial class ChangeObjForm : Form
    {
        ShowStationsForm ShowStationsForm;
        Stack<TrainStation> trainStations;
        public ChangeObjForm(ShowStationsForm form, Stack<TrainStation> stations)
        {
            InitializeComponent();
            trainStations = stations;
            ShowStationsForm = form;
            foreach (TrainStation elem in stations)
            {
                comboBox1.Items.Add(elem.StationName);
            }

            comboBox1.SelectedIndex = 0;

            string[] fields = new string[] { "Наименование станции", "Число мест", "Число проданных билетов", "Местоположение",
                "Количество поездов в день", "Средняя стоимость билета", "Наличие Wi-Fi на станции"};

            comboBox2.Items.AddRange(fields);
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Regex regexStr = new(@"^\p{IsCyrillic}+\s*\p{IsCyrillic}*$", RegexOptions.IgnorePatternWhitespace);
            Regex regexDecimal = new(@"^\d+,\d+$", RegexOptions.IgnorePatternWhitespace);
            Regex regexBool = new(@"нет|да", RegexOptions.IgnoreCase);

            string? value = textBox1.Text;

            foreach (TrainStation elem in trainStations)
            {
                if (elem.StationName == comboBox1.SelectedItem.ToString())
                {
                    switch (comboBox2.SelectedItem.ToString())
                    {
                        case "Наименование станции":
                            if (UI.Validate(regexStr, value))
                            {
                                elem.StationName = value;
                            }
                            else
                            {
                                MessageBox.Show("Введите корректное название станции(допускаются только символы Кириллицы)!");
                                return;
                            }
                            break;
                        case "Местоположение":
                            if (UI.Validate(regexStr, value))
                            {
                                elem.Location = value;
                            } 
                            else
                            {
                                MessageBox.Show("Введите корректное местоположение станции(допускаются только символы Кириллицы)!");
                                return;
                            }
                            break;
                        case "Число мест":
                            if (UI.Validate(value, 0, int.MaxValue))
                            {
                                elem.SeatsNumber = Int32.Parse(value);
                            }
                            else
                            {
                                MessageBox.Show("Введите корректное чиcло сидячих мест!");
                                return;
                            }
                            break;
                        case "Число проданных билетов":
                            if (UI.Validate(value, 0, int.MaxValue))
                            {
                                elem.TicketsSold = Int32.Parse(value);
                            }
                            else
                            {
                                MessageBox.Show("Введите корректное число проданных билетов!");
                                return;
                            }
                            break;
                        case "Количество поездов в день":
                            if (UI.Validate(value, 0, int.MaxValue))
                            {
                                elem.TrainsPerDay = Int32.Parse(value);
                            }
                            else
                            {
                                MessageBox.Show("Введите корректное число поездов в день!");
                                return;
                            }
                            break;
                        case "Средняя стоимость билета":
                            if (UI.Validate(regexDecimal, value))
                            {
                                elem.AverageTicketPrice = Convert.ToDecimal(value);
                            }
                            else
                            {
                                MessageBox.Show("Введите корректные данные о средней стоимости билета(неотрицательное вещественное число)!");
                                return;
                            }
                            break;
                        case "Наличие Wi-Fi на станции":
                            if (UI.Validate(regexBool, value))
                            {
                                if (value == "Да" || value == "да" || value == "ДА")
                                {
                                    elem.HasWiFi = true;
                                }
                                else
                                {
                                    elem.HasWiFi = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Введите корректные данные о наличии WIFI(да или нет)!");
                                return;
                            }
                            break;
                    }
                    break;
                }
            }
            comboBox1.Items.Clear();
            foreach (TrainStation elem in trainStations)
            {
                comboBox1.Items.Add(elem.StationName);
            }
            comboBox1.SelectedIndex = 0;
            MessageBox.Show("Поле успешно изменено!");
            ShowStationsForm.ViewGridStation(trainStations);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
