using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            File f = new File();
            string s = textBox1.Text;
            f.st(s, textBox2);
            f.res(textBox3);
        }
        class File
        {
            int[] a;
            int[] b;
            int length;
            public bool f = false;
            int k1 = 0;
            int k = 0;
            public File()
            {
                a = new int[100];
                b = new int[100];
                length = 100;
            }
            void show(TextBox t, int[] aa)
            {
                t.Text = "";
                for (int i = 0; i < length; i++)
                {
                    t.AppendText(aa[i] + "    ");
                }
            }

            public void st(string s, TextBox t)
            {
                int i = 0;
                using (StreamReader sr = new StreamReader(s, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        a[i] = Convert.ToInt16(line);
                        i++;
                    }
                }
                length = i;
                show(t, a);
            }
            public void res(TextBox t)
            {
                int k = 0;
                string b1;
                for (int i = 0; i < length; i++)
                {
                    if (a[i] == 0)
                    {

                        k = i;
                        b1 = "всі числа масиву дорівнюють 0";
                    }
                    else if (a[k + 1] > 0)
                        b1 = "перше ненульове число більше 0";
                    else if (a[k + 1] < 0)
                        b1 = "перше ненульове число менше 0";
                    else
                        b1 = "paka";



                    t.Text = b1;
                    string s = @"C:\результат.txt";
                    using (StreamWriter sw = new StreamWriter(s, false, System.Text.Encoding.Default))
                    {

                        sw.WriteLine(b1);

                    }

                }


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Виберіть файл";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            textBox1.Text = openFileDialog1.FileName;
        }
    }
}