
namespace CustomerApplication
{
    partial class MusteriEkleSilForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.hesaplaBtn = new System.Windows.Forms.Button();
            this.adetTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.urunlerComboBox = new System.Windows.Forms.ComboBox();
            this.anaSayfaBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.mstList = new System.Windows.Forms.ListBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.borcTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.odemeDateTP = new System.Windows.Forms.DateTimePicker();
            this.mstSilBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mstEklebtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.hesaplaBtn);
            this.panel1.Controls.Add(this.adetTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.urunlerComboBox);
            this.panel1.Controls.Add(this.anaSayfaBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.mstList);
            this.panel1.Controls.Add(this.soyadTextBox);
            this.panel1.Controls.Add(this.adTextBox);
            this.panel1.Controls.Add(this.borcTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.odemeDateTP);
            this.panel1.Controls.Add(this.mstSilBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.mstEklebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 458);
            this.panel1.TabIndex = 0;
            // 
            // hesaplaBtn
            // 
            this.hesaplaBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesaplaBtn.Location = new System.Drawing.Point(288, 198);
            this.hesaplaBtn.Name = "hesaplaBtn";
            this.hesaplaBtn.Size = new System.Drawing.Size(98, 29);
            this.hesaplaBtn.TabIndex = 61;
            this.hesaplaBtn.Text = "Borç Hesapla";
            this.hesaplaBtn.UseVisualStyleBackColor = true;
            this.hesaplaBtn.Click += new System.EventHandler(this.hesaplaBtn_Click);
            // 
            // adetTextBox
            // 
            this.adetTextBox.Location = new System.Drawing.Point(162, 203);
            this.adetTextBox.Name = "adetTextBox";
            this.adetTextBox.Size = new System.Drawing.Size(100, 20);
            this.adetTextBox.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(176, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 59;
            this.label6.Text = "Adet Sayısı";
            // 
            // urunlerComboBox
            // 
            this.urunlerComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunlerComboBox.FormattingEnabled = true;
            this.urunlerComboBox.Location = new System.Drawing.Point(43, 201);
            this.urunlerComboBox.Name = "urunlerComboBox";
            this.urunlerComboBox.Size = new System.Drawing.Size(100, 23);
            this.urunlerComboBox.TabIndex = 50;
            // 
            // anaSayfaBtn
            // 
            this.anaSayfaBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anaSayfaBtn.Location = new System.Drawing.Point(0, 0);
            this.anaSayfaBtn.Name = "anaSayfaBtn";
            this.anaSayfaBtn.Size = new System.Drawing.Size(98, 29);
            this.anaSayfaBtn.TabIndex = 58;
            this.anaSayfaBtn.Text = "🏠 Anasayfa";
            this.anaSayfaBtn.UseVisualStyleBackColor = true;
            this.anaSayfaBtn.Click += new System.EventHandler(this.anaSayfaBtn_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(515, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 57;
            this.label7.Text = "Müşteriler";
            // 
            // mstList
            // 
            this.mstList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mstList.FormattingEnabled = true;
            this.mstList.ItemHeight = 16;
            this.mstList.Location = new System.Drawing.Point(445, 98);
            this.mstList.Name = "mstList";
            this.mstList.Size = new System.Drawing.Size(213, 212);
            this.mstList.TabIndex = 56;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(162, 138);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(100, 20);
            this.soyadTextBox.TabIndex = 47;
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(43, 138);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(100, 20);
            this.adTextBox.TabIndex = 46;
            // 
            // borcTextBox
            // 
            this.borcTextBox.Location = new System.Drawing.Point(288, 138);
            this.borcTextBox.Name = "borcTextBox";
            this.borcTextBox.ReadOnly = true;
            this.borcTextBox.Size = new System.Drawing.Size(100, 20);
            this.borcTextBox.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(186, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Müşteri Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(70, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Ürün";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(323, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Borç";
            // 
            // odemeDateTP
            // 
            this.odemeDateTP.Location = new System.Drawing.Point(105, 273);
            this.odemeDateTP.Name = "odemeDateTP";
            this.odemeDateTP.Size = new System.Drawing.Size(213, 20);
            this.odemeDateTP.TabIndex = 55;
            // 
            // mstSilBtn
            // 
            this.mstSilBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mstSilBtn.Location = new System.Drawing.Point(560, 316);
            this.mstSilBtn.Name = "mstSilBtn";
            this.mstSilBtn.Size = new System.Drawing.Size(95, 37);
            this.mstSilBtn.TabIndex = 45;
            this.mstSilBtn.Text = "Müşteri Sil";
            this.mstSilBtn.UseVisualStyleBackColor = true;
            this.mstSilBtn.Click += new System.EventHandler(this.mstSilBtn_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(161, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Ödeme Tarihi:";
            // 
            // mstEklebtn
            // 
            this.mstEklebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mstEklebtn.Location = new System.Drawing.Point(445, 316);
            this.mstEklebtn.Name = "mstEklebtn";
            this.mstEklebtn.Size = new System.Drawing.Size(95, 37);
            this.mstEklebtn.TabIndex = 44;
            this.mstEklebtn.Text = "Müşteri Ekle";
            this.mstEklebtn.UseVisualStyleBackColor = true;
            this.mstEklebtn.Click += new System.EventHandler(this.mstEklebtn_Click);
            // 
            // MusteriEkleSilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(649, 458);
            this.Controls.Add(this.panel1);
            this.Name = "MusteriEkleSilForm";
            this.Text = "MusteriEkleSilForm";
            this.Load += new System.EventHandler(this.MusteriEkleSilForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button anaSayfaBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox mstList;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox borcTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker odemeDateTP;
        private System.Windows.Forms.Button mstSilBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button mstEklebtn;
        private System.Windows.Forms.ComboBox urunlerComboBox;
        private System.Windows.Forms.Button hesaplaBtn;
        private System.Windows.Forms.TextBox adetTextBox;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}