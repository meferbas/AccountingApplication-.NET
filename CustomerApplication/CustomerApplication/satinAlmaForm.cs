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
    public partial class satinAlmaForm : Form
    {
        List<Urun> urunListesi = new List<Urun>();

        public satinAlmaForm(Musteri musteri)
        {
            InitializeComponent();
            adLabel.Text = musteri.adMusteri;
            soyadLabel.Text = musteri.soyadMusteri;
            urunLabel.Text = musteri.aldigiUrun;
            borcLabel.Text = musteri.borc;
            odemeLabel.Text = musteri.odemeTarihi;  


            string uygulamaDataDizini = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string uygulamaDizin = Path.Combine(uygulamaDataDizini, "MiniProjeDeneme");
            string dosyaYolu = Path.Combine(uygulamaDizin, "urunler.json");

            if (File.Exists(dosyaYolu))
            {
                string json = File.ReadAllText(dosyaYolu);
                urunListesi = JsonConvert.DeserializeObject<List<Urun>>(json);

                urunlerComboBox.Items.AddRange(urunListesi.ToArray());
                urunlerComboBox.DisplayMember = "Ad";
            }
         
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

        public class yeniMusteri
        {
            public string adMusteri { get; set; }
            public string soyadMusteri { get; set; }
            public string aldigiUrun { get; set; }
            public string borc { get; set; }
            public string odemeTarihi { get; set; }
        }

        private void siparisBtn_Click(object sender, EventArgs e)
        {
            if (urunlerComboBox.SelectedItem is Urun seciliUrun)
            {
                if (adLabel.Text == "" || soyadLabel.Text == "" || urunLabel.Text == "")
                {
                    MessageBox.Show("Müşteri bilgileri eksik!");
                    return;
                }
                Musteri musteri = new Musteri()
                {
                    adMusteri = adLabel.Text,
                    soyadMusteri = soyadLabel.Text,
                    aldigiUrun = urunLabel.Text,
                    odemeTarihi = odemeLabel.Text,
                    borc = borcLabel.Text
                };
                string control= adetTextBox.Text;
                if (string.IsNullOrEmpty(control))
                {
                    MessageBox.Show("Üründen kaç adet alındığını giriniz.");
                    return;
                }
                decimal fiyat = seciliUrun.Fiyat;
                int adet = Convert.ToInt32(adetTextBox.Text);

                decimal toplamTutar = fiyat * adet;
                string borcString = musteri.borc.Replace(" TL", "");

                decimal eskiBorc = decimal.Parse(borcString);
                decimal yeniBorc = eskiBorc + toplamTutar;

                string yeniBorcString = yeniBorc.ToString();

                string guncellenmisBorc = $"{yeniBorcString} TL";

                musteri.borc = guncellenmisBorc;

                string mesaj = $"Satın alım gerçekleştirildiğinde müşterinin yeni borcu: {yeniBorcString} TL olacak.\n\nDevam etmek istiyor musunuz?";
                DialogResult result = MessageBox.Show(mesaj, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string uygulamaDataDizini = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    string uygulamaDizin = Path.Combine(uygulamaDataDizini, "MiniProjeDeneme");
                    string musteriDosyaYolu = Path.Combine(uygulamaDizin, "musteriler.json");
                    List<Musteri> musteriListesi = JsonConvert.DeserializeObject<List<Musteri>>(File.ReadAllText(musteriDosyaYolu));

                    Musteri guncellenenMusteri = musteriListesi.FirstOrDefault(m => m.adMusteri == musteri.adMusteri && m.soyadMusteri == musteri.soyadMusteri);
                    if (guncellenenMusteri != null)
                    {
                        guncellenenMusteri.borc = musteri.borc;
                    }
                    string guncelMusterilerJson = JsonConvert.SerializeObject(musteriListesi, Formatting.Indented);
                    File.WriteAllText(musteriDosyaYolu, guncelMusterilerJson);

                    MessageBox.Show("Satın alım gerçekleştirildi.");
                }
            }
            else {
                MessageBox.Show("Lütfen ürünler listesinden bir ürün seçin!");
               
            }
        }
    


        private void borcBtn_Click(object sender, EventArgs e)
        {
            if (urunlerComboBox.SelectedItem is Urun seciliUrun)
            {
                decimal fiyat = seciliUrun.Fiyat;
                string control = adetTextBox.Text;
                if (string.IsNullOrEmpty(control))
                {
                    MessageBox.Show("Üründen kaç adet alındığını giriniz.");
                    return;
                }
                int adet = Convert.ToInt32(adetTextBox.Text);

                decimal toplamTutar = fiyat * adet;
                tutarLabel.Text = toplamTutar.ToString()+" TL"; 
            }
            else
                MessageBox.Show("Lütfen ürünler listesinden bir ürün seçin!");

        }
    }


    }

