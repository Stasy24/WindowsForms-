using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n=Convert.ToInt32(textBox1.Text);
            Vector[] a=new Vector[n*3];
            for (int i = 0; i < 3 * n;i= i+3)
            {
                a[i]=new Vector();
                a[i + 1] = new Dva();
                a[i + 2] = new Tri();

            }
            dataGridView1.Rows.Clear();
            foreach (Vector v in a)
                v.show(dataGridView1);
        }
        class Vector
        {

            public int x1;
            public int x2;
            public string naz;
            public Vector()
            {
                Random ran = new Random();
                int r = ran.Next(1, 2);
                switch (r)
                {
                    case 1: { naz = "Двовимірний"; break; }
                    case 2: { naz = "Трьохвимірний"; break; }
                }

            }
            public Vector(string n)
            {
                naz = n;
            }
            public virtual void show(DataGridView dg)
            {
                dg.Rows.Add("Вид вектора", naz);
                dg.Rows.Add("x1", x1);
                dg.Rows.Add("x2", x2);


            }
            public virtual double S()
            {
                return 0;


            }
        }
        class Dva : Vector
        {

            public Dva()
            {
                Random ran = new Random();

                x1 = ran.Next(1, 10);
                x2 = ran.Next(1, 10);
                naz = "Двовимірний";
            }

            public override double S() {
                double dov;
                dov = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(x2, 2));
                return dov;

            }
            public override void show(DataGridView dg)
            {
                base.show(dg);
                dg.Rows.Add("Довжина", S());
            }
        }
        class Tri : Vector {
            private int x3;
            public Tri() {
                Random ran = new Random();
               x1=ran.Next(1, 10);
                x2=ran.Next(1, 10);
                x3 = ran.Next(1, 10);

                naz = "Тривимірні";


            }


            public override double S() {


            double dov;
            dov = Math.Sqrt(Math.Pow(x1,2)+Math.Pow(x2,2)+Math.Pow(x3,2));
                return dov;
            }
            public override void show(DataGridView dg)
            {
                base.show(dg);
                dg.Rows.Add("x3", x3);
                dg.Rows.Add("Довжина", S());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
    