using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerApplication
{
    public partial class OdemeForm : Form
    {
        public decimal OdemeMiktari { get; private set; }
        public decimal odenenKurus { get; private set; }
        public OdemeForm(Musteri musteri)
        {
            InitializeComponent();
            adLabel.Text = musteri.adMusteri;
            soyadLabel.Text = musteri.soyadMusteri;
            borcLabel.Text = musteri.borc;
            odemeTarihiLabel.Text = musteri.odemeTarihi;
        }

        private void odemeAlBtn_Click(object sender, EventArgs e)
        {
            string control = borcTextBox.Text;
            
            if (string.IsNullOrEmpty(control))
            {
                MessageBox.Show("Lütfen ödeme almak için bir sayı giriniz. \n(Örnek = 00,0)");
                return;
            }
            else if (!control.Contains(","))
            {
                MessageBox.Show("Geçersiz ödeme. Sadece sayı tuşlayınız ve kuruşu virgülle ayırınız! \n(Örnek = 00,0)");
                return;
            }
            string anaPara = borcTextBox.Text.Split(',')[0];
            string kurus = borcTextBox.Text.Split(',')[1];
            

            if (decimal.TryParse(anaPara, out decimal odemeMiktari) && decimal.TryParse(kurus, out decimal kurusMiktari) && kurus.Length==1)
            {
                odenenKurus = kurusMiktari;
                OdemeMiktari = odemeMiktari;

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Geçersiz ödeme. Lütfen virgülün sağına iki rakam eklemeyiniz!\n(Örnek = 00,0)");
            }
           
        }

        private void OdemeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
