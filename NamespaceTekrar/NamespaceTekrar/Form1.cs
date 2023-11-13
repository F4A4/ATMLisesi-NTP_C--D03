using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MatematikselIslemler;

namespace NamespaceTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Islem.Topla();
            GrafikselIslemler.Islem.Topla();
            MessageBox.Show("Test");
        }
    }
}


namespace MatematikselIslemler
{
    /// <summary>
    /// classın üzerine yazılan mesaj
    /// </summary>
    public static class Islem
    {
        /// <summary>
        /// metodun üzerine yazılan açıklama
        /// </summary>
        public static void Topla()
        {
 
        }
    }
}


namespace GrafikselIslemler
{
    /// <summary>
    /// classın üzerine yazılan mesaj
    /// </summary>
    public static class Islem
    {
        /// <summary>
        /// metodun üzerine yazılan açıklama
        /// </summary>
        public static void Topla()
        {
 
        }
    }
}
