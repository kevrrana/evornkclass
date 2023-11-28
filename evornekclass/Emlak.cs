using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evornekclass
{
    internal class Emlak
    {
        int fiyati;
        string adres;
        int odasayisi;
        string asansor;
        int binayasi;
        int binakatsayisi;
        string kullanimdurumu;
        int bulundugukat;
        string tapudurumu;
        string binarengi;

        public int Fiyati { get => fiyati; set => fiyati = value; }
        public string Adres { get => adres; set => adres = value; }
        public int Odasayisi { get => odasayisi; set => odasayisi = value; }
        public string Asansor { get => asansor; set => asansor = value; }
        public int Binayasi { get => binayasi; set => binayasi = value; }
        public int Binakatsayisi { get => binakatsayisi; set => binakatsayisi = value; }
        public string Kullanimdurumu { get => kullanimdurumu; set => kullanimdurumu = value; }
        public int Bulundugukat { get => bulundugukat; set => bulundugukat = value; }
        public string Tapudurumu { get => tapudurumu; set => tapudurumu = value; }
        public string Binarengi { get => binarengi; set => binarengi = value; }

        public Emlak(int fiyati, string adres, int odasayisi, string asansor, int binayasi, int binakatsayisi, string kullanimdurumu, int bulundugukat, string tapudurumu, string binarengi)
        {
            this.fiyati = fiyati;
            this.adres = adres;
            this.odasayisi = odasayisi;
            this.asansor = asansor;
            this.binayasi = binayasi;
            this.binakatsayisi = binakatsayisi;
            this.kullanimdurumu = kullanimdurumu;
            this.bulundugukat = bulundugukat;
            this.tapudurumu = tapudurumu;
            this.binarengi = binarengi;
        }
    }
}

