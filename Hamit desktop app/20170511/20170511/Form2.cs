using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace _20170511
{
    public partial class Form2 : Form
    {
        SerialPort rfid = new SerialPort(,9600);
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rfid.Open();
            rfid.DataReceived += Rfid_DataReceived;

        }

        private void Rfid_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            MessageBox.Show(rfid.ReadLine());
           

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            rfid.Close();
        }
    }
}
