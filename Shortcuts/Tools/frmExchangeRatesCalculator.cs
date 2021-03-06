using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.Threading;

namespace Shortcuts
{
    public partial class frmExchangeRatesCalculator : Form
    {
        double euro = 1.75;
        double ytl = 1;
        double dollar = 1.3;
        double sterlin = 2.6;
           
        public frmExchangeRatesCalculator()
        {
            InitializeComponent();
        }

        public void LoadTCMBExchangeRates()
        {

            DataTable dt = new DataTable();
            // DataTable nesnemizi yaratýyoruz
            DataRow dr;
            // DataTable ýn satýrlarýný tanýmlýyoruz.
            dt.Columns.Add(new DataColumn("Adı", typeof(string)));
            dt.Columns.Add(new DataColumn("Kod", typeof(string)));
            dt.Columns.Add(new DataColumn("Döviz Alış", typeof(string)));
            dt.Columns.Add(new DataColumn("Döviz Satış", typeof(string)));
            dt.Columns.Add(new DataColumn("Efektif Alış", typeof(string)));
            dt.Columns.Add(new DataColumn("Efektif Satış", typeof(string)));
            // DataTableýmýza 6 sütün ekliyoruz ve deðiþken tiplerini tanýmlýyoruz.

           // XmlTextReader rdr = new XmlTextReader("http://www.tcmb.gov.tr/kurlar/today.xml");
            //XmlTextReader rdr = new XmlTextReader("G:\\C#.NetWorks\\Avkomix\\Avkomix\\bin\\Debug\\TcmbExchangeRates.xml");
            XmlTextReader rdr = new XmlTextReader("TcmbExchangeRates.xml");
            // XmlTextReader nesnesini yaratýyoruz ve parametre olarak xml dokümanýn urlsini veriyoruz
            // XmlTextReader urlsi belirtilen xml dokümanlarýna hýzlý ve forward-only giriþ imkaný saðlar.

            XmlDocument myxml = new XmlDocument();
            // XmlDocument nesnesini yaratýyoruz.
            myxml.Load(rdr);
            // Load metodu ile xml yüklüyoruz

            XmlNode tarih = myxml.SelectSingleNode("/Tarih_Date/@Tarih");
            XmlNodeList mylist = myxml.SelectNodes("/Tarih_Date/Currency");
            XmlNodeList adi = myxml.SelectNodes("/Tarih_Date/Currency/Isim");
            XmlNodeList kod = myxml.SelectNodes("/Tarih_Date/Currency/@Kod");
            XmlNodeList doviz_alis = myxml.SelectNodes("/Tarih_Date/Currency/ForexBuying");
            XmlNodeList doviz_satis = myxml.SelectNodes("/Tarih_Date/Currency/ForexSelling");
            XmlNodeList efektif_alis = myxml.SelectNodes("/Tarih_Date/Currency/BanknoteBuying");
            XmlNodeList efektif_satis = myxml.SelectNodes("/Tarih_Date/Currency/BanknoteSelling");

            // XmlNodeList cinsinden her bir nodu, SelectSingleNode metoduna nodlarýn xpathini parametre olarak
            // göndererek tanýmlýyoruz.

           

            int x = 19;

            /*  Burada xmlde bahsettiðim - bence-  mantýk hatasýndan dolayý x gibi bir deðiþken tanýmladým.
            bu x =19  DataTable a sadece 19 satýr eklenmesini saðlýyor. çünkü xml dökümanýnda 19. node dan sonra
            güncel kur bilgileri deðil Euro dönüþüm kurlarý var ve bu node dan sonra yapý ilk 18 node ile tutmuyor
            Bence ayrý bir xml dökümanda tutulmasý gerekirdi. 
            */
            for (int i = 0; i < x; i++)
            {
                dr = dt.NewRow();
                dr[0] = adi.Item(i).InnerText.ToString(); // i. adi nodunun içeriði
                // Adý isimli DataColumn un satýrlarýný  /Tarih_Date/Currency/Isim node larý ile dolduruyoruz.
                dr[1] = kod.Item(i).InnerText.ToString();
                // Kod satýrlarý
                dr[2] = doviz_alis.Item(i).InnerText.ToString();
                // Döviz Alýþ
                dr[3] = doviz_satis.Item(i).InnerText.ToString();
                // Döviz  Satýþ
                dr[4] = efektif_alis.Item(i).InnerText.ToString();
                // Efektif Alýþ
                dr[5] = efektif_satis.Item(i).InnerText.ToString();
                // Efektif Satýþ.
                dt.Rows.Add(dr);
            }
        }

