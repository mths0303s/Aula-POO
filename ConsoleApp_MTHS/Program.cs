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
            Carro mercedes = new Carro("SLK");
            mercedes.Acelerar();

            Carro Jeep = new Carro("Renage");
            Jeep.Trilha();

            Console.ReadKey();
        }
    }
}
