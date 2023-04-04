using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_OOP_.Lab4
{
    public partial class ListLINQ : Form
    {
        private List<string>[] _lists;
        private readonly string delim = new('=', 50);
        public ListLINQ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            List<string>[] list = new List<string>[rndint(1, 25)];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new List<string>();
            }
            for (int k = 0; k < list.Length; k++)
            {
                int collectionLength = rndint(1, 25);
                for (int i = 0; i < collectionLength; i++)
                {
                    list[k].Add(rndstringbuilder());
                }
            }
            _lists = list;
            printCollection();

            MessageBox.Show("Коллекция успешно создана!", "Внимание!");
        }

        private void printCollection()
        {

            if (_lists == null || _lists.Any(element => element.Count == 0))
            {
                MessageBox.Show("Массив не был создан!", "Ошибка");
                return;
            }
            for (int i = 0; i < _lists.Length; i++)
            {
                for (int j = 0; j < _lists[i].Count; j++)
                {
                    FillOutputLog($"Индекс строки в массиве: {i}, Элемент списка: {j}, Значение: {_lists[i].ElementAt(j)}", richTextBox1, delim);
                }
            }
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
        public int rndint(int form, int to)
        {
            Random rnd = new Random();
            return rnd.Next(form, to);
        }

        private void ListLINQ_Load(object sender, EventArgs e)
        {

        }

        public static void FillOutputLog(string message, RichTextBox textBox, string fillDivider = null)
        {
            if (message == null)
                return;

            textBox.Text += message + "\r" + "\n";
            if (fillDivider != null)
            {
                textBox.Text += fillDivider + "\r" + "\n";
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите значение для поиска!", "Ошибка");
                return;
            }
            if (_lists == null || _lists.Any((element => element.Count == 0)))
            {
                MessageBox.Show("Массив не был создан!", "Ошибка");
                return;
            }

            richTextBox1.Clear();

            FillOutputLog("1) СОХРАНЕНИЕ В ФАЙЛ", richTextBox1);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < _lists.Length; i++)
            {
                for (int j = 0; j < _lists[i].Count; j++)
                {
                    stringBuilder.AppendLine($"Индекс строки в массиве: {i}, Элемент списка: {j}, Значение: {_lists[i].ElementAt(j)}");
                }
            }
            using (StreamWriter writer = new StreamWriter(@"C:\Users\Surface\source\repos\Lab_OOP_\Lab_OOP_\OutputFiles\ListString.txt", false))
            {
                await writer.WriteLineAsync(stringBuilder.ToString());
            }
            FillOutputLog("Сохранение в файл произошло успешно", richTextBox1, delim);

            FillOutputLog("2) ПОИСК СТРОК ПО ЗНАЧЕНИЮ", richTextBox1);
            FillOutputLog($"По значению {textBox1.Text} найдено:", richTextBox1);
            for (int i = 0; i < _lists.Length; i++)
            {
                for (int j = 0; j < _lists[i].Count; j++)
                {
                    if (_lists[i].ElementAt(j).Contains(textBox1.Text))
                    {
                        FillOutputLog($"Индекс строки в массиве: {i}, Элемент списка: {j}, Значение: {_lists[i].ElementAt(j)}", richTextBox1);
                    }
                }
            }
            FillOutputLog(delim, richTextBox1);

            FillOutputLog("3) ПОИСК СТРОК ПО ДЛИНЕ", richTextBox1);
            int length = (int)numericUpDown1.Value;
            int count = 0;
            foreach (var item in _lists)
            {
                count += item.Where(str => str.Length == length).Count();
            }
            FillOutputLog($"По длине {numericUpDown1.Value} найдено: {count} строк", richTextBox1);
            int max = _lists.Max(list => list.Count);
            FillOutputLog($"Максимальная длина коллекции: {max}", richTextBox1);
            int min = _lists.Min(list => list.Count);
            FillOutputLog($"Минимальная длина коллекции: {min}", richTextBox1);
            FillOutputLog(delim, richTextBox1);

            FillOutputLog("4) СОРТИРОВКА В ВОЗРАСТАЮЩЕМ ПОРЯДКЕ", richTextBox1);
            foreach (var item in _lists)
            {
                item.OrderBy(str => str);
            }
            for (int i = 0; i < _lists.Length; i++)
            {
                for (int j = 0; j < _lists[i].Count; j++)
                {
                    FillOutputLog($"Индекс строки в массиве: {i}, Элемент списка: {j}, Значение: {_lists[i].ElementAt(j)}", richTextBox1);
                }
            }
            FillOutputLog(delim, richTextBox1);

            FillOutputLog("5) СОРТИРОВКА В УБЫВАЮЩЕМ ПОРЯДКЕ", richTextBox1);
            foreach (var item in _lists)
            {
                item.OrderByDescending(str => str);
            }
            for (int i = 0; i < _lists.Length; i++)
            {
                for (int j = 0; j < _lists[i].Count; j++)
                {
                    FillOutputLog($"Индекс строки в массиве: {i}, Элемент списка: {j}, Значение: {_lists[i].ElementAt(j)}", richTextBox1);
                }
            }
            FillOutputLog(delim, richTextBox1);
        }
    }
}
