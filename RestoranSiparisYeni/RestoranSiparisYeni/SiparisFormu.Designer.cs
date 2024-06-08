namespace RestoranSiparisYeni
{
    partial class SiparisFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUrunler;
        private System.Windows.Forms.ListBox listBoxSiparisler;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.Button sifirlaButton;
        private System.Windows.Forms.Button hesapButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.flowLayoutPanelUrunler = new System.Windows.Forms.FlowLayoutPanel();
            this.listBoxSiparisler = new System.Windows.Forms.ListBox();
            this.ekleButton = new System.Windows.Forms.Button();
            this.kaydetButton = new System.Windows.Forms.Button();
            this.sifirlaButton = new System.Windows.Forms.Button();
            this.hesapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // flowLayoutPanelUrunler
            this.flowLayoutPanelUrunler.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelUrunler.Name = "flowLayoutPanelUrunler";
            this.flowLayoutPanelUrunler.Size = new System.Drawing.Size(260, 100);
            this.flowLayoutPanelUrunler.TabIndex = 0;

            // listBoxSiparisler
            this.listBoxSiparisler.FormattingEnabled = true;
            this.listBoxSiparisler.Location = new System.Drawing.Point(12, 118);
            this.listBoxSiparisler.Name = "listBoxSiparisler";
            this.listBoxSiparisler.Size = new System.Drawing.Size(260, 147);
            this.listBoxSiparisler.TabIndex = 1;

            // ekleButton
            this.ekleButton.Location = new System.Drawing.Point(12, 271);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(60, 23);
            this.ekleButton.TabIndex = 2;
            this.ekleButton.Text = "Ekle";
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);

            // kaydetButton
            this.kaydetButton.Location = new System.Drawing.Point(78, 271);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(60, 23);
            this.kaydetButton.TabIndex = 3;
            this.kaydetButton.Text = "Kaydet";
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);

            // sifirlaButton
            this.sifirlaButton.Location = new System.Drawing.Point(144, 271);
            this.sifirlaButton.Name = "sifirlaButton";
            this.sifirlaButton.Size = new System.Drawing.Size(60, 23);
            this.sifirlaButton.TabIndex = 4;
            this.sifirlaButton.Text = "Sıfırla";
            this.sifirlaButton.UseVisualStyleBackColor = true;
            this.sifirlaButton.Click += new System.EventHandler(this.sifirlaButton_Click);

            // hesapButton
            this.hesapButton.Location = new System.Drawing.Point(210, 271);
            this.hesapButton.Name = "hesapButton";
            this.hesapButton.Size = new System.Drawing.Size(60, 23);
            this.hesapButton.TabIndex = 5;
            this.hesapButton.Text = "Hesap";
            this.hesapButton.UseVisualStyleBackColor = true;
            this.hesapButton.Click += new System.EventHandler(this.hesapButton_Click);

            // SiparisFormu
            this.ClientSize = new System.Drawing.Size(284, 306);
            this.Controls.Add(this.hesapButton);
            this.Controls.Add(this.sifirlaButton);
            this.Controls.Add(this.kaydetButton);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.listBoxSiparisler);
            this.Controls.Add(this.flowLayoutPanelUrunler);
            this.Name = "SiparisFormu";
            this.Text = "Sipariş Formu";
            this.ResumeLayout(false);
        }
    }
}