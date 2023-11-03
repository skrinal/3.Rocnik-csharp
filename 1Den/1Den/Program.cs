Console.WriteLine("Vitaj v nasej kalkulacke");
int i = 0;
while (i == 0 ) { 
Console.WriteLine("Zadaj prve cislo: ");
float a = float.Parse(Console.ReadLine());

Console.WriteLine("Zadaj druhe cislo: ");
float b = float.Parse(Console.ReadLine());

Console.WriteLine("Zvolte si operaciu");
Console.WriteLine("1. - scitanie");
Console.WriteLine("2. - odcitanie");
Console.WriteLine("3. - nasobenie");
Console.WriteLine("4. - delenie");

int volba = int.Parse(Console.ReadLine());
float vysledok = 0;

switch (volba)
{
    case 1:
        vysledok = a + b;
        break;
    case 2:
        vysledok = a - b;
        break;
    case 3:
        vysledok = a * b;
        break;
    case 4:
        vysledok = a / b;
        break;
}

if ((volba > 0) && (volba < 5))
{
 Console.WriteLine("Vysledok: {0}", vysledok);
}

else
 {
  Console.WriteLine("Neplatna volba");
 }
   
    Console.WriteLine("Chces pokracovat v pocitani ? (1/0)");
    int odpoved = int.Parse(Console.ReadLine());
    if (odpoved == 0)
    {
        i++;
    }


}


Console.WriteLine("Dakujem za pouzitie kalkulacky, aplikaciu ukoncie stlacenim tlacitka");
Console.ReadKey();