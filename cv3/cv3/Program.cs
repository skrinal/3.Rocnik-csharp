int[] pole1 = new int[5];
int[] pole2 = new int[5];
int favcislo;

Console.WriteLine("Vitaj v progame na polia");
Console.WriteLine("Zadaj cisla pre 1 pole");

Console.WriteLine(); //medzera

//Zadavanie pole 1
for (int i = 0; i < 5; i++)
{
    Console.Write("Zadaj {0}. cislo: ", i + 1);
    pole1[i] = int.Parse(Console.ReadLine());
}


Console.WriteLine(); //medzera

//Zadavanie pole 2
Console.WriteLine("Zadaj cisla pre 2 pole");
for (int i = 0; i < 5; i++)
{
    Console.Write("Zadaj {0}. cislo: ", i + 1);
    pole2[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine(); //medzera

//index of() 
Console.Write("Zadaj svoje oblubene cislo: ");
favcislo = int.Parse(Console.ReadLine());
int pozicia = Array.IndexOf(pole1, favcislo); //hlada int/string na poli 1 ak najde output je pozicia, ak nenajde output -1
if (pozicia >= 0)
{
    //output pozicia je dany podla reversed pola 1
    Console.WriteLine("Cislo " + favcislo + " sa nachadza na " + (pozicia + 1) + ". mieste v poli 1");
}
else
{
    Console.WriteLine("Cislo " + favcislo + " sa nenachadza v poli 1");
}


int pozicia2 = Array.IndexOf(pole2, favcislo);
if (pozicia2 >= 0)
{
    //output pozicia je dany podla reversed pola 2
    Console.WriteLine("Cislo " + favcislo + " sa nachadza na " + (pozicia2 + 1) + ". mieste v poli 2");
}
else
{
    Console.WriteLine("Cislo " + favcislo + " sa nenachadza v poli 2");
}

Console.ReadKey(); // breakpoint
Console.WriteLine(); //medzera

//last indexof()
Console.WriteLine("last index of()");
int pozicia3 = Array.LastIndexOf(pole1, favcislo);
if (pozicia >= 0)
{
    //output pozicia je dany podla reversed pola 1
    Console.WriteLine("Posledny vyskyt cisla " + favcislo + " je na pozicii " + (pozicia3 + 1) + ". v poli 1");
}
else
{
    Console.WriteLine("Cislo " + favcislo + " sa nenachadza v poli 1");
}

int pozicia4 = Array.LastIndexOf(pole2, favcislo);
if (pozicia >= 0)
{
    Console.WriteLine("Posledny vyskyt cisla " + favcislo + " je na pozicii " + (pozicia4 + 1) + ". v poli 2");
}
else
{
    Console.WriteLine("Cislo " + favcislo + " sa nenachadza v poli 2");
}

Console.ReadKey(); // breakpoint
Console.WriteLine(); Console.WriteLine();//medzera

Console.WriteLine("Zoradenie cisiel od najmensieho po najvacsie");
//Zoradenie pre pole 1
Console.WriteLine("Pole 1:");
Array.Sort(pole1);
foreach (int i in pole1)
{
    Console.Write("{0} ", i);
}

Console.WriteLine(); Console.WriteLine(); //medzera

//Zoradenie pre pole 2
Console.WriteLine("Pole 2:");
Array.Sort(pole2);
foreach (int i in pole2)
{
    Console.Write("{0} ", i);
}

Console.ReadKey(); // breakpoint
Console.WriteLine(); Console.WriteLine(); //medzera


Console.WriteLine("Zoradenie cisiel od najvacsieho po najmensie");
Console.WriteLine("Pole 1:");
Array.Reverse(pole1);
foreach (int i in pole1)
{
    Console.Write("{0} ", i);
}

Console.WriteLine(); Console.WriteLine(); //medzera

Console.WriteLine("Pole 2:");
Array.Reverse(pole2);
foreach (int i in pole2)
{
    Console.Write("{0} ", i);
}

Console.ReadKey(); // breakpoint
Console.WriteLine(); Console.WriteLine(); //medzera


// copy()
int[] pole3 = new int[5];
Array.Copy(pole1, pole3, 5);
Console.WriteLine("Pouzitie copy()");
Console.WriteLine("Pole 3: ");
for (int i = 0; i < 5; i++)
{
    Console.Write(pole3[i] + " ");
}

Console.ReadKey(); // breakpoint
Console.WriteLine(); Console.WriteLine(); //medzera

//Length

Console.WriteLine("1 - Najvacsie cislo");
Console.WriteLine("2 - Najmensie cislo");
Console.WriteLine("3 - Priemerne cislo");
Console.WriteLine("4 - Sucet cisiel");
Console.Write("Co chces vediet z poli 1-3 ? : ");
int answer = int.Parse(Console.ReadLine());
Console.WriteLine();
switch (answer)
{
    case 1:
        Console.WriteLine("Najvacsie cislo v poli 1 = {0}", pole1.Max());
        Console.WriteLine("Najvacsie cislo v poli 2 = {0}", pole2.Max());
        Console.WriteLine("Najvacsie cislo v poli 3 = {0}", pole3.Max());
        break;
    case 2:
        Console.WriteLine("Najmensie cislo v poli 1 = {0}", pole1.Min());
        Console.WriteLine("Najmensie cislo v poli 2 = {0}", pole2.Min());
        Console.WriteLine("Najmensie cislo v poli 3 = {0}", pole3.Min());
        break;
    case 3:
        Console.WriteLine("Priemer v poli 1 = {0}", pole1.Average());
        Console.WriteLine("Priemer v poli 2 = {0}", pole2.Average());
        Console.WriteLine("Priemer v poli 3 = {0}", pole3.Average());
        break;
    case 4:
        Console.WriteLine("Sucet cisiel v poli 1 = {0}", pole1.Sum());
        Console.WriteLine("Sucet cisiel v poli 2 = {0}", pole2.Sum());
        Console.WriteLine("Sucet cisiel v poli 3 = {0}", pole3.Sum());
        break;
    default:
        Console.WriteLine("Neznami input");
        break;
}
Console.WriteLine(); //medzera


Console.ReadKey();
