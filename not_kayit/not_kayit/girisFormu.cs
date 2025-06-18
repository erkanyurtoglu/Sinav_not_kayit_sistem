using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace not_kayit
{
    public partial class girisFormu : Form
    {
        public girisFormu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciDetay ogrenciDetayFormu = new ogrenciDetay();
            ogrenciDetayFormu.numara = textBox1.Text;
            ogrenciDetayFormu.ShowDialog();

        }
    }
}
