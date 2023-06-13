using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace CustomerApplication
{
    public partial class MusterilerForm : Form
    {
        private List<Musteri> musteriler = new List<Musteri>();
        private string dosyaYolu;
        public MusterilerForm()
        {
            InitializeComponent();
            string uygulamaDataDizini = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string uygulamaDizin = Path.Combine(uygulamaDataDizini, "MiniProjeDeneme");

            Directory.CreateDirectory(uygulamaDizin);

            dosyaYolu = Path.Combine(uygulamaDizin, "musteriler.json");
            if (File.Exists(dosyaYolu))
            {
                string json = File.ReadAllText(dosyaYolu);
                musteriler = JsonConvert.DeserializeObject<List<Musteri>>(json);
                foreach (Musteri musteri in musteriler)
                {
                    string profil = musteri.adMusteri + " " + musteri.soyadMusteri;
                    //mstList.Items.Add(profil);
                    mstList2.Items.Add(profil);
                }
            }
        }

        private void mstList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mstList2.SelectedItem != null)
            {
                string selectedProfile = mstList2.SelectedItem.ToString();

                string[] profileInfo = selectedProfile.Split(' ');


                string ad = string.Join(" ", profileInfo.Take(profileInfo.Length - 1).ToArray());
                string soyad = profileInfo.Last().Trim();

                mstAdLabel.Text = ad;
                mstSoyadLabel.Text = soyad;

                Musteri seciliMusteri = musteriler[mstList2.SelectedIndex];
             
                mstUrunLabel.Text = seciliMusteri.aldigiUrun;
                mstBorcLabel.Text = seciliMusteri.borc;
                mstOdemeLabel.Text = seciliMusteri.odemeTarihi;
            }
        }

        private void anaSayfaBtn_Click(object sender, EventArgs e)
        {
          
            panel1.Controls.Clear(); 
            Form1 anaSayfa = new Form1();

            anaSayfa.TopLevel = false;
            anaSayfa.FormBorderStyle = FormBorderStyle.None;
            anaSayfa.Dock = DockStyle.Fill;
            panel1.Controls.Add(anaSayfa);

            anaSayfa.Show();

        }

        private void odemeBtn_Click(object sender, EventArgs e)
        {

            if (mstList2.SelectedIndex >= 0)
            {
                Musteri seciliMusteri = musteriler[mstList2.SelectedIndex];

                // Ödeme al penceresini oluştur
                OdemeForm paymentForm = new OdemeForm(seciliMusteri);
                DialogResult result = paymentForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string borcString = seciliMusteri.borc.Replace(",", ".");
                    string borcAna = borcString.Split('.')[0];
                    string borcKurus = borcString.Substring(borcString.IndexOf('.') + 1);
                    string kurusString = borcKurus.Substring(0, borcKurus.Length - 3);

                    decimal borc = decimal.Parse(borcAna);
                    decimal kurus = decimal.Parse(kurusString);

                    decimal odemeMiktari = paymentForm.OdemeMiktari;
                    decimal odenenKurus = paymentForm.odenenKurus;

                    decimal kalanBorc = borc - odemeMiktari;
                    decimal kalanKurus = kurus - odenenKurus;

                    string yeniBorcString = $"{kalanBorc.ToString()},{kalanKurus.ToString()} TL";
                    seciliMusteri.borc = yeniBorcString;

                    seciliMusteri.odemeTarihi = DateTime.Now.ToString("dd.MM.yyyy");

                    string json = JsonConvert.SerializeObject(musteriler);
                    File.WriteAllText(dosyaYolu, json);

                    MessageBox.Show($"Borç ödendi. Kalan borç: {yeniBorcString}");
                }
            }
            else
            {
                MessageBox.Show("Lütfen ödeme alacağınız bir müşteri seçin!");
                return;
            }

        }

      private void satinAlimBtn_Click(object sender, EventArgs e)
      {
          if (mstList2.SelectedIndex >= 0)
          {
              Musteri seciliMusteri = musteriler[mstList2.SelectedIndex];

              satinAlmaForm urunSecimForm = new satinAlmaForm(seciliMusteri); // SeciliMusteri özelliğine değer atayın
              urunSecimForm.ShowDialog();

              string uygulamaDataDizini = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
              string uygulamaDizin = Path.Combine(uygulamaDataDizini, "MiniProjeDeneme");
              Directory.CreateDirectory(uygulamaDizin);

             dosyaYolu = Path.Combine(uygulamaDizin, "musteriler.json");
             if (File.Exists(dosyaYolu))
             {
                 string json = File.ReadAllText(dosyaYolu);
                 musteriler = JsonConvert.DeserializeObject<List<Musteri>>(json);
                
             }

                
          } 
          else
          {
              MessageBox.Show("Lütfen satın alım gerçekleştireceğiniz bir müşteri seçin!");
          }
      }

    }
    public class Musteri
    {
        public string adMusteri { get; set; }
        public string soyadMusteri { get; set; }
        public string aldigiUrun { get; set; }
        public string borc { get; set; }
        public string odemeTarihi { get; set; }
    }
}
