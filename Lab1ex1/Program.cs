using System;

namespace Lab1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
               paralelipiped dreptunghic, va afisa volumul lui */

            Console.WriteLine("Introduceti latura 1 a paralelipipedului dreptunghic: ");
            int latura1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti latura 2 a paralelipipedului dreptunghic: ");
            int latura2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti latura 3 a paralelipipedului dreptunghic: ");
            int latura3 = int.Parse(Console.ReadLine());

            int volum = latura1 * latura2 * latura3;
            Console.WriteLine("Volumul paralelipipedului dreptunghic este: " + volum);


        }
    }
}
