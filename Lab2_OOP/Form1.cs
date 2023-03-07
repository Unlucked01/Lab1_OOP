using Lab1;

namespace Lab2_OOP
{
    public partial class ShowStations : Form
    {
        static Stack<TrainStation> stationStack = new();
        public ShowStations()
        {
            InitializeComponent();
            AddStation(new("adsdad", 500, 200, "dasdadsdasda", 10, 15.00m, true));
            AddStation(new("adsadasda", 200, 500, "asdasdasdas", 100, 150.00m, false));
            foreach (TrainStation tempStation in stationStack)
            {
                ViewGridStation(tempStation);
            }
        }
        public static void AddStation(TrainStation station)
        {
            stationStack.Push(station);
        }
        public void ViewGridStation(TrainStation station)
        {
            int temp_value = dataGridView1.Rows.Add();
            dataGridView1.Rows[temp_value].Cells[0].Value = station.StationName;
            dataGridView1.Rows[temp_value].Cells[1].Value = station.SeatsNumber;
            dataGridView1.Rows[temp_value].Cells[2].Value = station.TicketsSold;
            dataGridView1.Rows[temp_value].Cells[3].Value = station.Location;
            dataGridView1.Rows[temp_value].Cells[4].Value = station.TrainsPerDay;
            dataGridView1.Rows[temp_value].Cells[5].Value = station.AverageTicketPrice;
            dataGridView1.Rows[temp_value].Cells[6].Value = station.HasWiFi;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddStation additionalForm = new AddStation();
            additionalForm.Show();
        }
    }
}