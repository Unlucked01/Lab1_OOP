using Lab2_OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_OOP_.Lab2
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ControlBox = false;
            this.ShowInTaskbar = false;
            this.ShowIcon = false;
            pictureBox1.Image = Image.FromFile("C:\\Users\\Surface\\source\\repos\\Lab_OOP_\\Lab_OOP_\\Lab3\\loading-gif.gif");
        }
    }
}
