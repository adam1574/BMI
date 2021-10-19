using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
       {
            double vaha;
            double vyska;
            double vypocet;
            while (true)

            {
                Console.Clear();
                Console.WriteLine("Vypočet BMI!!");
                Console.WriteLine("_______________");

                Console.Write("zadej vahu (kg): ");
                double.TryParse(Console.ReadLine(), out vaha);

                if (vaha <= 30)
                {
                    Console.WriteLine();
                    Console.WriteLine("jenom čísla nad 30 platí!!");
                }
                else
                {
                    Console.Write("zadej výšku (m): ");
                    double.TryParse(Console.ReadLine(), out vyska);

                    if (vyska <= 100)
                    {
                        Console.WriteLine();
                        Console.WriteLine("jenom čísla nad 100 platí!!");

                    }
                    else
                    {
                        vypocet = (vaha) / ((vyska / 100)*(vyska / 100));
                        Console.WriteLine();
                        Console.WriteLine($"tvoje BMI je {vypocet}");


                    }
                }
                Console.ReadLine();
            }
            

            
        }
    }
}
