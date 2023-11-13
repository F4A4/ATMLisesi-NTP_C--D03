using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DegiskenlerTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a;
            a = 30;

            int b, c;
            b = 30;
            c = 30;

            int d, f = 40;
            d = 50;

            string sayi = "20";
            int sayi2 = Int32.Parse(sayi); //bu sekilde tipler arası dönüşüm yapılabilir
            int sayi3 = Convert.ToInt32(sayi); //bu sekilde de tipler arası dönüşüm yapılabilir
            //3. yöntem casting daha sonra karşımıza çıkacak
            int sonuc = sayi2 * 2;
            MessageBox.Show(sonuc.ToString(), "Sonuç");
        }
    }
}
