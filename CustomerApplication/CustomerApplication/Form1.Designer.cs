
namespace CustomerApplication
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.uygLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.urunFormBtn = new System.Windows.Forms.Button();
            this.mstEkleGecisBtn = new System.Windows.Forms.Button();
            this.mstBilgiBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uygLabel
            // 
            this.uygLabel.AutoSize = true;
            this.uygLabel.BackColor = System.Drawing.Color.Transparent;
            this.uygLabel.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.uygLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.uygLabel.Location = new System.Drawing.Point(378, 435);
            this.uygLabel.Name = "uygLabel";
            this.uygLabel.Size = new System.Drawing.Size(282, 19);
            this.uygLabel.TabIndex = 1;
            this.uygLabel.Text = "MuhasebeUygulamasi(Alpha) - by meferbas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.urunFormBtn);
            this.panel1.Controls.Add(this.uygLabel);
            this.panel1.Controls.Add(this.mstEkleGecisBtn);
            this.panel1.Controls.Add(this.mstBilgiBtn);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 454);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(261, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hoşgeldiniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // urunFormBtn
            // 
            this.urunFormBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunFormBtn.Location = new System.Drawing.Point(258, 307);
            this.urunFormBtn.Name = "urunFormBtn";
            this.urunFormBtn.Size = new System.Drawing.Size(152, 51);
            this.urunFormBtn.TabIndex = 4;
            this.urunFormBtn.Text = "Ürün Ekle/Sil/Güncelle";
            this.urunFormBtn.UseVisualStyleBackColor = true;
            this.urunFormBtn.Click += new System.EventHandler(this.urunFormBtn_Click);
            // 
            // mstEkleGecisBtn
            // 
            this.mstEkleGecisBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstEkleGecisBtn.Location = new System.Drawing.Point(266, 155);
            this.mstEkleGecisBtn.Name = "mstEkleGecisBtn";
            this.mstEkleGecisBtn.Size = new System.Drawing.Size(135, 51);
            this.mstEkleGecisBtn.TabIndex = 0;
            this.mstEkleGecisBtn.Text = "Müşteri Ekle/Sil";
            this.mstEkleGecisBtn.UseVisualStyleBackColor = true;
            this.mstEkleGecisBtn.Click += new System.EventHandler(this.mstEkleGecisBtn_Click);
            // 
            // mstBilgiBtn
            // 
            this.mstBilgiBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstBilgiBtn.Location = new System.Drawing.Point(266, 231);
            this.mstBilgiBtn.Name = "mstBilgiBtn";
            this.mstBilgiBtn.Size = new System.Drawing.Size(135, 51);
            this.mstBilgiBtn.TabIndex = 3;
            this.mstBilgiBtn.Text = "Müşteri Bilgileri - Borç Ödeme";
            this.mstBilgiBtn.UseVisualStyleBackColor = true;
            this.mstBilgiBtn.Click += new System.EventHandler(this.mstBilgiBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(155, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(357, 28);
            this.label15.TabIndex = 2;
            this.label15.Text = "Lütfen yapmak istediğiniz işlemi seçin";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(660, 454);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriUygulamasi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label uygLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mstEkleGecisBtn;
        private System.Windows.Forms.Button mstBilgiBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button urunFormBtn;
        private System.Windows.Forms.Label label1;
    }
}

