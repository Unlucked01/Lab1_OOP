using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab_4
{
    public partial class LINQWindow : Form
    {
        HumansList<Human> _humansList = new HumansList<Human>();
        
        private static Random rnd = new Random();
        readonly static int arrSize = rnd.Next(10,50);
        HumansList<Human>[] _humansArr = new HumansList<Human>[arrSize];

        public LINQWindow()
        {
            InitializeComponent();

            for (int i = 0; i < arrSize; i++)
            {
                HumansList<Human> tempList = new HumansList<Human>();
                for (int j = 0; j < Rndint(rnd,0,50); j++)
                {
                    int age = Rndint(rnd,18,40);
                    double weight = Convert.ToDouble(Rndint(rnd, 40, 90));
                    string name = Rndstringbuilder(rnd);
                    string secondName = Rndstringbuilder(rnd);
                    int numberOfChil = Rndint(rnd, 0, 3);
                    string country = Rndstringbuilder(rnd);
                    int height = Rndint(rnd, 150, 210);
                    Human temp = new Human(age, weight, name, secondName, numberOfChil, country, height);
                    tempList.Add(temp);
                    _humansList.Add(temp);
                }
                _humansArr[i] = tempList;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (Human human in _humansList)
            {
                dataGridView1.Rows.Add(
                    human.Name, 
                    human.SecondName,
                    human.Age,
                    human.Country, 
                    human.Height, 
                    human.Weight, 
                    human.NumberOfChildren);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string Rndstringbuilder(Random rnd)
        {
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
        public int Rndint(Random rndIn,int form, int to)
        {
            return rndIn.Next(form, to);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = $"Запрос 1: Количество коллекций заданных данному размеру ({numericUpDown1.Value}) = ";
            var req1 = from human in _humansArr
                       where human.GetList().Count == numericUpDown1.Value
                       select human;
            richTextBox1.Text += req1.ToList().Count.ToString() + ".\n" + delim();
            richTextBox1.Text += $"Запрос 2: Минимальная длина коллекции в массиве = ";
            var req2 = from human in _humansArr
                       where human.GetList().Count == 0
                       select human;
            richTextBox1.Text += req2.ToList().Count.ToString() + ".\n" + delim();
            richTextBox1.Text += $"Запрос 3: Максимальная длина коллекции в массиве = ";
            var req3 = from human in _humansArr
                       where human.GetList().Count == 50
                       select human;
            richTextBox1.Text += req3.ToList().Count.ToString() + ".\n" + delim();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            _humansList.Sort();
            foreach (Human human in _humansList)
            {
                dataGridView1.Rows.Add(
                    human.Name,
                    human.SecondName,
                    human.Age,
                    human.Country,
                    human.Height,
                    human.Weight,
                    human.NumberOfChildren);
            }
            //richTextBox1.Text = req2.ToString();

            //var req1 = from human in _humansList.GetList()
            //           orderby human.Age > 2 ascending
            //           select human;


            //bool result = _humansList.GetList()
            //    .Skip(2)
            //    .Take(3)
            //    .All(human => human.NumberOfChildren == 0);
            //label2.Text = result.ToString();

            //int count = _humansList
            //    .GetList()
            //    .SkipWhile(human => human.Height < 167)
            //    .TakeWhile(human => human.Age > 0)
            //    .Count();
            //label3.Text = count.ToString();

            //int sum = _humansList
            //     .GetList()
            //     .OrderBy(human => human.Name)
            //     .Take(1)
            //     .Sum(human => human.Age);
            //label4.Text = sum.ToString();

            //bool result2 = _humansList.GetList()
            //     .Where(human => human.Age > 0)
            //     .TakeWhile(human => human.Age < 100)
            //     .Any();
            //label5.Text = result2.ToString();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var human in _humansList)
            {
                stringBuilder.AppendLine(human.ToString());
            }
            using (StreamWriter writer = new StreamWriter(@"C:\Users\Surface\source\repos\OOP_Sharp_LAB\OutFiles\outfile.txt", false))
            {
                await writer.WriteLineAsync(stringBuilder.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string delim()
        {
            return new string('=', 50) + "\n";
        }
    }
}
