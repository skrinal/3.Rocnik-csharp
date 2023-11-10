
public class Ziak
{
    public string meno { get; set; }
    public string priezvisko { get; set; }
    public int vek { get; set; }
    private string trieda { get; set; }

    public void PovedzInfoOsebe()
    {
        Console.WriteLine("Moje meno je: " + meno + " " + priezvisko);
        Console.WriteLine("Moj vek je: " + vek);
        Console.WriteLine("Trieda: " + trieda);
    }
}

public class Ucitel : Ziak
{
    public string PK { get; set; }
}

public class Vedenie : Ucitel
{
    private string sektor;
}

public class Riaditel : Ucitel
{
    private string VUC;
}

public class program
{
    

    static void Main(string[] args)
    {
        Ziak Matej = new Ziak();
        Matej.meno = "Matej";
        Matej.priezvisko = "Hruska";
        Matej.vek = 15;
        Matej.trieda = "III.BI";

        Ucitel jano = new Ucitel();
        jano.meno = "Jano";
        jano.priezvisko = "Jablko";
        jano.vek = 32;
        jano.PK = "odborne";


    
    }
}