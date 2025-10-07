using System;
class Zadanie2
{
    public static void Uruchom()
    {
        try
        {
            Console.Write(" Podaj liczbę: ");
            double x = double.Parse(Console.ReadLine());
            if (x < 0)
                throw new ArgumentException("Liczba nie może być ujemna!");
            Console.WriteLine(" Pierwiastek: " + Math.Sqrt(x));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Błąd: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Wprowadzono nieprawidłową wartość!");
        }
    }
}
