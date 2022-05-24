using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGSSProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            indirimler indirim1 = new indirimler();
            indirim1.senaryolar(Convert.ToInt16(TxtFatura.Text));
            if (ChcTelefon.Checked!=true)
            {
                if (DtpTarih.Checked)
                {
                    DateTime BugunTarihi = DateTime.Now;
                    DateTime MusteriTarihi = DtpTarih.Value;
                    TimeSpan ts = BugunTarihi - MusteriTarihi;
                    if (ts.Days >= 730)
                    {
                        TxtTutar.Text = ((indirim1.bes) - (indirim1.sabitbesdolar)).ToString();
                    }
                }
                if (ChcUyelik.Checked)
                {
                    TxtTutar.Text = ((indirim1.on) - (indirim1.sabitbesdolar)).ToString();
                }
                if (CmbKart.Text.ToString() == "GÜMÜŞ")
                {
                    TxtTutar.Text = ((indirim1.yirmi) - (indirim1.sabitbesdolar)).ToString();
                }
                if (CmbKart.Text.ToString() == "ALTIN")
                {
                    TxtTutar.Text = ((indirim1.otuz) - (indirim1.sabitbesdolar)).ToString();
                }
            }
            else
            {
                TxtTutar.Text = ((Convert.ToInt16(TxtFatura.Text)) - (indirim1.sabitbesdolar)).ToString();
            }
        }
    }
}
