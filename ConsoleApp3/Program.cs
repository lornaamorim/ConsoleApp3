using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor litro do combustível: ");
             double n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a distância percorrida: ");
             double n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o consumo: ");
             double n3 = int.Parse(Console.ReadLine());

              double resultado = n1 / n2 * n3;
            Console.WriteLine("O gasto total da viagem foi " + resultado);


                Console.ReadKey();

        }
    }
}
