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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            int n = 100;
            int f = 0;
            int m = 0;
            int[] a;
            dg1.Rows.Clear();
     
            Random ran = new Random();
            try
            {
                n = Convert.ToInt16(textBox1.Text);
                a = new int[n];
                Arrays.NOR(a,dg1,label2, label3);
             

            }
            catch
            {
                MessageBox.Show("Помилка введення");
            }
        }
        class Arrays
        {
            public bool error = false;
            int[] a;
            int length;
            
            
            public Arrays(int size)
            {
                a = new int[size]; length = size;
            }
            public int Length { get { return length; } }
            private static Random ran = new Random();
            public static void NOR(int []a,  DataGridView dg1, Label l2, Label l3 )
            {
                int s = 0;
                int nor = 0; 
                int m=0;


                for (int i = 0; i < a.GetLength(0); i++)
                {
                    a[i] = ran.Next(0, 10);
                    dg1.Rows.Add(a[i].ToString());
                    s += a[i];


                    nor = s / a.GetLength(0);
                }
                    l3.Text = nor.ToString();
                
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    
                    if (a[i] < nor) 
                    m++;
                }
                l2.Text =m.ToString();
            }

            public int this[int i]
            {
                get
                {
                    if (i >= 0 && i < length) return a[i];
                    else { error = true; return 0; }
                }
                set
                {
                    if (i >= 0 && i < length && value >= 0 && value <= 10)
                        a[i] = value;
                    else error = true;
                }
            }
        }
    }
}
