using Lab_OOP_.Lab3;
using Lab1;
using System.Runtime.InteropServices;
using static System.Collections.Specialized.BitVector32;

namespace Lab2_OOP
{
    public partial class ShowStationsForm : Form
    {
        static readonly TrainStationStack<TrainStation>? stationStack = new();
        readonly StackListener<TrainStation> listener = new(stationStack);
        PerformanceTest test;

        public ShowStationsForm()
        {
            InitializeComponent();
            stationStack.Push(new("Пенза", 500, 200, "Центральный район", 10, 15.00m, true));
            ViewGridStation(stationStack);
            button8.Visible = false;
        }
        public void ViewGridStation(Stack<TrainStation> stationStack)
        {
            dataGridView1.Rows.Clear();
            foreach (TrainStation tempStation in stationStack)
            {
                int temp_value = dataGridView1.Rows.Add();
                dataGridView1.Rows[temp_value].Cells[0].Value = tempStation.StationName;
                dataGridView1.Rows[temp_value].Cells[1].Value = tempStation.SeatsNumber;
                dataGridView1.Rows[temp_value].Cells[2].Value = tempStation.TicketsSold;
                dataGridView1.Rows[temp_value].Cells[3].Value = tempStation.Location;
                dataGridView1.Rows[temp_value].Cells[4].Value = tempStation.TrainsPerDay;
                dataGridView1.Rows[temp_value].Cells[5].Value = tempStation.AverageTicketPrice;
                dataGridView1.Rows[temp_value].Cells[6].Value = tempStation.HasWiFi ? "Да" : "Нет";
            }
            dataGridView1.AutoResizeColumns();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddStationForm additionalForm = new AddStationForm(this, stationStack, "Add");
            additionalForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HEXForm hexForm = new HEXForm(stationStack);
            hexForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStationForm additionalForm = new AddStationForm(this, stationStack, "Edit");
            additionalForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                throw new MyDivideByZeroException();
            }
            catch (MyDivideByZeroException ex)
            {
                Win32.MessageBox(0, ex.Message, "Âûçîâ îøèáêè", 0);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            test = new PerformanceTest(this);
            test.Show();
            button8.Visible = true;
            button7.Visible = false;
            button8.Location = button7.Location;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            stationStack.Pop();
            ViewGridStation(stationStack);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TrainStationStack<TrainStation>? tempStations = test.trainStations;
            for (int i = 0; i < tempStations.Count; i++)
            {
                dataGridView1.Rows.Clear();
            }
        }
    }
    public class Win32
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hWnd, String text,
        String caption, uint type);
    }

}