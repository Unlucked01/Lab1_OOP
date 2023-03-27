using Lab_OOP_.Lab2;
using Lab_OOP_.Lab3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2_OOP
{
    public partial class PerformanceTest : Form
    {
        public TrainStationStack<TrainStation>? trainStations = new();
        private static readonly int N = 1000;
        private static readonly string reference = "test";
        TrainStation? tempStation;
        private TrainStation[] arrStations = new TrainStation[N];
        private ShowStationsForm showStationsForm;
        public PerformanceTest(ShowStationsForm form)
        {
            InitializeComponent();
            showStationsForm = form;

            listView1.View = View.Details;
            listView1.Columns.Add("Collection");
            listView1.Columns.Add("ElapsedTimeNormally");
            listView1.Columns.Add("ElapsedTimeRandomly");
            listView1.Columns[0].Width = 350;
            listView1.Columns[1].Width = 350;
            listView1.Columns[2].Width = 350;
        }
        private string rndstringbuilder()
        {
            Random rnd = new Random();
            int start = 0x0410; //a
            int end = 0x044f; //Я
            int length = rnd.Next(5, 11);
            StringBuilder builder = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                int code = rnd.Next(start, end + 1);
                builder.Append((char)code);
            }
            return builder.ToString();
        }
        private int rndint()
        {
            Random rnd = new Random();
            return rnd.Next(0, 10000);
        }
        private bool rndbool()
        {
            Random rnd = new Random();
            return rnd.Next(0, 2) == 0;
        }
        private void MeasureElapsedTime(string collectionName, TrainStationStack<TrainStation> collection, string referenceValue, Action<TrainStation> action)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach (TrainStation st in collection)
            {
                action(st);
            }
            stopwatch.Stop();

            var elapsedTimeNormally = stopwatch.ElapsedTicks;

            stopwatch.Restart();
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                int index = random.Next(0, N);
                tempStation = collection.ElementAt(index);
                tempStation.StationName = referenceValue;
            }
            stopwatch.Stop();

            var elapsedTimeRandomly = stopwatch.ElapsedTicks;

            var item = new ListViewItem(collectionName);
            item.SubItems.Add(elapsedTimeNormally.ToString());
            item.SubItems.Add(elapsedTimeRandomly.ToString());

            listView1.Items.Add(item);

            showStationsForm.ViewGridStation(stationStack: trainStations);
        }
        private void MeasureElapsedTime(string collectionName, TrainStation[] collection, string referenceValue, Action<TrainStation> action)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach (TrainStation st in collection)
            {
                action(st);
            }
            stopwatch.Stop();

            var elapsedTimeNormally = stopwatch.ElapsedTicks;

            stopwatch.Restart();
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                int index = random.Next(0, N);
                tempStation = collection.ElementAt(index);
                tempStation.StationName = referenceValue;
            }
            stopwatch.Stop();

            var elapsedTimeRandomly = stopwatch.ElapsedTicks;

            var item = new ListViewItem(collectionName);
            item.SubItems.Add(elapsedTimeNormally.ToString());
            item.SubItems.Add(elapsedTimeRandomly.ToString());

            listView1.Items.Add(item);

            showStationsForm.ViewGridStation(stationStack: trainStations);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadingForm load = new LoadingForm();
            load.Show();
            for (int i = 0; i < N; i++)
            {
                trainStations.Push(new TrainStation(rndstringbuilder(), rndint(), rndint(), rndstringbuilder(), rndint(), Convert.ToInt32(rndint()), rndbool()));
                arrStations[i] = new TrainStation(rndstringbuilder(), rndint(), rndint(), rndstringbuilder(), rndint(), Convert.ToInt32(rndint()), rndbool());
            }
            MeasureElapsedTime("Stack", trainStations, reference, st => st.StationName = reference);
            MeasureElapsedTime("Array", arrStations, reference, st => st.StationName = reference);
            load.Close();
            button2.Enabled = false;
        }
    }
}