using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp4
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            double max = 0;
            Vector[] a = new Vector[n * 2];
            for (int i = 0; i < 2 * n; i = i + 2)
            {
                a[i] = new Dva(i+1,i+10);
                a[i + 1] = new Tri(i+1,i+10);
                

            }
            dataGridView1.Rows.Clear();
            foreach (Vector v in a)
            {

                v.show(dataGridView1);
                if (max < v.S())
                    max = v.S(); 
                label1.Text = max.ToString(); 
            }
        }
        abstract class Vector {
            public int x1;
            public int x2;
            public string naz;
            public abstract void show(DataGridView dg);
            public abstract double S();

            
            
            
        
        }
        class Dva : Vector
        {
            public Dva(int xn,int xk)
            {
                Random ran = new Random();

                x1 = ran.Next(xn,xk);
                x2 = ran.Next(xn, xk);
                naz = "Двовимірний";
            }

            public override double S()
            {
                double dov;
                dov = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(x2, 2));
                return dov;

            }
            public override void show(DataGridView dg)
            {
                dg.Rows.Add("x1", x1);
                dg.Rows.Add("x2", x2);
                dg.Rows.Add("Довжина", S());
                dg.Rows.Add("Назва", naz);
            }
            


        }
        class Tri : Vector {
            private int x3;
            public Tri(int xn,int xk)
            {
                Random ran = new Random();
                x3 = ran.Next(xn, xk);
                naz = "Тривимірні";


            }


            public override double S()
            {


                double dov;
                dov = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(x2, 2) + Math.Pow(x3, 2));
                return dov;
            }
            public override void show(DataGridView dg)
            {
                dg.Rows.Add("x1", x1);
                dg.Rows.Add("x2", x2);
                dg.Rows.Add("Довжина", S());
                dg.Rows.Add("Назва", naz);
                dg.Rows.Add("x3", x3);
            
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
