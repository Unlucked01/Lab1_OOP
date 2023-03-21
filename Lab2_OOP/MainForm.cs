using Lab1;
using System.Runtime.InteropServices;
using static System.Collections.Specialized.BitVector32;

namespace Lab2_OOP
{
    public partial class ShowStationsForm : Form
    {
        static Stack<TrainStation> stationStack = new();
        public ShowStationsForm()
        {
            InitializeComponent();
            stationStack.Push(new("adsdad", 500, 200, "dasdadsdasda", 10, 15.00m, true));
            stationStack.Push(new("adsadasda", 200, 500, "asdasdasdas", 100, 150.00m, false));
            ViewGridStation(stationStack);
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
                dataGridView1.Rows[temp_value].Cells[6].Value = tempStation.HasWiFi ? "Да": "Нет";
            }
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
                Win32.MessageBox(0, ex.Message, "Вызов ошибки", 0);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PerformanceTest test = new PerformanceTest(this, stackStack);
            test.Show();
        }
    }
    public class Win32
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hWnd, String text,
        String caption, uint type);
    }

}