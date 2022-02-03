using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtikliAsd
{
    internal class Racun
    {
        internal static List<Racun> _racuni = new();
        internal int _rbr;
        internal DateTime _vremeIzdavanja;
        internal Dictionary<Artikal, int> _artikli = new();
        internal decimal _suma;
    }
}