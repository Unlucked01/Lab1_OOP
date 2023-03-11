using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_OOP
{
    public partial class HEXForm : Form
    {
        Stack<TrainStation> trainStations;
        public HEXForm(Stack<TrainStation> stations)
        {
            InitializeComponent();
            trainStations = stations;
            foreach (TrainStation elem in stations)
            {
                comboBox1.Items.Add(elem.StationName);
            }

            comboBox1.SelectedIndex = 0;

            string[] fieldInt = new string[] { "Число мест", "Число проданных билетов", "Количество поездов в день", "Средняя стоимость билета" };

            comboBox2.Items.AddRange(fieldInt);
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (TrainStation elem in trainStations)
            {
                if (elem.StationName == comboBox1.SelectedItem.ToString())
                {
                    int field = elem.GetIntField(comboBox2.SelectedItem.ToString());
                    textBox2.Text = field.ToString();
                    textBox1.Text = field.ToString("X");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
