public class Person
{
    public string Meno { get; set; }

    public string Priezvisko { get; set; }

    public int Vek { get; set; }

    public double Vyska { get; set; }

    public void PovedzInfoOsebe()
    {
        Console.WriteLine("Moje meno je: " + Meno + " " + Priezvisko);
        Console.WriteLine("Moj vek je: " + Vek + " a moja vyska je: " + Vyska);
    }

    static void Main(string[] args)
    {
        Person jano = new Person();
        jano.Meno = "Jano";
        jano.Priezvisko = "Jablko";
        jano.Vek = 32;
        jano.Vyska = 185.2;

        Person miro = new Person();
        miro.Meno = "Miro";
        miro.Priezvisko = "Hruska";
        miro.Vek = 25;
        miro.Vyska = 190.2;

        jano.PovedzInfoOsebe();
        miro.PovedzInfoOsebe();
    }
}

