Console.Write("Podaj imie: ");
String imie = Console.ReadLine();
int pierwszaOcena;
int drugaOcena;
int trzeciaOcena;

do
{
    Console.Write("Podaj pierwszą ocenę: ");
    pierwszaOcena = int.Parse(Console.ReadLine());
} while (pierwszaOcena < 1 || pierwszaOcena > 6);

do
{
    Console.Write("Podaj drugą ocenę: ");
    drugaOcena = int.Parse(Console.ReadLine());
} while (drugaOcena < 1 || drugaOcena > 6);

do
{
    Console.Write("Podaj trzecią ocenę: ");
    trzeciaOcena = int.Parse(Console.ReadLine());
} while (trzeciaOcena < 1 || trzeciaOcena > 6);

double suma = pierwszaOcena + drugaOcena + trzeciaOcena;
double srednia = suma/3; 

Console.WriteLine($"{imie}, Twoja średnia to: {Math.Round(srednia, 2)}");

if (srednia >= 3.00)
{
    Console.WriteLine("Zaliczone!");
}
else if (srednia < 3.00)
{
    Console.WriteLine("Niezaliczone");
}