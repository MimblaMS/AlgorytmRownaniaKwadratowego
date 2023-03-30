using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmRównaniaKwadratowego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;

            Console.WriteLine("Program oblicza pierwiastki rówania ax^2+bx+c = 0.");
            Console.WriteLine("Podaj a."); //Użytkownik wprowadza wartość a
            a = double.Parse(Console.ReadLine());

            if (a == 0) //Jeśli a równa się zero, wartość jest niepoprawna; wyświetlamy odpowiedni komunikat
            {
                Console.WriteLine("Niedozwolona wartość współczynnika a.");
            }
            else
            {
                Console.WriteLine("Podaj b."); //Użytkownik wprowadza wartość b
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj c."); //Użytkownik wprowadza wartość c
                c = double.Parse(Console.ReadLine());

                delta = b * b - 4 * a * c; //Program oblicza deltę

                if (delta < 0) //Jeśli delta jest mniejsza niż 0; BRAK PIERWIASTKÓW RZECZYWISTYCH
                {
                    Console.WriteLine();
                    Console.Write("Dla ");
                    Console.Write("a = {0}, ", a);
                    Console.Write("b = {0}, ", b);
                    Console.Write("c = {0}, ", c);
                    Console.Write("brak pierwiastków rzeczywistych.");
                }
                else
                {
                    if (delta == 0) //Jeśli delta równa się 0; JEDEN PIERWIASTEK
                    {
                        x1 = -b / (2 * a); //Program oblicza x1
                        Console.WriteLine();
                        Console.Write("Dla ");
                        Console.Write("a = {0}, ", a);
                        Console.Write("b = {0}, ", b);
                        Console.Write("c = {0}, ", c);
                        Console.Write("trójmian ma jeden pierwiastek podwójny x1 = {0:##.##}.", x1); //Wstawiona zostanie we wskazanym miejscu wartość x1
                    }
                    else //Instrukcja wywołana gdy delta jest większa niż 0
                    {
                        x1 = (-b - Math.Sqrt(delta)) / (2 * a); //Program oblicza x1
                        x2 = (-b + Math.Sqrt(delta)) / (2 * a); //Program oblicza x2
                        Console.WriteLine();
                        Console.Write("Dla ");
                        Console.Write("a = {0}, ", a);
                        Console.Write("b = {0}, ", b);
                        Console.Write("c = {0}, ", c);
                        Console.Write("trójmian ma dwa pierwiastki podwójne x1 = {0:##.##}, x2 = {1:##.##}.", x1, x2); //Wstawione zostaną we wskazanym miejscu wartości x1, x2
                    }

                }
            }
            Console.WriteLine();
            Console.Write("Naciśnij ENTER");
            Console.ReadLine();
        }
    }
}
