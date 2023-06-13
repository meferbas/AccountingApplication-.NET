
namespace CustomerApplication
{
    partial class OdemeForm
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
            this.odemeAlBtn = new System.Windows.Forms.Button();
            this.borcTextBox = new System.Windows.Forms.TextBox();
            this.adLabel = new System.Windows.Forms.Label();
            this.soyadLabel = new System.Windows.Forms.Label();
            this.borcLabel = new System.Windows.Forms.Label();
            this.odemeTarihiLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // odemeAlBtn
            // 
            this.odemeAlBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odemeAlBtn.Location = new System.Drawing.Point(238, 127);
            this.odemeAlBtn.Name = "odemeAlBtn";
            this.odemeAlBtn.Size = new System.Drawing.Size(100, 26);
            this.odemeAlBtn.TabIndex = 45;
            this.odemeAlBtn.Text = "Ödeme Al";
            this.odemeAlBtn.UseVisualStyleBackColor = true;
            this.odemeAlBtn.Click += new System.EventHandler(this.odemeAlBtn_Click);
            // 
            // borcTextBox
            // 
            this.borcTextBox.Location = new System.Drawing.Point(238, 86);
            this.borcTextBox.Name = "borcTextBox";
            this.borcTextBox.Size = new System.Drawing.Size(100, 20);
            this.borcTextBox.TabIndex = 47;
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.adLabel.Location = new System.Drawing.Point(70, 66);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(24, 19);
            this.adLabel.TabIndex = 48;
            this.adLabel.Text = "ad";
            // 
            // soyadLabel
            // 
            this.soyadLabel.AutoSize = true;
            this.soyadLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.soyadLabel.Location = new System.Drawing.Point(57, 94);
            this.soyadLabel.Name = "soyadLabel";
            this.soyadLabel.Size = new System.Drawing.Size(45, 19);
            this.soyadLabel.TabIndex = 49;
            this.soyadLabel.Text = "soyad";
            // 
            // borcLabel
            // 
            this.borcLabel.AutoSize = true;
            this.borcLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.borcLabel.Location = new System.Drawing.Point(57, 131);
            this.borcLabel.Name = "borcLabel";
            this.borcLabel.Size = new System.Drawing.Size(37, 19);
            this.borcLabel.TabIndex = 50;
            this.borcLabel.Text = "borc";
            // 
            // odemeTarihiLabel
            // 
            this.odemeTarihiLabel.AutoSize = true;
            this.odemeTarihiLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.odemeTarihiLabel.Location = new System.Drawing.Point(57, 164);
            this.odemeTarihiLabel.Name = "odemeTarihiLabel";
            this.odemeTarihiLabel.Size = new System.Drawing.Size(51, 19);
            this.odemeTarihiLabel.TabIndex = 51;
            this.odemeTarihiLabel.Text = "odeme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "-Müşteri Bilgileri-";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.odemeTarihiLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.adLabel);
            this.groupBox1.Controls.Add(this.soyadLabel);
            this.groupBox1.Controls.Add(this.borcLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 222);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // OdemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(359, 254);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.borcTextBox);
            this.Controls.Add(this.odemeAlBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OdemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OdemeForm";
            this.Load += new System.EventHandler(this.OdemeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odemeAlBtn;
        private System.Windows.Forms.TextBox borcTextBox;
        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.Label soyadLabel;
        private System.Windows.Forms.Label borcLabel;
        private System.Windows.Forms.Label odemeTarihiLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}