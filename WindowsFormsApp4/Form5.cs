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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nor t1;
            t1 = new Nor();
            t1.Show(label1);
            t1.Showstyle(label2);
            label3.Text = "Периметр : " + t1.P().ToString();
            Triangl f=new Triangl();
            f.Show(label4);
           
            Change r=new Change();
            label4.Text = "сторони з коефіцієнтом  " + r.C1().ToString()+"  ,"  + r.C2().ToString()  + "  ," + r.C3().ToString();
            label5.Text = "периметр з коефіцієнтом  : " + r.P().ToString();
                
        }

        class Triangl
        {
            private double x1;
            private double x2;
            private double x3;
            private double n;
            public Triangl()
            {

                Random rnd = new Random();
                x1 = rnd.Next(1, 10);
                x2 = rnd.Next(1, 10);
                x3 = rnd.Next(1, 10);
                n = rnd.Next(1, 10);
            }

            public double X1
            {
                get { return x1; }
            }
            public double X2
            {
                get { return x2; }
            }
            public double X3
            {
                get { return x3; }
            }
            public double N
            {
                get { return n; }
            }
            public void Show(Label l)
            {
                l.Text = "сторона1 : "+X1.ToString() +"  сторона2 : "+ X2.ToString() +"  сторона3 : "+ X3.ToString()+"  коефіцієнт  : "+N.ToString();
            }
        }
        class Nor : Triangl {
            string style;
            public Nor() { 
            Random random = new Random();   
                int s=random.Next(1, 3);
                switch (s)
                {
                    case 1: { style = "гострокутний"; break; }

                    case 2: { style = "тупокутний"; break; }
                    case 3: { style = "прямокутний"; break; }
                }

            }
            public string Style { 
            get { return style; }

            }
            public double P() { 
            return X1 + X2+X3;

            }
            public void Showstyle(Label l) { 
            l.Text= "вид трикутника :  "+Style;
            }

        }
        class Change : Nor
        {
            public double C1() {
                return X1 * N;

            
            }
            public double C2()
            {
                return X2 * N;


            }
            public double C3()
            {
                return X3 * N;


            }
            public new double P() { 
            return base.P()*N;

            }

        }
    }
}
