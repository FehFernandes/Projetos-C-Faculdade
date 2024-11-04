using System;

class Program
{
    static void Main(string[] args)
    {
      
        Console.WriteLine("Digite um numero");
        int numero = int.Parse(Console.ReadLine()); //numero a ser verificado
        int contador = 0; //contador de divisores

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                contador++;
            }
        }

        if (contador == 2)
        {
            Console.WriteLine("É primo");
        }
        else
        {
            Console.WriteLine("Não é primo");
        }

        //Reduzir o tempo

        bool primo = true;
        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
            {
                primo = false;
                break;
            }
        }

        if (primo)
        {
            Console.WriteLine("É primo");
        }
        else
        {
            Console.WriteLine("Não é primo");
        }



        Console.ReadKey();


        
    }
}