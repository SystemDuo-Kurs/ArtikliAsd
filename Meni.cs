using ArtikliAsd;

public static class MeniSistem
{
    public static void Meni()
    {
        do
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("1. Artikli");
            Console.WriteLine("2. Izlaz");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("Izbor: ");
            string unos = Console.ReadLine();
            switch (unos)
            {
                case "1":
                    MeniArtikli();
                    break;

                case "2":
                    return;
            }
            Console.Clear();
        } while (true);
    }

    public static void MeniArtikli()
    {
        Console.Clear();
        Console.WriteLine("1. Unos artikla");
        Console.WriteLine("2. Nazad");
        Console.Write("Izbor: ");
        string unos = Console.ReadLine();
        switch (unos)
        {
            case "1":
                UnosArtikla();
                break;

            case "2":
                return;
        }
    }

    public static void UnosArtikla()
    {
        Artikal a = new();
        Console.Write("Unesi sifru: ");
        a._sifra = Console.ReadLine();

        bool duplikat = false;
        foreach (Artikal art in Artikal._artikli)
        {
            if (art._sifra == a._sifra)
            {
                duplikat = true;
                break;
            }
        }

        if (duplikat)
        {
            Console.WriteLine("Jooook");
        }
        else
        {
            Console.Write("Unesi naziv: ");
            a._naziv = Console.ReadLine();
            Console.Write("Unesi kolicina: ");
            a._kolicina = int.Parse(Console.ReadLine());
            Console.Write("Unesi ucenu: ");
            a._ulazna = decimal.Parse(Console.ReadLine());
            Console.Write("Unesi porez");
            a._porezProc = int.Parse(Console.ReadLine());
            if (a._kolicina >= 0 && a._ulazna > 0 && a._porezProc >= 0)
            {
                Artikal._artikli.Add(a);
            }
            else
            {
                Console.WriteLine("Nis' ne valja");
                return;
            }
        }
    }
}