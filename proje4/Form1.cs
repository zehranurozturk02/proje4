using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje4
{
    public partial class Form1 : Form
    {
        galeri g;
        public Form1()
        {
            InitializeComponent();
            g = new galeri();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marka = textBox1.Text;
            string model = textBox2.Text;

            araba a = new araba(marka, model);

            g.arabaekle(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] s = g.arabalistele();
            foreach(string x in s)
            {
                listBox1.Items.Add(x);
            }

        }
    }
}
