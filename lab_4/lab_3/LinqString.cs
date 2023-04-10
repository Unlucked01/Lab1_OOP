using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    public partial class LinqString : Form
    {
        public LinqString(MainForm form1)
        {
            InitializeComponent();

        foreach (Human human in myStack.humanStack())
            {
                dataGridView1.Rows.Add(human.Name, human.SecondName, human.Age, 
                    human.Country, human.Height, human.Weight, human.NumberOfChildren);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
