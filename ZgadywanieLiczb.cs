Random random = new Random();
int wylosowanaLiczba = random.Next(1, 101);
int liczba;

do
{
    Console.Write("Zgadnij liczbę od 1 do 100: ");
    liczba = int.Parse(Console.ReadLine());

    if (liczba < wylosowanaLiczba)
    {
        Console.WriteLine("Za mało!");
    }
    else if (liczba > wylosowanaLiczba)
    {
        Console.WriteLine("Za dużo!");
    }
    else
    {
        Console.WriteLine("Brawo! Zgadłeś!");
    }

} while (liczba != wylosowanaLiczba);
