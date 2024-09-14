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
            Carro mercedes = new Carro();
            mercedes.nome = "SLK";

            mercedes.Acelerar();

            Carro Jeep = new Carro();
            Jeep.nome = "Renage";

            Jeep.Trilha();
            Console.ReadKey();
        }
    }
}
