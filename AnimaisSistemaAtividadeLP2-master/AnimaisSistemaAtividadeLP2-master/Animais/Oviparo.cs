using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    // Subclasse Oviparo
    class Oviparo : Animal
    {
        // Construtor
        public Oviparo(string nome, int idade) : base(nome, idade)
        {
        }

        // Método para botar ovos
        public void BotarOvos()
        {
            Console.WriteLine("O ovíparo está botando ovos.");
        }
    }
}
