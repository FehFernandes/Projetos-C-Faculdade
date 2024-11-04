

using System;

class Program
{
    static void Main(string[] args)
    {
        //Sequencia fibonaci
        int n = 10;
        int[] fib = new int[n]; 
        fib[0] = 0;
        fib[1] = 1;
        for (int i = 2; i < n; i++) 
        {
            fib[i] = fib[i - 1] + fib[i - 2]; 
        }
        //imprimir
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(fib[i]);
        }

        Console.ReadKey();

    }
}

