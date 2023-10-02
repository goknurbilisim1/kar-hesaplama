using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kar_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnKarHesapla_Click(object sender, EventArgs e)
        {
            int alisFiyati, satisFiyati, toplamKar;

            alisFiyati = Convert.ToInt32(txtAlisFiyati.Text);
            satisFiyati = Convert.ToInt32(txtSatisFiyati.Text);

            toplamKar = satisFiyati - alisFiyati;

            lblToplamKar.Text = "Toplam Kar: " + toplamKar;




        }
    }
}
