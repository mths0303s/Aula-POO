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
        private string nome_proprietário;

        public Livro(string nomeDoLivro, string NomeDoProprietário)
        {
            nome_livro = nomeDoLivro;
            nome_proprietário = NomeDoProprietário;

        }


        public void Abrir(ref string message)
        {
            message = ("O livro " + nome_livro + " do proprietário " + nome_proprietário + " foi aberto com exito!");
            Console.WriteLine(message);
        }

    }
}
