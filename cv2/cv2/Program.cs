Console.Write("Zadajte cislo ktoreho chcete malu nasobilku: ");
int cislo = int.Parse(Console.ReadLine());

for (int i = 1; i < 11; i++)
{
    Console.Write(cislo * i);
    Console.Write(" ");

}

Console.WriteLine(); 
Console.WriteLine();

Console.WriteLine("Mala nasobilka pomocou cyklu:");
for (int i = 1; i < 11; i++)
{
    for(int x = 1; x < 11; x++)
    {
        Console.Write(x * i); 
        Console.Write(" ");
    }
    Console.WriteLine();
}
Console.ReadKey();


