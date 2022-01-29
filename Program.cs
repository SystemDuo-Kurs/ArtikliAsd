using ArtikliAsd;

//File.AppendAllText("text.txt", "123123uzasno komplikovano");
File.WriteAllText("text.txt", "Pera|Peric|p@p.asd\n");
File.AppendAllText("text.txt", "123\n");
File.AppendAllText("text.txt", "32423\n");
File.AppendAllText("text.txt", "324\n");
File.AppendAllText("text.txt", "234234\n");

if (File.Exists("text.txt"))
{
    foreach (string red in File.ReadLines("text.txt"))
    {
        string[] stringovi = red.Split('|');
        Osoba o = new();
        o._name = stringovi[0];
        o._surname = stringovi[1];
        o._email = stringovi[2];
    }
}

//MeniSistem.Meni();

internal class Osoba
{
    public string _name;
    public string _surname;
    public string _email;
}