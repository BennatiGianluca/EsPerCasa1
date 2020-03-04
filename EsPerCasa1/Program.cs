using System;

namespace EsPerCasa1
{
    class Program
    {
        
        static void Main(string[] args)
        {int n;
            do
            {
                Console.WriteLine("inserisci un numero");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0);
            if (n % 2 == 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i.ToString() + " ");
                    }
                }
            }
            else
            {
                for(int i = 1; i <= n; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(i.ToString() + " ");
                    }
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