        private double GetMoney(string money)
        {
            //return Convert.ToDouble(money.Replace(".", ","));
            return Convert.ToDouble(money);
        }

        private void LoadExchangeRatesFromTCMB()
        {
            XmlTextReader rdr = new XmlTextReader("http://www.tcmb.gov.tr/kurlar/today.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(rdr);

            foreach (DataRow dr in ds.Tables[1].Rows)
            {
                string currency = "";
                ListViewItem lvi;
                switch (dr["CurrencyName"].ToString())
                {
                    case "US DOLLAR": 
                        dollar = GetMoney(dr["ForexSelling"].ToString()); 
                        currency = "DOLAR";
                        lvi = new ListViewItem(currency);
                        lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["ForexBuying"]) + " TL");
                        lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["ForexSelling"]) + " TL");
                        lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["BanknoteBuying"]) + " TL");
                        lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["BanknoteSelling"]) + " TL");
                        lvExchangeRates.Items.Add(lvi);
                        break;
                    case "EURO":
                        euro = GetMoney(dr["ForexSelling"].ToString());
                        currency = "EURO";
                        lvi = new ListViewItem(currency);
                        lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["ForexBuying"]) + " TL");
                        lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["ForexSelling"]) + " TL");
                        lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["BanknoteBuying"]) + " TL");
                        lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["BanknoteSelling"]) + " TL");
                        lvExchangeRates.Items.Add(lvi);
                        break;
                    case "POUND STERLING":
                        sterlin= GetMoney(dr["ForexSelling"].ToString());
                        currency = "STERLIN";
                        lvi = new ListViewItem(currency);
                        lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["ForexBuying"]) + " TL");
                        lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["ForexSelling"]) + " TL");
                        lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["BanknoteBuying"]) + " TL");
                        lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["BanknoteSelling"]) + " TL");
                        lvExchangeRates.Items.Add(lvi);
                        break;
                    //default: 
                    //    currency = "YTL";
                    //    lvi = new ListViewItem(currency);
                    //    lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["ForexBuying"]) + " YTL");
                    //    lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["ForexSelling"]) + " YTL");
                    //    lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["BanknoteBuying"]) + " YTL");
                    //    lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["BanknoteSelling"]) + " YTL");
                    //    lvExchangeRates.Items.Add(lvi);
                        
                    //    break;
                }

                //ListViewItem lvi = new ListViewItem(currency);
                //lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["ForexBuying"]) + " YTL");
                //lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["ForexSelling"]) + " YTL");
                //lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["BanknoteBuying"]) + " YTL");
                //lvi.SubItems.Add(string.Format("{0:#,###.####}", dr["Bankno      teSelling"]) + " YTL");
                //lvExchangeRates.Items.Add(lvi);
            }
        }

        private void frmExchangeRates_Load(object sender, EventArgs e)
        {
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            lvExchangeRates.Columns.Add("Döviz", 80 , HorizontalAlignment.Left);
            lvExchangeRates.Columns.Add("Alış", 80, HorizontalAlignment.Center);
            lvExchangeRates.Columns.Add("Satış", 80, HorizontalAlignment.Center);
            lvExchangeRates.Columns.Add("Serbest Piyasa",90, HorizontalAlignment.Center);
            lvExchangeRates.Columns.Add("Efektif", 80, HorizontalAlignment.Center);

            //dgvTcmbExchangeRates.ca = DateTime.Today.ToString() + " tarihli merkez bankasý kur bilgileri";

            LoadExchangeRatesFromTCMB();
           
        }

        private void ApplyCalculations()
        {
            if (txtValueToConvert.Text == "")
            {
                txtVAT1.Text = "";
                txtVATAddedValue2.Text = "";
                txtConvertedValue.Text = "";
                return;
            }

            double valueToConvert = Convert.ToDouble(txtValueToConvert.Text);
            txtVAT1.Text = string.Format("{0:N}", valueToConvert * 0.18);
            txtVATAddedValue1.Text = string.Format("{0:N}", valueToConvert * 1.18);

            double ConvertedValue = 1;
            double coefficient = 1;

            if (rbYTL1.Checked && rbEuro2.Checked) coefficient = (ytl / euro);
            if (rbEuro1.Checked && rbYTL2.Checked) coefficient = (euro / ytl);

            if (rbYTL1.Checked && rbSterlin2.Checked) coefficient = (ytl / sterlin);
            if (rbSterlin1.Checked && rbYTL2.Checked) coefficient = (sterlin / ytl);

            if (rbYTL1.Checked && rbDollar2.Checked) coefficient = (ytl / dollar);
            if (rbDollar1.Checked && rbYTL2.Checked) coefficient = (dollar / ytl);

            if (rbEuro1.Checked && rbDollar2.Checked) coefficient = (euro / dollar);
            if (rbDollar1.Checked && rbEuro2.Checked) coefficient = (dollar / euro);

            if (rbEuro1.Checked && rbSterlin2.Checked) coefficient = (euro / sterlin);
            if (rbSterlin1.Checked && rbEuro2.Checked) coefficient = (sterlin / euro);

            if (rbDollar1.Checked && rbSterlin2.Checked) coefficient = (dollar / sterlin);
            if (rbSterlin1.Checked && rbDollar2.Checked) coefficient = (sterlin /dollar);

            ConvertedValue = coefficient * valueToConvert;

            txtConvertedValue.Text = string.Format("{0:N}",ConvertedValue );
            txtVAT2.Text = string.Format("{0:N}", ConvertedValue * 0.18);
            txtVATAddedValue2.Text = string.Format("{0:N}", ConvertedValue * 1.18);
            
        }

        private void txtValueToConvert_TextChanged(object sender, EventArgs e)
        {
            ApplyCalculations();
        }

        private void rbYTL1_CheckedChanged(object sender, EventArgs e)
        {
            lblCurrency1.Text = "TL";
            ApplyCalculations();
        }

        private void rbEURO1_CheckedChanged(object sender, EventArgs e)
        {
            lblCurrency1.Text = "Euro";
            ApplyCalculations();
        }

        private void rbDollar1_CheckedChanged(object sender, EventArgs e)
        {
            lblCurrency1.Text = "Dolar";
            ApplyCalculations();
        }

        private void rbSterlin1_CheckedChanged(object sender, EventArgs e)
        {
            lblCurrency1.Text = "Sterlin";
            ApplyCalculations();
        }

        private void rbYTL2_CheckedChanged(object sender, EventArgs e)
        {
            lblCurrency2.Text = "TL";
            ApplyCalculations();
        }

        private void rbEuro2_CheckedChanged(object sender, EventArgs e)
        {
            lblCurrency2.Text = "Euro";
            ApplyCalculations();
        }

        private void rbDollar2_CheckedChanged(object sender, EventArgs e)
        {
            lblCurrency2.Text = "Dolar";
            ApplyCalculations();
        }

        private void rbSterlin2_CheckedChanged(object sender, EventArgs e)
        {
            lblCurrency2.Text = "Sterlin";
            ApplyCalculations();
        }

    }
}