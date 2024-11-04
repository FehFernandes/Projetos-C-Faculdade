using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Galinha : Oviparo
    {
        // Construtor
        public Galinha(string nome, int idade) : base(nome, idade)
        {
        }

        // Método para emitir som específico de galinha
        public override void EmitirSom()
        {
            Console.WriteLine("Có có có!");
        }
    }
}
