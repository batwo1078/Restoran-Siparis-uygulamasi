using System.Windows.Forms;

namespace RestoranSiparisYeni
{
    public partial class Form1 : Form
    {

        public FlowLayoutPanel FlowLayoutPanel1 => flowLayoutPanel1;
        private decimal toplamCiro = 0;

        public Form1()
        {
            InitializeComponent();
            MasaSayisiSor();

           
        }

        private void MasaSayisiSor()
        {
            // Kullan�c�ya ka� masa olu�turmak istedi�ini sor
            string input = Microsoft.VisualBasic.Interaction.InputBox("Ka� masa olu�turmak istiyorsunuz?", "Masa Say�s�", "10");
            int masaSayisi;

            // Kullan�c� iptal ederse veya ge�erli bir say� girmezse varsay�lan de�eri kullan
            if (!int.TryParse(input, out masaSayisi) || masaSayisi <= 0)
            {
                masaSayisi = 10;
            }

            // Masalar� olu�tur
            MasalariOlustur(masaSayisi);
        }

        private void MasalariOlustur(int masaSayisi)
        {
            int sutunSayisi = 3; // Masa butonlar�n�n s��abilece�i s�tun say�s�
            int satirSayisi = (int)Math.Ceiling((double)masaSayisi / sutunSayisi); // Masa butonlar�n�n s��abilece�i sat�r say�s�
            int butonGenislik = flowLayoutPanel1.ClientSize.Width / sutunSayisi;
            int butonYukseklik = flowLayoutPanel1.ClientSize.Height / satirSayisi;

            for (int i = 1; i <= masaSayisi; i++)
            {
                Button masaButton = new Button();
                masaButton.Text = "Masa " + i;
                masaButton.Tag = i;
                masaButton.Click += MasaButton_Click;
                masaButton.Size = new Size(butonGenislik, butonYukseklik);
                masaButton.BackColor = Color.Green;

                int satir = (i - 1) / sutunSayisi; // Masa butonunun bulunaca�� sat�r
                int sutun = (i - 1) % sutunSayisi; // Masa butonunun bulunaca�� s�tun

                // Masa butonlar�n� d�zenle
                flowLayoutPanel1.Controls.Add(masaButton);
            }
        }




        private void MasaButton_Click(object sender, EventArgs e)
        {
            Button masaButton = sender as Button;
            int masaNumarasi = (int)masaButton.Tag;
            SiparisFormu siparisFormu = new SiparisFormu(masaNumarasi);
            siparisFormu.Show();
        }

        private void urunEkleButton_Click(object sender, EventArgs e)
        {
            UrunEkleFormu urunEkleFormu = new UrunEkleFormu();
            urunEkleFormu.Show();
        }

        private void masaEkleButton_Click(object sender, EventArgs e)
        {
            int yeniMasaNumarasi = flowLayoutPanel1.Controls.Count + 1;
            Masa yeniMasa = new Masa { MasaID = yeniMasaNumarasi, MasaAdi = "Masa " + yeniMasaNumarasi };
            MasaYonetimi.MasaEkle(yeniMasa);
            MasaYonetimi.MasalariKaydet(); // Masalar� dosyaya kaydet
            Button masaButton = new Button();
            masaButton.Text = "Masa " + yeniMasaNumarasi;
            masaButton.Tag = yeniMasaNumarasi;
            masaButton.Click += MasaButton_Click;

            // Di�er masalar�n boyutlar�n� ve stillerini kullan
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Button)
                {
                    Button digerMasaButton = (Button)control;
                    masaButton.Size = digerMasaButton.Size; // Boyutlar� kopyala
                    masaButton.Font = digerMasaButton.Font; // Fontlar� kopyala
                    masaButton.ForeColor = digerMasaButton.ForeColor; // Renkleri kopyala
                    break; // Sadece bir masa kontrol� yapmak yeterli
                }
            }

            flowLayoutPanel1.Controls.Add(masaButton);
        }


        private void MasaSilButton_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                // En son eklenen masa butonunu bul
                Button sonMasaButonu = (Button)flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1];

                // MasaID'sini al
                int masaID = (int)sonMasaButonu.Tag;

                // Masa sil
                MasaYonetimi.MasaSil(masaID);
                MasaYonetimi.MasalariKaydet(); // Masalar� dosyaya kaydet
                flowLayoutPanel1.Controls.Remove(sonMasaButonu); // Butonu grafik aray�zden kald�r
            }
        }


        public void CiroyuGuncelle(decimal tutar)
        {
            toplamCiro += tutar;
            labelCiro.Text = $"G�nl�k Ciro: {toplamCiro:C}";
        }


    }
}