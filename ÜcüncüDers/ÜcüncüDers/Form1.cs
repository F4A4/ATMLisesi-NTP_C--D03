using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ÜcüncüDers
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
        }
            
            
		 private void strıngGoster()
        {
            string sayi = "ELLİÜÇ";
            textBox1.Text = sayi.ToString();
 
        }
        private void charGoster()
        {
            char sayi='*';
            textBox1.Text = sayi.ToString();
        }
        private void ıntGoster()
        {
            int sayi = 30;
            textBox1.Text = sayi.ToString();

        }
        private void floatGoster()
        {
            float sayi = 0.23F;
            textBox1.Text = sayi.ToString();

        }
        private void decımalGoster()
        {
            decimal sayi = 129878987M;
            textBox1.Text = sayi.ToString();

        }
        private void longGoster()
        {
            long sayi = 30L;
            textBox1.Text = sayi.ToString();
        }
        private void doubleGoster()
        {
            double sayi = 0.20;
            textBox1.Text = sayi.ToString();
        }
	}
        
    }
       
 

