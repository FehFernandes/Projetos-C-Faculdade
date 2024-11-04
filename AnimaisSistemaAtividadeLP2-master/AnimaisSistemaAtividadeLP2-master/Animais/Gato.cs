using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Gato : Mamifero
    {
        // Construtor
        public Gato(string nome, int idade) : base(nome, idade)
        {
        }

        // Método para emitir som específico de gato
        public override void EmitirSom()
        {
            Console.WriteLine("Miau!");
        }
    }
}
