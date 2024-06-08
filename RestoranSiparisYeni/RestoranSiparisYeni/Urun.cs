using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranSiparisYeni
{
    public class Urun
    {
        public string Adi { get; set; }
        public decimal Fiyati { get; set; }

        public Urun(string adi, decimal fiyati)
        {
            Adi = adi;
            Fiyati = fiyati;
        }

        public override string ToString()
        {
            return $"{Adi} - {Fiyati:C}";
        }
    }
}
