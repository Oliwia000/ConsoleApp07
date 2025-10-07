using System;
class Zadanie4
{
    public static void Uruchom()
    {
        Random r = new Random();
        try
        {
            Console.WriteLine(" Uruchamiam aplikację. ");
            if (r.Next(0, 2) == 0)
                throw new InvalidOperationException("Wystąpił losowy błąd!");
            Console.WriteLine(" Aplikacja działa poprawnie! ");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(" Błąd: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Zamykanie aplikacji...");
        }
    }
}
