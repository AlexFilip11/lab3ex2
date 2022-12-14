using System;

namespace lab3ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrieti o functie care va determina daca un numar este sau nu numar prim.Apelati o si afisati i rezultatul
            Console.WriteLine("Introduceti un numar: ");
            int numar = int.Parse(Console.ReadLine());
            NumarPrim(numar);
        }
        static void NumarPrim(int numar)
        {
            for(int i=2; i<=numar; i++)
            {
                if(numar%i==0)
                {
                    if(numar!=i)
                    {
                        Console.WriteLine("Numarul nu este prim");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Numarul este prim");
                    }
                }
            }
        }
    }

}
