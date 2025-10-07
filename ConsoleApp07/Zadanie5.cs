using System;
class Zadanie5
{
    public static void Uruchom()
    {
        try
        {
            Console.Write( "Podaj liczbę: ");
            int liczba = int.Parse(Console.ReadLine());
            Console.WriteLine($" Wpisałeś: {liczba} ");
        }
        catch (FormatException)
        {
            Console.WriteLine("Niepoprawna wartość! Spróbuj jeszcze raz.");
        try
          {
             Console.Write(" Podaj liczbę ponownie: ");
             int liczba2 = int.Parse(Console.ReadLine());
             Console.WriteLine($" Teraz się udało: {liczba2} ");
          }
        catch (FormatException)
         {
            Console.WriteLine("Znowu błąd! Koniec programu.");
         }
        }
    }}
