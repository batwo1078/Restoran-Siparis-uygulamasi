namespace RestoranSiparisYeni
{
    partial class UrunEkleFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox urunAdiTextBox;
        private System.Windows.Forms.TextBox urunFiyatiTextBox;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.ListBox urunListBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUrunler;

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
            this.urunAdiTextBox = new System.Windows.Forms.TextBox();
            this.urunFiyatiTextBox = new System.Windows.Forms.TextBox();
            this.ekleButton = new System.Windows.Forms.Button();
            this.urunListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanelUrunler = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // urunAdiTextBox
            // 
            this.urunAdiTextBox.Location = new System.Drawing.Point(68, 12);
            this.urunAdiTextBox.Name = "urunAdiTextBox";
            this.urunAdiTextBox.Size = new System.Drawing.Size(100, 23);
            this.urunAdiTextBox.TabIndex = 7;
            // 
            // urunFiyatiTextBox
            // 
            this.urunFiyatiTextBox.Location = new System.Drawing.Point(68, 44);
            this.urunFiyatiTextBox.Name = "urunFiyatiTextBox";
            this.urunFiyatiTextBox.Size = new System.Drawing.Size(100, 23);
            this.urunFiyatiTextBox.TabIndex = 6;
            // 
            // ekleButton
            // 
            this.ekleButton.Location = new System.Drawing.Point(230, 43);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(75, 23);
            this.ekleButton.TabIndex = 5;
            this.ekleButton.Text = "Ekle";
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // urunListBox
            // 
            this.urunListBox.FormattingEnabled = true;
            this.urunListBox.ItemHeight = 15;
            this.urunListBox.Location = new System.Drawing.Point(12, 74);
            this.urunListBox.Name = "urunListBox";
            this.urunListBox.Size = new System.Drawing.Size(200, 199);
            this.urunListBox.TabIndex = 3;
            this.urunListBox.SelectedIndexChanged += new System.EventHandler(this.urunListBox_SelectedIndexChanged);
            // 
            // flowLayoutPanelUrunler
            // 
            this.flowLayoutPanelUrunler.Location = new System.Drawing.Point(218, 74);
            this.flowLayoutPanelUrunler.Name = "flowLayoutPanelUrunler";
            this.flowLayoutPanelUrunler.Size = new System.Drawing.Size(100, 200);
            this.flowLayoutPanelUrunler.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fiyat:";
            // 
            // UrunEkleFormu
            // 
            this.ClientSize = new System.Drawing.Size(487, 352);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelUrunler);
            this.Controls.Add(this.urunListBox);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.urunFiyatiTextBox);
            this.Controls.Add(this.urunAdiTextBox);
            this.Name = "UrunEkleFormu";
            this.Text = "Ürün Ekle";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Label label2;
    }
}