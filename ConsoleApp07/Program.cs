using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine(" MENU ");
            Console.WriteLine(" 1 - Dzielenie z obsługą błędów ");
            Console.WriteLine(" 2 - Własny wyjątek ");
            Console.WriteLine(" 3 - Otwieranie pliku ");
            Console.WriteLine(" 4 - Symulacja aplikacji ");
            Console.WriteLine(" 5 - Zagnieżdżone try-catch ");
            Console.WriteLine(" 0 - Wyjście ");
            Console.Write(" Wybierz zadanie: ");

            string wybor = Console.ReadLine();
            Console.WriteLine();
              switch (wybor)
            {
                case "1": Zadanie1.Uruchom(); break;
                case "2": Zadanie2.Uruchom(); break;
                case "3": Zadanie3.Uruchom(); break;
                case "4": Zadanie4.Uruchom(); break;
                case "5": Zadanie5.Uruchom(); break;
                case "0": return;
                default: Console.WriteLine(" Niepoprawny wybór! "); break;
            }
        }
    }}
