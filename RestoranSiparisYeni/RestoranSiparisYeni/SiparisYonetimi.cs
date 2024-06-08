using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RestoranSiparisYeni
{
    public static class SiparisYonetimi
    {
        private static readonly string dosyaYolu = "siparisler.json";

        public static Dictionary<int, List<Urun>> MasaSiparisleri { get; private set; } = new Dictionary<int, List<Urun>>();

        static SiparisYonetimi()
        {
            SiparisleriYukle();
        }

        public static void SiparisEkle(int masaNumarasi, Urun urun)
        {
            if (!MasaSiparisleri.ContainsKey(masaNumarasi))
            {
                MasaSiparisleri[masaNumarasi] = new List<Urun>();
            }
            MasaSiparisleri[masaNumarasi].Add(urun);
            SiparisleriKaydet();
        }

        public static List<Urun> SiparisGetir(int masaNumarasi)
        {
            if (MasaSiparisleri.ContainsKey(masaNumarasi))
            {
                return new List<Urun>(MasaSiparisleri[masaNumarasi]);
            }
            return new List<Urun>();
        }

        public static void SiparisTemizle(int masaNumarasi)
        {
            if (MasaSiparisleri.ContainsKey(masaNumarasi))
            {
                MasaSiparisleri[masaNumarasi].Clear();
            }
            SiparisleriKaydet();
        }

        public static void UrunSil(Urun urun)
        {
            foreach (var masaSiparis in MasaSiparisleri.Values)
            {
                masaSiparis.RemoveAll(u => u.Adi == urun.Adi && u.Fiyati == urun.Fiyati);
            }
            SiparisleriKaydet();
        }

        public static void SiparisleriKaydet()
        {
            var jsonString = JsonSerializer.Serialize(MasaSiparisleri);
            File.WriteAllText(dosyaYolu, jsonString);
        }

        private static void SiparisleriYukle()
        {
            if (File.Exists(dosyaYolu))
            {
                var jsonString = File.ReadAllText(dosyaYolu);
                MasaSiparisleri = JsonSerializer.Deserialize<Dictionary<int, List<Urun>>>(jsonString) ?? new Dictionary<int, List<Urun>>();
            }
        }
    }
}
