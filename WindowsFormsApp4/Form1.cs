using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void класиЗМасивамиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void одновимірнийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void двовимірнийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void рядкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void успадкуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }

        private void поліморфізмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f=new Form6();
            f.Show();
        }

        private void абстрактніКласиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Show();
        }

        private void структуриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.Show();
        }


        private void рФайлиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.Show();
        }

        private void реалізаціяToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form10 f = new Form10();
            f.Show();
        }
    }
}
