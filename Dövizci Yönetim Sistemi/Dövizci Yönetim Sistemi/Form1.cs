using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Dövizci_Yönetim_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void DovizGoster()
        {
            try
            {
                XmlDocument xmlVerisi = new XmlDocument();
                xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
                //alışlar
                decimal dolarA = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexBuying", "USD")).InnerText.Replace('.', ','));
                decimal euroA = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexBuying", "EUR")).InnerText.Replace('.', ','));
                decimal sterlinA = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexBuying", "GBP")).InnerText.Replace('.', ','));
                decimal suudiarabistanriyalA = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexBuying", "SAR")).InnerText.Replace('.', ','));
                decimal japonyeniA = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexBuying", "JPY")).InnerText.Replace('.', ','));
                decimal bulgarlevasiA = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexBuying", "BGN")).InnerText.Replace('.', ','));
                decimal cinyeniA = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexBuying", "CNY")).InnerText.Replace('.', ','));
                decimal iranriyaliA = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexBuying", "IRR")).InnerText.Replace('.', ','));

                lblDolarA.Text = dolarA.ToString();
                lblEuroA.Text = euroA.ToString();
                lblSterlinA.Text = sterlinA.ToString();
                lblsbrA.Text = suudiarabistanriyalA.ToString();
                lbljaponyeniA.Text = japonyeniA.ToString();
                lblbulgarlevasiA.Text = bulgarlevasiA.ToString();
                lblcinyeniA.Text = cinyeniA.ToString();
                lbliranriyaliA.Text = iranriyaliA.ToString();



                //satışlar
                decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
                decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
                decimal sterlin = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace('.', ','));
                decimal suudiarabistanriyal = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "SAR")).InnerText.Replace('.', ','));
                decimal japonyeni = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "JPY")).InnerText.Replace('.', ','));
                decimal bulgarlevasi = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "BGN")).InnerText.Replace('.', ','));
                decimal cinyeni = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "CNY")).InnerText.Replace('.', ','));
                decimal iranriyali = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "IRR")).InnerText.Replace('.', ','));

                lblDolar.Text = dolar.ToString();
                lblEuro.Text = euro.ToString();
                lblSterlin.Text = sterlin.ToString();
                lblsbr.Text = suudiarabistanriyal.ToString();
                lbljaponyeni.Text = japonyeni.ToString();
                lblbulgarlevasi.Text = bulgarlevasi.ToString();
                lblcinyeni.Text = cinyeni.ToString();
                lbliranriyali.Text = iranriyali.ToString();
            }
            catch (XmlException xml)
            {
                timer1.Stop();
                MessageBox.Show(xml.ToString());
            }

        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            timer2.Enabled = true;
            label30.Text = " DESİGNED BY ONUR ACARSOY ";
        }

        private void LblEuro_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
            DovizGoster();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label30.Text = label30.Text.Substring(1) + label30.Text.Substring(0, 1);
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }
    }
}
