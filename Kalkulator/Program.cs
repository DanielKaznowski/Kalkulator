using System;

class Kalkulator
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nKALKULATOR");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Różnica");
            Console.WriteLine("3. Iloczyn");
            Console.WriteLine("4. Iloraz");
            Console.WriteLine("5. Potęga");
            Console.WriteLine("6. Pierwiastek kwadratowy");
            Console.WriteLine("7. Funkcja Sin");
            Console.WriteLine("8. Funkcja Cos");
            Console.WriteLine("9. Funkcja Tan");
            Console.WriteLine("10. Wyjście");
            Console.Write("Wybierz opcję: ");
            int wybor = Convert.ToInt32(Console.ReadLine());

            switch (wybor)
            {
                case 1:
                    Console.Write("Podaj pierwszą liczbę: ");
                    double liczba1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    double liczba2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Suma: " + (liczba1 + liczba2));
                    break;

                case 2:
                    Console.Write("Podaj pierwszą liczbę: ");
                    liczba1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    liczba2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Różnica: " + (liczba1 - liczba2));
                    break;

                case 3:
                    Console.Write("Podaj pierwszą liczbę: ");
                    liczba1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    liczba2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Iloczyn: " + (liczba1 * liczba2));
                    break;

                case 4:
                    Console.Write("Podaj pierwszą liczbę: ");
                    liczba1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    liczba2 = Convert.ToDouble(Console.ReadLine());
                    if (liczba2 != 0)
                    {
                        Console.WriteLine("Iloraz: " + (liczba1 / liczba2));
                    }
                    else
                    {
                        Console.WriteLine("Błąd: nie można dzielić przez zero.");
                    }
                    break;

                case 5:
                    Console.Write("Podaj podstawę: ");
                    liczba1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj wykładnik: ");
                    liczba2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Potęga: " + Math.Pow(liczba1, liczba2));
                    break;

                case 6:
                    Console.Write("Podaj liczbę: ");
                    liczba1 = Convert.ToDouble(Console.ReadLine());
                    if (liczba1 >= 0)
                    {
                        Console.WriteLine("Pierwiastek kwadratowy: " + Math.Sqrt(liczba1));
                    }
                    else
                    {
                        Console.WriteLine("Błąd: pierwiastek kwadratowy z liczby ujemnej jest niemożliwy.");
                    }
                    break;

                case 7:
                    Console.Write("Podaj kąt w radianach: ");
                    double kat = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Sin: " + Math.Sin(kat));
                    break;

                case 8:
                    Console.Write("Podaj kąt w radianach: ");
                    kat = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Cos: " + Math.Cos(kat));
                    break;

                case 9:
                    Console.Write("Podaj kąt w radianach: ");
                    kat = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Tan: " + Math.Tan(kat));
                    break;

                case 10:
                    running = false;
                    Console.WriteLine("Zamykanie programu...");
                    break;

                default:
                    Console.WriteLine("Błędna opcja. Spróbuj ponownie.");
                    break;
            }
        }
    }
}
