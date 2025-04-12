namespace Araba_bilgi_formu
{
    partial class Form1
    {
        /// <summary>
        /// Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        /// <param name="disposing">yönetilen kaynaklar dispose edilmeliyse true; aksi halde false.</param>
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
        /// Tasarımcı desteği için gerekli metot.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtKapiSayisi = new System.Windows.Forms.TextBox();
            this.txtPencereSayisi = new System.Windows.Forms.TextBox();
            this.txtYakit = new System.Windows.Forms.TextBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtMarka
            this.txtMarka.Location = new System.Drawing.Point(30, 30);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(150, 22);
            this.txtMarka.TabIndex = 0;

            // txtModel
            this.txtModel.Location = new System.Drawing.Point(30, 60);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(150, 22);
            this.txtModel.TabIndex = 1;

            // txtRenk
            this.txtRenk.Location = new System.Drawing.Point(30, 90);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(150, 22);
            this.txtRenk.TabIndex = 2;

            // txtKapiSayisi
            this.txtKapiSayisi.Location = new System.Drawing.Point(30, 120);
            this.txtKapiSayisi.Name = "txtKapiSayisi";
            this.txtKapiSayisi.Size = new System.Drawing.Size(150, 22);
            this.txtKapiSayisi.TabIndex = 3;

            // txtPencereSayisi
            this.txtPencereSayisi.Location = new System.Drawing.Point(30, 150);
            this.txtPencereSayisi.Name = "txtPencereSayisi";
            this.txtPencereSayisi.Size = new System.Drawing.Size(150, 22);
            this.txtPencereSayisi.TabIndex = 4;

            // txtYakit
            this.txtYakit.Location = new System.Drawing.Point(30, 180);
            this.txtYakit.Name = "txtYakit";
            this.txtYakit.Size = new System.Drawing.Size(150, 22);
            this.txtYakit.TabIndex = 5;

            // btnGoster
            this.btnGoster.Location = new System.Drawing.Point(30, 220);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(150, 30);
            this.btnGoster.TabIndex = 6;
            this.btnGoster.Text = "Bilgileri Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.button1_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.txtYakit);
            this.Controls.Add(this.txtPencereSayisi);
            this.Controls.Add(this.txtKapiSayisi);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Name = "Form1";
            this.Text = "Araba Bilgi Formu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtKapiSayisi;
        private System.Windows.Forms.TextBox txtPencereSayisi;
        private System.Windows.Forms.TextBox txtYakit;
        private System.Windows.Forms.Button btnGoster;
    }
}
