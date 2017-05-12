using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _20170511
{
    public partial class KAYITFORMU : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=localhost; Initial Catalog=mikro; User Id=sa; password=sa123456;");

        public KAYITFORMU()
        {
            InitializeComponent();
        }
        
        private void btngoster_Click(object sender, EventArgs e)
        {
           
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into ogrenci(o_adi,o_soyadi,o_kartid) values (@adi,@soyadi,@kartid)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@adi", txtadi.Text);
                komut.Parameters.AddWithValue("@soyadi", txtsoyadi.Text);
                komut.Parameters.AddWithValue("@kartid", txtid.Text);
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                MessageBox.Show(" Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                
            }
           

        }

        private void btngöster_Click(object sender, EventArgs e)
        {
            
        }

        private void KAYITFORMU_Load(object sender, EventArgs e)
        {

            
        }
    }

}
