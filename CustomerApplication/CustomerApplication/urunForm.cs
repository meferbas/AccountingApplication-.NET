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
    public partial class urunForm : Form
    {

        List<Urun> urunListesi = new List<Urun>();
        public urunForm()
        {
            InitializeComponent();
  

            string uygulamaDataDizini = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string uygulamaDizin = Path.Combine(uygulamaDataDizini, "MiniProjeDeneme");
            Directory.CreateDirectory(uygulamaDizin);
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




        private void anasayfaBtn_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); 

            Form1 anaSayfa = new Form1();
            anaSayfa.TopLevel = false;
            anaSayfa.FormBorderStyle = FormBorderStyle.None;
            anaSayfa.Dock = DockStyle.Fill;
            panel1.Controls.Add(anaSayfa);

            anaSayfa.Show();
        }


        private void urunlerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Urun seciliUrun = (Urun)urunlerComboBox.SelectedItem;
            urunTextBox.Text = seciliUrun.ToString();
            fiyatTextBox.Text = seciliUrun.Fiyat.ToString();
        }

        private void urunTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fiyatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            string yeniAd = urunTextBox.Text;
            string controlFiyat = fiyatTextBox.Text;
            if (string.IsNullOrEmpty(yeniAd))
            {
                MessageBox.Show("Lütfen ekleyeceğiniz ürüne bir isim giriniz.");
                return;
            }
            if (string.IsNullOrEmpty(controlFiyat))
            {
                MessageBox.Show("Lütfen ekleyeceğiniz ürüne bir fiyat giriniz.");
                return;
            }
            decimal yeniFiyat = decimal.Parse(fiyatTextBox.Text);
          
            // Yeni ürünü oluştur
          
            Urun yeniUrun = new Urun { Ad = yeniAd, Fiyat = yeniFiyat };

            // Ürün listesine ekle
            urunListesi.Add(yeniUrun);

            // Ürünleri JSON formatına dönüştür
            string json = JsonConvert.SerializeObject(urunListesi);

            // JSON verisini dosyaya yaz
            string uygulamaDataDizini = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string uygulamaDizin = Path.Combine(uygulamaDataDizini, "MiniProjeDeneme");
            string dosyaYolu = Path.Combine(uygulamaDizin, "urunler.json");
            File.WriteAllText(dosyaYolu, json);

            // Başarılı bir şekilde eklendi mesajını göster
            MessageBox.Show("Ürün başarıyla eklendi.");
            urunlerComboBox.Items.Clear();

            if (File.Exists(dosyaYolu))
                {
                    string json1 = File.ReadAllText(dosyaYolu);
                    urunListesi = JsonConvert.DeserializeObject<List<Urun>>(json1);

                    urunlerComboBox.Items.AddRange(urunListesi.ToArray());
                    urunlerComboBox.DisplayMember = "Ad";
                }

        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {

            Urun seciliUrun = (Urun)urunlerComboBox.SelectedItem;
          
            string yeniAd = urunTextBox.Text;
            string controlFiyat = fiyatTextBox.Text;
            if (urunlerComboBox.SelectedItem != null)
            {
                if (string.IsNullOrEmpty(yeniAd))
                {
                    MessageBox.Show("Lütfen ekleyeceğiniz ürüne bir isim giriniz.");
                    return;
                }
                if (string.IsNullOrEmpty(controlFiyat))
                {
                    MessageBox.Show("Lütfen ekleyeceğiniz ürüne bir fiyat giriniz.");
                    return;
                }
                decimal yeniFiyat = decimal.Parse(fiyatTextBox.Text);

                seciliUrun.Ad = yeniAd;
                seciliUrun.Fiyat = yeniFiyat;

                // Ürün listesini JSON formatına dönüştür
                string json = JsonConvert.SerializeObject(urunListesi);

                // JSON verisini dosyaya yaz
                string uygulamaDataDizini = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string uygulamaDizin = Path.Combine(uygulamaDataDizini, "MiniProjeDeneme");
                string dosyaYolu = Path.Combine(uygulamaDizin, "urunler.json");
                File.WriteAllText(dosyaYolu, json);

                // Başarılı bir şekilde güncellendi mesajını göster
                MessageBox.Show("Ürün bilgileri güncellendi.");
                urunlerComboBox.Items.Clear();

                if (File.Exists(dosyaYolu))
                {
                    string json1 = File.ReadAllText(dosyaYolu);
                    urunListesi = JsonConvert.DeserializeObject<List<Urun>>(json1);

                    urunlerComboBox.Items.AddRange(urunListesi.ToArray());
                    urunlerComboBox.DisplayMember = "Ad";
                }
                

            }
            else
            {
                MessageBox.Show("Lütfen güncelleyeceğiniz ürünü listeden seçiniz.");
            }

        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (urunlerComboBox.SelectedItem != null)
            {
                // Seçili ürünü al
                Urun seciliUrun = urunlerComboBox.SelectedItem as Urun;

                // Seçili ürünü listeden kaldır
                urunListesi.Remove(seciliUrun);

                // Ürünleri JSON formatına dönüştür
                string json = JsonConvert.SerializeObject(urunListesi);

                // JSON verisini dosyaya yaz
                string uygulamaDataDizini = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string uygulamaDizin = Path.Combine(uygulamaDataDizini, "MiniProjeDeneme");
                string dosyaYolu = Path.Combine(uygulamaDizin, "urunler.json");
                File.WriteAllText(dosyaYolu, json);

                // Seçili ürünü combobox'tan kaldır
                urunlerComboBox.Items.Remove(seciliUrun);

                // Başarılı bir şekilde silindi mesajını göster
                MessageBox.Show("Ürün başarıyla silindi.");
                urunlerComboBox.Items.Clear();

                if (File.Exists(dosyaYolu))
                {
                    string json1 = File.ReadAllText(dosyaYolu);
                    urunListesi = JsonConvert.DeserializeObject<List<Urun>>(json1);

                    urunlerComboBox.Items.AddRange(urunListesi.ToArray());
                    urunlerComboBox.DisplayMember = "Ad";
                }
            }
            else
                MessageBox.Show("Lütfen silmek istediğiniz ürünü listeden seçiniz.");
        }

        private void urunForm_Load(object sender, EventArgs e)
        {

        }
    }
}
