using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestoranSiparisYeni
{
    public class Masa
    {
        public int MasaID { get; set; }
        public string MasaAdi { get; set; }
    }

    public static class MasaYonetimi
    {
        private static readonly string dosyaAdi = "masalar.json";
        private static readonly string dosyaYolu = "C:\\Users\\batuh\\Desktop\\RestoranSiparisYeni\\RestoranSiparisYeni\\masalar.json";
        private static List<Masa> masalar = new List<Masa>();

        public static List<Masa> MasalariGetir()
        {
            return masalar;
        }

        public static void MasaEkle(Masa masa)
        {
            masalar.Add(masa);
            MasalariKaydet();
        }

        public static void MasaSil(int masaID)
        {
            masalar.RemoveAll(masa => masa.MasaID == masaID);
            MasalariKaydet();
        }

        public static void MasalariKaydet()
        {
            string json = JsonConvert.SerializeObject(masalar);
            File.WriteAllText(dosyaYolu, json);
            
        }

        public static void MasalariYukle()
        {
            if (File.Exists(dosyaYolu))
            {
                string json = File.ReadAllText(dosyaYolu);
                masalar = JsonConvert.DeserializeObject<List<Masa>>(json);
                
            }
        }
    }
}
