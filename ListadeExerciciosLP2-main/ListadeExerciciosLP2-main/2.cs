using System;

class Program
{
    static void Main(string[] args)
    {
        //pedir o usuario a palavra
        Console.WriteLine("Digite uma palavra");
        string palavra = Console.ReadLine();
        
        string palavraInvertida = "";
        for (int i = palavra.Length - 1; i >= 0; i--)
        {
            palavraInvertida += palavra[i];
        }

        if (palavra == palavraInvertida)
        {
            Console.WriteLine("É palidromo");
        }
        else
        {
            Console.WriteLine("Não é palidromo");
        }
        Console.ReadKey();
        
    }
}