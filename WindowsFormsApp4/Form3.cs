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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0, m = 0, f = 0;
            int[,] a;
            Random ran = new Random();
            try
            {
                n = Convert.ToInt16(textBox1.Text);
                m = Convert.ToInt16(textBox2.Text);
                a = new int[n, m];
                Arrays2.CreateArr(a);
                Arrays2.PrintAr1(a, dg, label3);
            }
            catch
            {
                MessageBox.Show("Погано");
            }
        }
        class Arrays2
        {
            public bool error = false;
            int[,] a;
            int length1;
            int length2;
            public Arrays2(int size1, int size2)
            { a = new int[size1, size2]; length1 = size1; length2 = size2; }
            public int Length1
            { get { return length1; } }
            public int Length2
            { get { return length2; } }
            private static Random ran = new Random();
            public static void CreateArr(int[,] a)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)

                        a[i, j] = ran.Next(-10, 10);

            }
          
          
            
            public static void PrintAr1(int[,] a, DataGridView dg, Label l)
            {
                int f = 0;
                int g = 1;
                DataGridViewTextBoxColumn dgvAge;
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    dgvAge = new DataGridViewTextBoxColumn();
                    dgvAge.Width = 35;
                    dg.Columns.Add(dgvAge);
                }
                dg.Rows.Clear();
                dg.RowCount = a.GetLength(0);
                dg.ColumnCount = a.GetLength(1);
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        dg.Rows[i].Cells[j].Value = a[i, j].ToString();
                        if (i < j)

                        
                        {
                            dg.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                            g *= a[i, j];
                        }

                          
                          
                        
                       

                        l.Text = Convert.ToString(g);
                    }


            }
            public int this[int i, int j]
            {
                get
                {
                    if ((i >= 0 && i < length1) && (j >= 0 && j <= length2))
                        return a[i, j];
                    else
                    {
                        error = true;
                        return 0;
                    }
                }
                set
                {
                    if (i >= 0 && i < length1 && j >= 0 && j <= length2 && value >= -10 && value <= 10)
                        a[i, j] = value;
                    else error = true;
                }
            }
        }
    }
}