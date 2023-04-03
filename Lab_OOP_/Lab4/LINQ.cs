using Lab_OOP_.Lab3;
using Lab2_OOP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_OOP_.Lab4
{
    public partial class LINQ : Form
    {
        TrainStationStack<TrainStation> stations = new();
        private ShowStationsForm? showStationsForm;
        public LINQ(ShowStationsForm form)
        {
            InitializeComponent();
            showStationsForm = form;
        }

        private void LINQ_Load(object sender, EventArgs e)
        {
            stations.Push(new("Пенза", Rndint(), Rndint(), "Поволжский район", Rndint(), Convert.ToDecimal(Rndint()), Rndint() % 2 == 0));
            stations.Push(new("Москва", Rndint(), Rndint(), "Центральный район", Rndint(), Convert.ToDecimal(Rndint()), Rndint() % 2 == 0));
            stations.Push(new("Самара", Rndint(), Rndint(), "Поволжский район", Rndint(), Convert.ToDecimal(Rndint()), Rndint() % 2 == 0));
            stations.Push(new("Астрахань", Rndint(), Rndint(), "Северный район", Rndint(), Convert.ToDecimal(Rndint()), Rndint() % 2 == 0));
            stations.Push(new("Сочи", Rndint(), Rndint(), "Краснодарский край", Rndint(), Convert.ToDecimal(Rndint()), Rndint() % 2 == 0));

            listView1.View = View.Details;
            listView1.Columns.Add("Запрос");
            listView1.Columns.Add("Результат");
            listView1.Columns[0].Width = 1200;
            listView1.Columns[1].Width = 280;
            showStationsForm.ViewGridStation(stations);
        }
        private int Rndint()
        {
            Random rnd = new Random();
            return rnd.Next(0, 10000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sortedStations = stations.OrderBy(c => c.StationName); //Сортировка cтанций по названию в Алфавитном порядке
            showStationsForm.ViewGridStation(sortedStations);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var request1 = stations.Where(s => s.HasWiFi).Count();
            var responce1 = new ListViewItem("Количество станций с наличием WIFI:");
            responce1.SubItems.Add(request1.ToString());

            var request2 = stations.Where(s => s.TicketsSold > 500 & s.TrainsPerDay > 20)
                .OrderByDescending(s => s.StationName)
                .ToArray();
            var responce2 = new ListViewItem("Количество станций у которых более 500 проданных билетов и \nколичество поездов более 20:");
            responce2.SubItems.Add(request2.Length.ToString());

            var request3 = stations.Where(s => s.Location == "Поволжский район")
                .Sum(s => s.TrainsPerDay);
            var responce3 = new ListViewItem("Количество проданных билетов на станциях Поволжского района:");
            responce3.SubItems.Add(request3.ToString());

            var request4 = stations.OrderByDescending(s => s.TrainsPerDay)
                .FirstOrDefault();
            var responce4 = new ListViewItem("Название станции с наименьшим количеством поездов в день:");
            responce4.SubItems.Add(request4.StationName);

            var request5 = stations.Where(s => s.AverageTicketPrice < stations.Average(s => s.AverageTicketPrice))
                .OrderByDescending(s => s.StationName)
                .FirstOrDefault();
            var responce5 = new ListViewItem("Название станции с самой низкой средней ценой билета:");
            responce5.SubItems.Add(request5.StationName);

            listView1.Items.AddRange(new ListViewItem[] { responce1, responce2, responce3, responce4, responce5 });
        }
    }
}
