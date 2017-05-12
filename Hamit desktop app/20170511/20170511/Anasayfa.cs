using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20170511
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnkayıt_Click(object sender, EventArgs e)
        {
            Yoklama_Formu yeni = new Yoklama_Formu();
            yeni.Show();
        }

        private void btnyoklama_Click(object sender, EventArgs e)
        {
            KAYITFORMU yeni = new KAYITFORMU();
            yeni.Show();
        }
    }
}
