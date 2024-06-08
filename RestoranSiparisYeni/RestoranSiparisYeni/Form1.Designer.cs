namespace RestoranSiparisYeni
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button urunEkleButton;

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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.urunEkleButton = new System.Windows.Forms.Button();
            this.masaEkleButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCiro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(384, 373);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // urunEkleButton
            // 
            this.urunEkleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.urunEkleButton.Location = new System.Drawing.Point(12, 379);
            this.urunEkleButton.Name = "urunEkleButton";
            this.urunEkleButton.Size = new System.Drawing.Size(65, 65);
            this.urunEkleButton.TabIndex = 1;
            this.urunEkleButton.Text = "Ürünler";
            this.urunEkleButton.UseVisualStyleBackColor = true;
            this.urunEkleButton.Click += new System.EventHandler(this.urunEkleButton_Click);
            // 
            // masaEkleButton
            // 
            this.masaEkleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.masaEkleButton.Location = new System.Drawing.Point(242, 384);
            this.masaEkleButton.Name = "masaEkleButton";
            this.masaEkleButton.Size = new System.Drawing.Size(65, 65);
            this.masaEkleButton.TabIndex = 2;
            this.masaEkleButton.Text = "Masa Ekle";
            this.masaEkleButton.UseVisualStyleBackColor = true;
            this.masaEkleButton.Click += new System.EventHandler(this.masaEkleButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(313, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "Masa Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MasaSilButton_Click);
            // 
            // labelCiro
            // 
            this.labelCiro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCiro.AutoSize = true;
            this.labelCiro.Location = new System.Drawing.Point(136, 419);
            this.labelCiro.Name = "labelCiro";
            this.labelCiro.Size = new System.Drawing.Size(73, 15);
            this.labelCiro.TabIndex = 4;
            this.labelCiro.Text = "Günlük Ciro:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.labelCiro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.masaEkleButton);
            this.Controls.Add(this.urunEkleButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Restoran Sipariş Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button masaEkleButton;
        private Button button1;
        private Label labelCiro;
    }
}