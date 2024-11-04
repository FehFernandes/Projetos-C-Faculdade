using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Mamifero : Animal
    {
        // Construtor
        public Mamifero(string nome, int idade) : base(nome, idade)
        {
        }

        // Método para amamentar
        public void Amamentar()
        {
            Console.WriteLine("O mamífero está amamentando.");
        }
    }

}
