using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtikliAsd
{
    public class Artikal
    {
        public static List<Artikal> _artikli = new();

        public string _sifra = string.Empty;
        public string _naziv = string.Empty;

        public int _kolicina;

        public decimal _ulazna;
        public int _marzaProc;

        public decimal _izlazna;

        public int _porezProc;
        public decimal _izlaznaPorez;
    }
}