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
    public partial class MusteriEkleSilForm : Form
    {
        private List<Musteri> musteriler = new List<Musteri>();
        List<Urun> urunListesi = new List<Urun>();

        private string dosyaYolu;
        public MusteriEkleSilForm()
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
                    mstList.Items.Add(profil);
                }
            }
            urunlerComboBox.Items.Clear();

           
            string dosyaYolu2 = Path.Combine(uygulamaDizin, "urunler.json");

            if (File.Exists(dosyaYolu2))
            {
                string json = File.ReadAllText(dosyaYolu2);
                urunListesi = JsonConvert.DeserializeObject<List<Urun>>(json);

                urunlerComboBox.Items.AddRange(urunListesi.ToArray());
                urunlerComboBox.DisplayMember = "Ad";
            }

        }

        private async void anaSayfaBtn_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form1 anaSayfa = new Form1();

            anaSayfa.TopLevel = false;
            anaSayfa.FormBorderStyle = FormBorderStyle.None;
            anaSayfa.Dock = DockStyle.Fill;
            panel1.Controls.Add(anaSayfa);
            await Task.Delay(100);
            anaSayfa.Show();
        }

        private void mstSilBtn_Click_1(object sender, EventArgs e)
        {
            if (mstList.SelectedIndex >= 0)
            {
                int selectedIndex = mstList.SelectedIndex;
                mstList.Items.RemoveAt(selectedIndex);
                musteriler.RemoveAt(selectedIndex);
                adTextBox.Text = string.Empty;
                soyadTextBox.Text = string.Empty;
                borcTextBox.Text = string.Empty;

                string json = JsonConvert.SerializeObject(musteriler);
                File.WriteAllText(dosyaYolu, json);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir müşteri seçin.");
            }
        }

        private void mstEklebtn_Click(object sender, EventArgs e)
        {


            string ad = adTextBox.Text;
            string soyad = soyadTextBox.Text;
            string adet = Convert.ToString(adetTextBox.Text);
            string urun = "";
          

            string toplamBorc = borcTextBox.Text;
            DateTime selectedDate = odemeDateTP.Value;
            string sonOdemeTarihi = selectedDate.ToString("dd/MM/yyyy");

            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Lütfen geçerli bir ad girin.");
                return;
            }

            if (string.IsNullOrEmpty(soyad))
            {
                MessageBox.Show("Lütfen geçerli bir soyad girin.");
                return;
            }
            if (urunlerComboBox.SelectedItem != null)
            {
                urun = urunlerComboBox.SelectedItem.ToString() + " " + "(x" + adet + " adet)";
            }
            else
            {
                MessageBox.Show("Lütfen ürünler listesinden alınan ürünü seçiniz.");
                return;
            }
            if (string.IsNullOrEmpty(adet))
            {
                MessageBox.Show("Lütfen üründen kaç adet alındığını ilgili boşluğa yazınız.");
                return;
            }

            if (string.IsNullOrEmpty(toplamBorc))
            {
                MessageBox.Show("Lütfen müşterinin borcunu hesaplayınız.");
                return;
            }
           

            Musteri musteri = new Musteri
            {
                adMusteri = ad,
                soyadMusteri = soyad,
                aldigiUrun = urun,
                borc = toplamBorc,
                odemeTarihi = sonOdemeTarihi
            };

            musteriler.Add(musteri);
            mstList.Items.Add(ad + " " + soyad);
            string json = JsonConvert.SerializeObject(musteriler);
            File.WriteAllText(dosyaYolu, json);

            MessageBox.Show("Müşteri kaydedildi!");
        }
        public class Urun
        {
            public string Ad { get; set; }
            public decimal Fiyat { get; set; }

            public override string ToString()
            {
                return Ad;
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

        private void hesaplaBtn_Click(object sender, EventArgs e)
        {
            string control = adetTextBox.Text;
            if (urunlerComboBox.SelectedItem is Urun seciliUrun && !string.IsNullOrEmpty(control))
            {
                decimal fiyat = seciliUrun.Fiyat;
                int adet = Convert.ToInt32(adetTextBox.Text);

                decimal toplamTutar = fiyat * adet;

                borcTextBox.Text = toplamTutar.ToString() + " TL";
            }
            else
            {
                MessageBox.Show("Satın alınan ürün ve adet kısımlarının boş olmaması gerekmektedir!");
            }
        }

        private void MusteriEkleSilForm_Load(object sender, EventArgs e)
        {

        }
    }
}
