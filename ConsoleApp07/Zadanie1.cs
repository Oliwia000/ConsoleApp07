using System;

class Zadanie1
{
    public static void Uruchom()
    {
        try
        {
            Console.Write(" Podaj pierwszą liczbę: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write(" Podaj drugą liczbę: ");
            double b = double.Parse(Console.ReadLine());

            double wynik = a / b;
            Console.WriteLine($" Wynik dzielenia: {wynik} ");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Nie można dzielić przez zero!");
        }
        catch (FormatException)
        {
            Console.WriteLine("To nie jest liczba!");
        }
    }
}
