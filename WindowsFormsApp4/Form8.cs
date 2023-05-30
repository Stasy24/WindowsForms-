using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        Ost[] o = new Ost[10];

        int cout = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            o[cout].Naz = textBox1.Text;

            o[cout].Lek = Convert.ToInt16(textBox2.Text);

            o[cout].Lab = Convert.ToInt16(textBox3.Text);

            o[cout].Prak = Convert.ToInt16(textBox4.Text);
            o[cout].Irk = Convert.ToInt16(textBox5.Text);
            o[cout].Vid = textBox6.Text;


            dataGridView1.Rows.Add(o[cout].Naz, o[cout].Lek.ToString(), o[cout].Lab.ToString(), o[cout].Prak.ToString(), o[cout].Irk.ToString(), o[cout].Vid);

            cout++;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }
        struct Ost {
            public string Naz;

            public int Lek;

            public int Lab;

            public int Prak;
            public int Irk;
            public string Vid;


            public Ost(string a, int t, int g, int c, int f ,string j )

            {

                Naz = a;

                Lek = t;

                Lab = g;

                Prak = c;
                Irk= f;
                Vid = j;
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            foreach (Ost oo in o)
            {
                if (oo.Vid == "залік" || oo.Vid == "іспит")
                    dataGridView2.Rows.Add(oo.Naz, oo.Lek.ToString(), oo.Lab.ToString(), oo.Prak.ToString(), oo.Irk.ToString(), oo.Vid);

                dataGridView2.Sort(dataGridView2.Columns["Column12"], ListSortDirection.Ascending);


            }

        }

        
    }
}
