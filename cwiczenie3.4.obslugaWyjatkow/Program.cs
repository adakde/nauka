using System;


//Cwiczenie pokazujące obsługę wyjątków
namespace Cwiczenie4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Wprowadź pierwszą liczbę zakres od 0 do 255:");
            try
            {
                byte a = byte.Parse(Console.ReadLine());
                Console.WriteLine("Wprowadź drugą liczbę:");
                byte b = byte.Parse(Console.ReadLine());

                Console.WriteLine("Wynik dzielenia pierwszej liczby przez drugą zakres od 0 do 255:  " + (a / b));
            }
            //Eliminacja błedu FormatException np. typ string.
            catch (FormatException)
            {
                Console.WriteLine("Wprowadzona wartość nie jest liczbą całkowitą.");
            }
            //Eliminacja błedu OverflowException. Wartość większa niż 255 albo niższa niz 0.
            catch (OverflowException)
            {
                Console.WriteLine("Wprowadzona wartość jest poza zakresem typu byte.");
            }
            //Eliminacja błedu DivideByZeroException/Dzielenie przez 0.
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nie można dzielić przez zero.");
            }
            //Nie oczekiwany błąd
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił nieoczekiwany błąd: " + ex.Message);
            }
        }
    }
}