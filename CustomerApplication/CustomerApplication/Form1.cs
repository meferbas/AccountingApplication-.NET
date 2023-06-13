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

    public partial class Form1 : Form
    {


        private List<Urun> urunListesi = new List<Urun>();

        public Form1()
        {
            InitializeComponent();
            mstEkleGecisBtn.Click += mstEkleGecisBtn_Click; 
        }
        private void mstEkleGecisBtn_Click(object sender, EventArgs e)
        {
           
            panel1.Controls.Clear();
            MusteriEkleSilForm musteriEkleSilForm = new MusteriEkleSilForm();

            musteriEkleSilForm.TopLevel = false;
            musteriEkleSilForm.FormBorderStyle = FormBorderStyle.None;
            musteriEkleSilForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(musteriEkleSilForm);

            musteriEkleSilForm.Show();
        }

        private void mstBilgiBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); 

            MusterilerForm musterilerFrm = new MusterilerForm();

            musterilerFrm.TopLevel = false;
            musterilerFrm.FormBorderStyle = FormBorderStyle.None;
            musterilerFrm.Dock = DockStyle.Fill;
            panel1.Controls.Add(musterilerFrm);

            musterilerFrm.Show();

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

        private void urunFormBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        
            urunForm urnForm = new urunForm();

            urnForm.TopLevel = false;
            urnForm.FormBorderStyle = FormBorderStyle.None;
            urnForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(urnForm);

            urnForm.Show();
        }

    }
   

}
