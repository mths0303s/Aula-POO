using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MTHS
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagem = "Mensagem Teste";
            Carro mercedes = new Carro("SLK");
            mercedes.Acelerar(ref mensagem);

            Console.WriteLine(mensagem);

            Carro Jeep = new Carro("Renage");
            Jeep.Trilha();

            string message = "Void";
            Livro SenhorDosAnéis = new Livro("Senhor dos anéis", 1527, "John Ronald Reuel Tolkien", "Matheus Araújo");
            SenhorDosAnéis.Abrir(message: ref message);
            SenhorDosAnéis.Descrição(message: ref message);

            Console.ReadKey();
        }
    }
}
