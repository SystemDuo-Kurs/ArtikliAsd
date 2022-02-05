using ArtikliAsd;

public static partial class MeniSistem
{
    public static void NoviRacun()
    {
        Racun r = new();
        do
        {
            Console.Write("Unesite sifru artikla: ");
            string sifra = Console.ReadLine();
            Artikal a = Artikal._artikli.
                Where(art => art._sifra == sifra).
                FirstOrDefault();
            if (a is null)
            {
                Console.WriteLine("Sifra jok");
                Console.ReadKey();
                Console.Clear();
                continue;
            }

            Console.Write("Kolicina: ");
            int kol = int.Parse(Console.ReadLine());
            if (kol > 0 && kol <= a._kolicina)
            {
                if (r._artikli.ContainsKey(a))
                {
                    r._artikli[a] += kol;
                }
                else
                {
                    r._artikli.Add(a, kol);
                }

                a._kolicina -= kol;
                Console.WriteLine("=====================");
                r.IspisSvihArtikala().ForEach(art => Console.WriteLine(art));
                Console.WriteLine("=====================");
                Console.Write("Jos? (d/n) ");
                if (Console.ReadLine() == "n")
                    break;
            }
        } while (true);
        r._vremeIzdavanja = DateTime.Now;
        r._rbr = Racun._racuni.Count + 1;
        r._artikli.Keys.ToList().ForEach(kljuc =>
            r._suma += kljuc._izlaznaPorez * r._artikli[kljuc]);
        Console.WriteLine($"Suma: {r._suma}");
        Racun._racuni.Add(r);
    }

    public static void MeniRacuni()
    {
        Console.Clear();
        Console.WriteLine("1. Novi racun");
        Console.WriteLine("2. Prikaz");
        Console.WriteLine("3. Nazad");
        Console.Write("Izbor: ");
        string unos = Console.ReadLine();
        switch (unos)
        {
            case "1":
                NoviRacun();
                break;

            case "2":
                PrikazRacuna();
                break;

            case "3":
                return;
        }
    }

    public static void PrikazRacuna()
    {
        Racun._racuni.ForEach(r =>
        {
            Console.WriteLine($"Rbr. : {r._rbr}");
            Console.WriteLine($"Vreme : {r._vremeIzdavanja}");
            Console.WriteLine("=====================");
            r.IspisSvihArtikala().ForEach(art => Console.WriteLine(art));
            Console.WriteLine("=====================");
            Console.WriteLine($"Total: {r._suma}");
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~\n");
        });
        Console.ReadKey();
    }
}