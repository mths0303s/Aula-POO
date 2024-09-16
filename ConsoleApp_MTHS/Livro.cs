using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MTHS
{
    internal class Livro
    {
        public string nome_livro;
        public int numero_paginas;
        private string autor_livro;
        private string nome_proprietário;

        public Livro(string nomeDoLivro, int numeroDePáginas, string autorDoLivro, string nomeDoProprietário)
        {
            nome_livro = nomeDoLivro;
            autor_livro = autorDoLivro;
            numero_paginas = numeroDePáginas;
            nome_proprietário = nomeDoProprietário;
        }


        public void Abrir(ref string message)
        {
            message = ("O livro " + nome_livro + ", que foi comprado pelo proprietário " + nome_proprietário + ", foi aberto com exito!");
            Console.WriteLine(message);
        }

        public void Descrição(ref string message)
        {
            message = ("O livro " + nome_livro + " do grande " + autor_livro + ", foi comprado pelo proprietário " + nome_proprietário + ", possui " + numero_paginas + " pg.");
            Console.WriteLine(message);
        }



    }
}
