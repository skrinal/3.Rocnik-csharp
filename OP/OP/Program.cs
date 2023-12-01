using System.Collections.Generic;
using System;

public class Ziak
{
    public string meno { get; set; }
    public string priezvisko { get; set; }
    public string trieda { get; set; }
    public int vek { get; set; }

    public void PovedzInfoOsebe(bool includeTrieda = true)
    {
        Console.WriteLine($"Moje meno je {meno} {priezvisko} a mam {vek} rokov.");
        if (includeTrieda != false)
        {
            Console.WriteLine($"Chodim do {trieda}.");
        }
    }
}
public class Ucitel : Ziak
{
    // inhrite zo Ziaka
    public string PK { get; set; }
    new public string Trieda { get; set; } // odstrani Trieda

    public new void PovedzInfoOsebe(bool includePK = true)
    {
        base.PovedzInfoOsebe(false); // berie cast z Public Ziak
        if (includePK != false) // neberie Console.WriteLine($"Chodim do {trieda}.");
        {
            Console.WriteLine($"Moje PK je {PK}.");
        }
    }
}
public class Vedenie : Ucitel
{
    public string sektor { get; set; }

    public new void PovedzInfoOsebe(bool includeSektor = true)
    {
        base.PovedzInfoOsebe(false); // Nebrie vetu "Moje PK je {PK}"
        if (includeSektor != false)
        {
            Console.WriteLine($"Moj sektor je {sektor}.");
        }
    }
}
public class Riaditel : Ucitel
{
    public string VUC { get; set; }

    public new void PovedzInfoOsebe()
    {
        base.PovedzInfoOsebe(false);  // neberie Console.WriteLine($"Moj sektor je {sektor}.");
        Console.WriteLine($"Moje VUC je {VUC}.");
    }
}


public class Program
{
    public static List<Ziak> Ziaci = new List<Ziak>();
    public static List<Ucitel> Ucitelia = new List<Ucitel>();
    public static List<Vedenie> Vedenia = new List<Vedenie>();

    public static void Privitanie()
    {
        Console.WriteLine("Vitaj u nas na skole !");
        Console.WriteLine();
    }

    public static void AddedToSystem<T>(T newPerson, List<T> personsList)
    {
        Console.WriteLine($"{typeof(T).Name} {GetPersonName(newPerson)} pridany do systemu");
        personsList.Add(newPerson);
    }

    public static string GetPersonName(object person)
    {
        if (person is Ziak ziak)
        {
            return $"{ziak.meno} {ziak.priezvisko}";
        }
        if (person is Ucitel ucitel)
        {
            return $"{ucitel.meno} {ucitel.priezvisko}";
        }
        if (person is Vedenie vedenie)
        {
            return $"{vedenie.meno} {vedenie.priezvisko}";
        }
        return "Unknown";
    }

