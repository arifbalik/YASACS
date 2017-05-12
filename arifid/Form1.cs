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

namespace arifid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=BLACKBIRD;Initial Catalog=rfid_database;Integrated Security=True");

        private void verilerigoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from ogrenci_veri", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ogrenci_id"].ToString();
                ekle.SubItems.Add(oku["ogrenci_kart_no"].ToString());
                ekle.SubItems.Add(oku["ogrenci_numara"].ToString());
                ekle.SubItems.Add(oku["ogrenci_ad"].ToString());
                ekle.SubItems.Add(oku["ogrenci_soyad"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verilerigoster();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
