using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace not_kayit
{
    public partial class ogrenciDetay : Form
    {
        public ogrenciDetay()
        {
            InitializeComponent();
        }

        public string numara; 

       SqlConnection baglanti = new SqlConnection(@"Data Source=EXCALIBUR\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True");

        private void ogrenciDetay_Load(object sender, EventArgs e)
        {
            label9.Text = numara;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLDERS Where OGRNUMARA = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                label8.Text = dr[2].ToString() + " " + dr[3].ToString();
                label10.Text = dr[4].ToString();
                label11.Text = dr[5].ToString();
                label12.Text = dr[6].ToString();
                label13.Text = dr[7].ToString();
                label14.Text = dr[8].ToString();    
            }
            baglanti.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
