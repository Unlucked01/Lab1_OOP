using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2_OOP
{
    public partial class PerformanceTest : Form
    {
        private TrainStationStack? trainStations = new();
        private static readonly int N = 100000;
        private TrainStation[] arrStations = new TrainStation[N];
        private ShowStationsForm showStationsForm;
        public PerformanceTest(ShowStationsForm form, TrainStationStack stackObj)
        {
            InitializeComponent();
            showStationsForm = form;
            listView1.View = View.Details;
            listView1.Columns.Add("Collection");
            listView1.Columns.Add("ElapsedTime");
            listView1.Columns[0].Width = 350;
            listView1.Columns[1].Width = 350;
            for (int i = 0; i < N; i++)
            {
                trainStations.Push(new(RndStringBuilder(), RndInt(), RndInt(), RndStringBuilder(), RndInt(), Convert.ToDecimal(RndInt()), RndBool()));
            }

            for (int i = 0; i < N; i++)
            {
                arrStations[i] = new(RndStringBuilder(), RndInt(), RndInt(), RndStringBuilder(), RndInt(), Convert.ToDecimal(RndInt()), RndBool());
            }
            ListViewItem StackNumber = new ListViewItem("Stack");
            StackNumber.SubItems.Add(addToStack().ToString());
            showStationsForm.ViewGridStation(stationStack: trainStations);
            ListViewItem ArrayNumber = new ListViewItem("Array");
            ArrayNumber.SubItems.Add(addToArray().ToString());
            listView1.Items.AddRange(new ListViewItem[] { StackNumber, ArrayNumber });
        }
        private string RndStringBuilder()
        {
            Random rnd = new Random();
            int start = 0x0410;
            int end = 0x044F;
            int length = rnd.Next(5, 11);
            StringBuilder builder = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                int code = rnd.Next(start, end + 1);
                builder.Append((char)code);
            }
            return builder.ToString();
        }
        private int RndInt()
        {
            Random rnd = new Random();
            return rnd.Next(0, 10000);
        }
        private bool RndBool()
        {
            Random rnd = new Random();
            return rnd.Next(0, 2) == 0;
        }
        private long addToArray()
        {
            TrainStation[] randomStations = new TrainStation[N];
            Random rnd = new Random();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        private long addToStack()
        {
            TrainStationStack randomStations = new();
            Random rnd = new Random();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (randomStations.Count < N)
            {
                int index = rnd.Next(trainStations.Count);
                trainStations.Push(trainStations.ElementAt(index));
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