    static void Main(string[] args)
    {
        //List<Ziak> Ziaci = new List<Ziak>(); // Pomohol internet 

        Ziaci.Add(new Ziak
        {
            meno = "Jozo",
            priezvisko = "Raz",
            vek = 17,
            trieda = "III.BI"
        });
        //Ziaci.Add(ziak1);

        Ziaci.Add(new Ziak
        {
            meno = "Nikolas",
            priezvisko = "Guznar",
            vek = 18,
            trieda = "II.AI"
        });
        //Ziaci.Add(ziak2);

        /*
        Ziak[] Ziaci = {        // pole ziaci - pouzite pred List-om  
                                // list je jednoduchsi na pridanie dialsich ziako/ucitelov etc.
            new Ziak {
                
            },
            new Ziak {
                
            }
        };
        */


        Ucitelia.Add(new Ucitel
        {
            meno = "Stefan",
            priezvisko = "Durco",
            vek = 41,
            PK = "Odborne"
        });


        Vedenia.Add(new Vedenie
        {
            meno = "Martin",
            priezvisko = "Cvincek",
            vek = 33,
            sektor = "Odborne"
        });

        Riaditel Milan = new Riaditel
        {
            meno = "Milan",
            priezvisko = "Valek",
            vek = 60,
            VUC = "ZSK" // neviem co napisat tu :D
        };


        Privitanie();


        bool whileA = true;
        while (whileA)
        {
            Console.WriteLine("1 - Prehlad Skoly");
            Console.WriteLine("2 - Pridat Osobu");
            Console.WriteLine("3 - Skoncit program");
            Console.Write("Co chces vediet / robit ? : ");
            int answer = int.Parse(Console.ReadLine());

            if (answer != 1 || answer != 2 || answer != 3)
            {
                // Clean
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            if (answer == 3)
            {
                whileA = false; // program breakpoint
            }

            Console.WriteLine();  // medzera

            switch (answer)
            {
                //Prehlad skoly
                case 1:
                    Console.WriteLine($"1 - Ziakci ({Ziaci.Count})");
                    Console.WriteLine($"2 - Ucitelia ({Ucitelia.Count})");
                    Console.WriteLine($"3 - Vedenia ({Vedenia.Count})");
                    Console.WriteLine($"4 - Riaditel");
                    Console.Write("Co chces vediet o nasej skole ? : ");
                    int answer1 = int.Parse(Console.ReadLine());

                    Console.WriteLine(); // Medzera

                    switch (answer1)
                    {
                        case 1:
                            foreach (var Ziak in Ziaci)
                            {
                                Ziak.PovedzInfoOsebe();
                            }

                            break;
                        case 2:
                            foreach (var Ucitel in Ucitelia)
                            {
                                Ucitel.PovedzInfoOsebe();
                            }
                            break;
                        case 3:
                            foreach (var Vedenie in Vedenia)
                            {
                                Vedenie.PovedzInfoOsebe();
                            }
                            break;
                        case 4:
                            Milan.PovedzInfoOsebe();
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                    Console.WriteLine();
                    Console.ReadKey();
                    break;

                // pridanie osoby
                case 2:
                    Console.WriteLine("(Ziak / Ucitel / Vedenie)");
                    Console.Write("Ake ma tato osoba postanie : ");
                    string answerS = Console.ReadLine();

                    Console.WriteLine(); // Medzera

                    switch (answerS)
                    {
                        case "Ziak":
                        case "ziak":
                            bool addZiak = true;

                            while (addZiak)
                            {
                                Console.Write("Meno ziaka: ");
                                string MenoZiaka = Console.ReadLine();

                                Ziak newZiak = new Ziak();

                                newZiak.meno = MenoZiaka; // uz zadane

                                Console.Write("Priezvisko: ");
                                newZiak.priezvisko = Console.ReadLine();

                                Console.Write("Vek: ");
                                newZiak.vek = int.Parse(Console.ReadLine());

                                Console.Write("Trieda: ");
                                newZiak.trieda = (Console.ReadLine());

                                // CTRL + C  CHATGPT   -  Meno premenej zada uzivatel
                                Dictionary<string, Ziak> ziakDictionary = new Dictionary<string, Ziak>();
                                ziakDictionary.Add(MenoZiaka, newZiak);
                                // CTRL + v  CHATGPT

                                Console.WriteLine(); // Medzera

                                AddedToSystem(newZiak, Ziaci);

                                Console.Write("Chces pridat este ziaka ? (y/n) : ");
                                addZiak = Console.ReadLine().ToUpper() == "Y";

                                Console.WriteLine(); // Medzera

                            }
                            break;

                        case "Ucitel":
                        case "ucitel":
                            bool addUcitel = true;
                            while (addUcitel)
                            {
                                Console.Write("Meno Ucitela: ");
                                string MenoUcitela = Console.ReadLine();

                                Ucitel newUcitel = new Ucitel();

                                newUcitel.meno = MenoUcitela; // uz zadane

                                Console.Write("Priezvisko: ");
                                newUcitel.priezvisko = Console.ReadLine();

                                Console.Write("Vek: ");
                                newUcitel.vek = int.Parse(Console.ReadLine());

                                Console.Write("PK: ");
                                newUcitel.PK = Console.ReadLine();


                                // CTRL + C  CHATGPT   -  Meno premenej zada uzivatel
                                Dictionary<string, Ucitel> ucitelDictionary = new Dictionary<string, Ucitel>();
                                ucitelDictionary.Add(MenoUcitela, newUcitel);
                                // CTRL + v  CHATGPT


                                Console.WriteLine(); // Medzera

                                AddedToSystem(newUcitel, Ucitelia);

                                Console.WriteLine("Chces pridat este ucitela ? (y/n)");
                                addUcitel = Console.ReadLine().ToUpper() == "Y";

                            }
                            break;

                        case "Vedenie":
                        case "vedenie":
                            bool addVedenie = true;
                            while (addVedenie)
                            {
                                Console.Write("Meno Vedenia: ");
                                string MenoVedenia = Console.ReadLine();

                                Vedenie newVedenie = new Vedenie();

                                newVedenie.meno = MenoVedenia; // uz zadane

                                Console.Write("Priezvisko: ");
                                newVedenie.priezvisko = Console.ReadLine();

                                Console.Write("Vek: ");
                                newVedenie.vek = int.Parse(Console.ReadLine());

                                Console.Write("Trieda: ");
                                newVedenie.trieda = Console.ReadLine();

                                Console.WriteLine("Sektor: ");
                                newVedenie.sektor = Console.ReadLine();

                                // CTRL + C  CHATGPT   -  Meno premenej zada uzivatel
                                Dictionary<string, Vedenie> vedenieDictionary = new Dictionary<string, Vedenie>();
                                vedenieDictionary.Add(MenoVedenia, newVedenie);
                                // CTRL + v  CHATGPT

                                Console.WriteLine(); // Medzera

                                AddedToSystem(newVedenie, Vedenia);

                                Console.Write("Chces pridat este vedenie ? (y/n) : ");
                                addVedenie = Console.ReadLine().ToUpper() == "Y";

                                Console.WriteLine(); // Medzera
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                    break;
            }
        }
    }
}
