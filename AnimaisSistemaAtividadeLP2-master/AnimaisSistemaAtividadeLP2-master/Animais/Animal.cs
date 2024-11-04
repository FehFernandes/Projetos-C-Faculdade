using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Animal
    {
        // Propriedades
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Construtor
        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Método para emitir som do animal
        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal emitiu um som.");
        }
    }

}
