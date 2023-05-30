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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string s1;
            string s2;
            Tstring st;
            st = new Tstring();
            try
            {

                s1 = Convert.ToString(textBox1.Text);
                s2 = Convert.ToString(textBox2.Text);
                label3.Text = Convert.ToString(st.ST);
                Tstring.Str(Convert.ToString(st.ST), Convert.ToString(st.SB), label2);
                Tstring.Str(s1, s2, label6);
            }
            catch
            {
                MessageBox.Show("Помилка введення");
            }
        }
        class Tstring
        {
            StringBuilder s1;
            StringBuilder s2;
            public Tstring()
            {
                s1 = new StringBuilder();
                s1 = s1.Append("qwrhkiudsfdzbvnqwrqwrqw");
                s2 = new StringBuilder();
                s2 = s2.Append("qghsaqqwasdw");
            }
            public StringBuilder ST
            {
                get
                {
                    return s1;
                }
            }
            public StringBuilder SB
            {
                get
                {
                    return s2;
                }
            }

            public static void Str(string s1, string s2, Label l)
            {
                string[] charsToRemove = new[] { s2 }; 
                foreach (var c in charsToRemove)
                {

                    s1 = s1.Replace(c, " "); 

                }
                l.Text = s1;

            }
        }
    }
}


