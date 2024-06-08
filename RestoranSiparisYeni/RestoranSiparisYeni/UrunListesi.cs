using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RestoranSiparisYeni
{
    public static class UrunListesi
    {
        private static readonly string dosyaYolu = "urunler.json";

        public static List<Urun> Urunler { get; private set; } = new List<Urun>();

        static UrunListesi()
        {
            UrunleriYukle();
        }

        public static void UrunEkle(Urun urun)
        {
            Urunler.Add(urun);
            UrunleriKaydet();
        }

        public static void UrunSil(Urun urun)
        {
            Urunler.RemoveAll(u => u.Adi == urun.Adi && u.Fiyati == urun.Fiyati);
            UrunleriKaydet();
            SiparisYonetimi.UrunSil(urun); // Siparişlerden de silinmeli
        }

        private static void UrunleriKaydet()
        {
            var jsonString = JsonSerializer.Serialize(Urunler);
            File.WriteAllText(dosyaYolu, jsonString);
        }

        private static void UrunleriYukle()
        {
            if (File.Exists(dosyaYolu))
            {
                var jsonString = File.ReadAllText(dosyaYolu);
                Urunler = JsonSerializer.Deserialize<List<Urun>>(jsonString) ?? new List<Urun>();
            }
        }
    }
}
