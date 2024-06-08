using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranSiparisYeni
{
    public partial class UrunEkleFormu : Form
    {
        public UrunEkleFormu()
        {
            InitializeComponent();
            UrunleriGoster();
        }

        private void UrunleriGoster()
        {
            urunListBox.Items.Clear();
            flowLayoutPanelUrunler.Controls.Clear();

            foreach (var urun in UrunListesi.Urunler)
            {
                urunListBox.Items.Add($"{urun.Adi} - {urun.Fiyati:C}");

                Button silButton = new Button();
                silButton.Text = "Sil";
                silButton.Tag = urun;
                silButton.Click += SilButton_Click;
                flowLayoutPanelUrunler.Controls.Add(silButton);
            }
        }

        private void SilButton_Click(object sender, EventArgs e)
        {
            Button silButton = sender as Button;
            Urun urun = silButton.Tag as Urun;
            if (urun != null)
            {
                UrunListesi.UrunSil(urun); // Ürünü sil
                UrunleriGoster(); // Görsel arayüzü güncelle
            }
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            string urunAdi = urunAdiTextBox.Text;
            decimal urunFiyati = Convert.ToDecimal(urunFiyatiTextBox.Text);

            Urun urun = new Urun(urunAdi, urunFiyati);
            UrunListesi.UrunEkle(urun);

            UrunleriGoster();
            MessageBox.Show("Ürün eklendi!");
            urunAdiTextBox.Clear();
            urunFiyatiTextBox.Clear();
        }

        private void urunListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ListBox seçim değiştirdiğinde yapılacak işlemler (şu anda boş)
        }

       
    }
}
