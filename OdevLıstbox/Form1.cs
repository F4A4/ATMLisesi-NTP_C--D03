using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OdevLıstbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedIndex.ToString(), "Sıralama");
            if (listBox1.SelectedIndex == 0)
            {

                string sayi7 = "ELLİÜÇ";
                textBox1.Text = sayi7.ToString();
            }


            if (listBox1.SelectedIndex == 1)
            {
                char sayi6 = '*';
                textBox1.Text = sayi6.ToString();
            }

            if (listBox1.SelectedIndex == 2)
            {
                int sayi = 30;
                textBox1.Text = sayi.ToString();

            }

            if (listBox1.SelectedIndex == 3)
            {
                float sayi3 = 0.23F;
                textBox1.Text = sayi3.ToString();

            }

            if (listBox1.SelectedIndex == 4)
            {
                decimal sayi4 = 129878987M;
                textBox1.Text = sayi4.ToString();

            }

            if (listBox1.SelectedIndex == 5)
            {
                long sayi1 = 30L;
                textBox1.Text = sayi1.ToString();
            }

            if (listBox1.SelectedIndex == 6)
            {
                double sayi2 = 0.20;
                textBox1.Text = sayi2.ToString();
            }

            if (listBox1.SelectedIndex == 7)
            {
                bool sayi5 = false;
                textBox1.Text = sayi5.ToString();
            }
        }

	}
        
    }
       
 

