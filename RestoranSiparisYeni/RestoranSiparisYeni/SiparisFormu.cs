using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace RestoranSiparisYeni
{
    public partial class SiparisFormu : Form
    {
        private int masaNumarasi;
        private List<Urun> seciliUrunler = new List<Urun>();

        public SiparisFormu(int masaNumarasi)
        {
            InitializeComponent();
            this.masaNumarasi = masaNumarasi;
            UrunButonlariniOlustur();
            SiparisleriYukle();
        }

        private void UrunButonlariniOlustur()
        {
            foreach (var urun in UrunListesi.Urunler)
            {
                Button urunButton = new Button();
                urunButton.Text = $"{urun.Adi}\n{urun.Fiyati:C}";
                urunButton.Tag = urun;
                urunButton.Click += UrunButton_Click;
                flowLayoutPanelUrunler.Controls.Add(urunButton);
            }
        }

        private void UrunButton_Click(object sender, EventArgs e)
        {
            Button urunButton = sender as Button;
            Urun seciliUrun = urunButton.Tag as Urun;
            if (seciliUrun != null)
            {
                seciliUrunler.Add(seciliUrun);
                listBoxSiparisler.Items.Add(seciliUrun.ToString());
            }
        }

        private void SiparisleriYukle()
        {
            seciliUrunler = SiparisYonetimi.SiparisGetir(masaNumarasi);
            listBoxSiparisler.Items.Clear();
            foreach (var urun in seciliUrunler)
            {
                listBoxSiparisler.Items.Add(urun.ToString());
            }
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            // Ekleme işlemi artık butonlarla yapılacak, bu nedenle bu buton gereksiz olabilir.
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            SiparisYonetimi.MasaSiparisleri[masaNumarasi] = new List<Urun>(seciliUrunler);
            SiparisYonetimi.SiparisleriKaydet();
            MessageBox.Show("Sipariş kaydedildi!");

            // Form1'i bul
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            if (form1 != null)
            {
                // flowLayoutPanel1 içindeki butonları dolaş
                foreach (Control control in form1.FlowLayoutPanel1.Controls)
                {
                    if (control is Button masaButton && masaButton.Tag != null && (int)masaButton.Tag == masaNumarasi)
                    {
                        masaButton.BackColor = Color.Red; // Yeşil renk
                        break;
                    }
                }
            }

            this.Close();
        }

        private void sifirlaButton_Click(object sender, EventArgs e)
        {
            seciliUrunler.Clear();
            listBoxSiparisler.Items.Clear();
            SiparisYonetimi.SiparisTemizle(masaNumarasi);

            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            if (form1 != null)
            {
                // flowLayoutPanel1 içindeki butonları dolaş
                foreach (Control control in form1.FlowLayoutPanel1.Controls)
                {
                    if (control is Button masaButton && masaButton.Tag != null && (int)masaButton.Tag == masaNumarasi)
                    {
                        masaButton.BackColor = Color.Green; // Yeşil renk
                        break;
                    }
                }
            }


        }

        private void hesapButton_Click(object sender, EventArgs e)
        {
            decimal toplam = seciliUrunler.Sum(urun => urun.Fiyati);
            MessageBox.Show($"Toplam hesap: {toplam:C}");

            // Form1'i bul
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            if (form1 != null)
            {
                form1.CiroyuGuncelle(toplam);
            }
        }
    }
}
