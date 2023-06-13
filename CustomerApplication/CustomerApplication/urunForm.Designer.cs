
namespace CustomerApplication
{
    partial class urunForm
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
            this.silBtn = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.anasayfaBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fiyatTextBox = new System.Windows.Forms.TextBox();
            this.urunTextBox = new System.Windows.Forms.TextBox();
            this.urunlerComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.silBtn);
            this.panel1.Controls.Add(this.guncelleBtn);
            this.panel1.Controls.Add(this.anasayfaBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ekleBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.fiyatTextBox);
            this.panel1.Controls.Add(this.urunTextBox);
            this.panel1.Controls.Add(this.urunlerComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 454);
            this.panel1.TabIndex = 0;
            // 
            // silBtn
            // 
            this.silBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silBtn.Location = new System.Drawing.Point(306, 216);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(100, 39);
            this.silBtn.TabIndex = 80;
            this.silBtn.Text = "Ürünü Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelleBtn.Location = new System.Drawing.Point(92, 216);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(150, 39);
            this.guncelleBtn.TabIndex = 79;
            this.guncelleBtn.Text = "Ürünü Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // anasayfaBtn
            // 
            this.anasayfaBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfaBtn.Location = new System.Drawing.Point(0, 0);
            this.anasayfaBtn.Name = "anasayfaBtn";
            this.anasayfaBtn.Size = new System.Drawing.Size(106, 32);
            this.anasayfaBtn.TabIndex = 78;
            this.anasayfaBtn.Text = "🏠 Anasayfa";
            this.anasayfaBtn.UseVisualStyleBackColor = true;
            this.anasayfaBtn.Click += new System.EventHandler(this.anasayfaBtn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(142, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "Ürünler";
            // 
            // ekleBtn
            // 
            this.ekleBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleBtn.Location = new System.Drawing.Point(464, 216);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(100, 39);
            this.ekleBtn.TabIndex = 76;
            this.ekleBtn.Text = "Ürün Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(496, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 75;
            this.label1.Text = "Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(327, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 74;
            this.label6.Text = "Ürün Adı";
            // 
            // fiyatTextBox
            // 
            this.fiyatTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyatTextBox.Location = new System.Drawing.Point(464, 168);
            this.fiyatTextBox.Name = "fiyatTextBox";
            this.fiyatTextBox.Size = new System.Drawing.Size(100, 23);
            this.fiyatTextBox.TabIndex = 73;
            this.fiyatTextBox.TextChanged += new System.EventHandler(this.fiyatTextBox_TextChanged);
            // 
            // urunTextBox
            // 
            this.urunTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunTextBox.Location = new System.Drawing.Point(306, 168);
            this.urunTextBox.Name = "urunTextBox";
            this.urunTextBox.Size = new System.Drawing.Size(100, 23);
            this.urunTextBox.TabIndex = 72;
            this.urunTextBox.TextChanged += new System.EventHandler(this.urunTextBox_TextChanged);
            // 
            // urunlerComboBox
            // 
            this.urunlerComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunlerComboBox.FormattingEnabled = true;
            this.urunlerComboBox.Location = new System.Drawing.Point(92, 168);
            this.urunlerComboBox.Name = "urunlerComboBox";
            this.urunlerComboBox.Size = new System.Drawing.Size(150, 23);
            this.urunlerComboBox.TabIndex = 71;
            this.urunlerComboBox.SelectedIndexChanged += new System.EventHandler(this.urunlerComboBox_SelectedIndexChanged);
            // 
            // urunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(660, 454);
            this.Controls.Add(this.panel1);
            this.Name = "urunForm";
            this.Text = "urunForm";
            this.Load += new System.EventHandler(this.urunForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button anasayfaBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fiyatTextBox;
        private System.Windows.Forms.TextBox urunTextBox;
        private System.Windows.Forms.ComboBox urunlerComboBox;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.Button silBtn;
    }
}