using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palhacoo
{
    public class Palhaco
    {
        // Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public string Sexo { get; set; }

        // Construtor
        public Palhaco(string nome, int idade, double altura, double peso, string sexo)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
            Peso = peso;
            Sexo = sexo;
        }
    }
}
