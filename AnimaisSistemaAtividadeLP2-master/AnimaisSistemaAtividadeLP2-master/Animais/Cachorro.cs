using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Cachorro : Mamifero
    {
        // Construtor
        public Cachorro(string nome, int idade) : base(nome, idade)
        {
        }

        // Método para emitir som específico de cachorro
        public override void EmitirSom()
        {
            Console.WriteLine("Au au!");
        }
    }
}
