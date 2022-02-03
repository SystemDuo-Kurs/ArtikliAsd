using ArtikliAsd;

if (File.Exists("art.txt"))
{
    foreach (string red in File.ReadLines("art.txt"))
    {
        string[] stvari = red.Split('|');
        Artikal a = new Artikal
        {
            _sifra = stvari[0],
            _naziv = stvari[1],
            _kolicina = int.Parse(stvari[2]),
            _ulazna = decimal.Parse(stvari[3]),
            _marzaProc = int.Parse(stvari[4]),
            _porezProc = int.Parse(stvari[5]),
            _izlazna = decimal.Parse(stvari[6]),
            _izlaznaPorez = decimal.Parse(stvari[7])
        };
        Artikal._artikli.Add(a);
    }
}

MeniSistem.Meni();