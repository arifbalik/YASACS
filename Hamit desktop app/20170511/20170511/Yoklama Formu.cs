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
using System.IO.Ports;

namespace _20170511
{
    public partial class Yoklama_Formu : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=localhost; Initial Catalog=mikro; User Id=sa; password=sa123456;");
        public Yoklama_Formu()
        {
            InitializeComponent();
            getportnames();
        }
            void getportnames()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }
            
       
    }
}
