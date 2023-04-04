using Lab_OOP_.Lab3;
using Lab_OOP_.Lab4;
using Lab1;
using System.Runtime.InteropServices;

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
        public void ViewGridStation(dynamic stationStack)
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
            button7.Enabled = true;
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
            button7.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                throw new MyDivideByZeroException();
            }
            catch (MyDivideByZeroException ex)
            {
                Win32.MessageBox(0, ex.Message, "Деление на 0 невозможно!", 0);
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
            if (stationStack.Count > 0)
            {
                stationStack.Pop();
                ViewGridStation(stationStack);
            }
            else
            {
                MessageBox.Show("Стек пуст!", "Внимание");
                button7.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TrainStationStack<TrainStation>? tempStations = test.trainStations;
            for (int i = 0; i < tempStations.Count; i++)
            {
                dataGridView1.Rows.Clear();
            }
            button8.Visible = false;
            button8.Enabled = false;
            button7.Visible = true;
            button8.Location = button7.Location;
            ViewGridStation(stationStack);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LINQ LinqForm = new LINQ(this);
            LinqForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ListLINQ listLINQForm = new ListLINQ();
            listLINQForm.Show();
        }
    }
    public class Win32
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hWnd, String text,
        String caption, uint type);
    }

}