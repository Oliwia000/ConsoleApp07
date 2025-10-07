using System;
using System.IO;
class Zadanie3
{
    public static void Uruchom()
    {
        try
        {
            FileStream plik = new FileStream("dane.txt", FileMode.Open);
            Console.WriteLine(" Plik został otwarty! ");
            plik.Close();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine(" Plik nie istnieje! ");
        }
        finally
        {
            Console.WriteLine("Zamykam zasoby...");
        }
    }
}

