using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Yapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point konum = new Point();
            konum.X = 150;
            konum.Y = 350;
            pictureBox1.Location = konum;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point yukari = new Point();
            yukari.X = 150;
            yukari.Y = 100;
            pictureBox1.Location = yukari;
        }
    }
}
