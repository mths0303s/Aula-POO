using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MTHS
{
    internal class Carro
    {
        private string nome;

        public Carro(string nomeDoCarro)
        {
            nome = nomeDoCarro;
        }

        public void Acelerar()
        {
            Console.WriteLine("Olá, sou " + nome + " e estou acelerando!");
        }

        public void Trilha()
        {
            Console.WriteLine("Olá, sou " + nome + " e sou um carro de trilha");
        }

    }
}