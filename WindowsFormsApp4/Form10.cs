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
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public class one : IComparable
        {
            public string name;
            public string avtor;
            public int amount;
            public one(string m, string a,  int a1)
            {
               name = m;
               avtor = a;
                amount = a1;
            }
            public one()
            {
                Random r = new Random();
                name = "Хаос";
                avtor = "Лисенко";
                
                amount = r.Next(150, 300);
            }
            public int CompareTo(object obj)
            {
                one b;
                b = (one)obj;
                return amount.CompareTo(b.amount);
            }

        }
        class SortByAmount : IComparer<one>
        {
            public int Compare(one x, one y)
            {
                one t1 = x;
                one t2 = y;
                if (t1.amount > t2.amount) return 1;
                if (t1.amount < t2.amount) return -1;
                return 0;
            }
        }
        class Baza_Kormit
        {

            int cout = 0;

            public XmlSerializer ser = new XmlSerializer(typeof(List<one>));
            public List<one> vistavka = new List<one>();


            public void add(string t1, string t2, int a2, DataGridView dg)
            {
                vistavka.Add(new one(t1, t2, a2));
                dg.Rows.Add(vistavka[vistavka.Count - 1].name, vistavka[vistavka.Count - 1].avtor,  vistavka[vistavka.Count - 1].amount.ToString());
                cout++;
            }

            public void show(DataGridView dg)
            {
                dg.Rows.Clear();
                for (int i = 0; i < vistavka.Count; i++)
                {
                    dg.Rows.Add(vistavka[i].name, vistavka[i].avtor, vistavka[i].amount.ToString());

                }
            }


            public void del(int i)
            {
                vistavka.RemoveAt(i);
            }

            public void zap(string f)
            {
                FileStream file = new FileStream(f, FileMode.Create, FileAccess.Write, FileShare.None);
                ser.Serialize(file, vistavka);
                file.Close();
            }
            public void ct(string f)
            {
                FileStream file;
                file = new FileStream(f, FileMode.Open, FileAccess.Read, FileShare.None);
                vistavka = (List<one>)ser.Deserialize(file);
                file.Close();
            }
            public void sort()
            {
                SortByAmount sa = new SortByAmount();
                vistavka.Sort(sa);
            }

            public void sort1(int z, DataGridView dg)
            {
                vistavka.Sort();
                dg.Rows.Clear();
                for (int i = 0; i < vistavka.Count; i++)
                {
                    if (z  < vistavka[i].amount)
                        dg.Rows.Add(vistavka[i].name, vistavka[i].avtor, vistavka[i].amount.ToString());

                }

            }

        }
        Baza_Kormit pl = new Baza_Kormit();
        private void button4_Click(object sender, EventArgs e)
        {
            string path = @"C:\1111.txt";
            pl.ct(path);
            pl.show(dataGridView2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = @"C:\1111.txt";
            pl.zap(path);
            MessageBox.Show(" іди спать");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                int i = dataGridView2.CurrentRow.Index;

                pl.del(i);
                pl.show(dataGridView2);
            }
            catch
            {
                MessageBox.Show("Рядки закінчились.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pl.sort();
            pl.show(dataGridView3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int z = 3;
                pl.sort1(z, dataGridView1);
            }
            catch
            {
                MessageBox.Show("Pomylka");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string avtor = textBox2.Text;
            int amount = Convert.ToInt32(textBox3.Text);
           
            pl.add(name, avtor,  amount, dataGridView2);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
