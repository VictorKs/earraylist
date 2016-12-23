using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DevMedia
{
    class EArrayList
    {
        static void Main(string[] args)
        {           
            ArrayList numeros = new ArrayList();
           
            Console.WriteLine("Insira um valor: ");
            numeros.Add(Console.ReadLine());

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine("\nDeseja Continuar? 1 - SIM  2 - NÃO ");
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("\nInsira um valor: ");
                    numeros.Add(Console.ReadLine());
                }              
            }
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine("Número na posição {0}, é {1}",i,numeros[i]);
            }
        }
    }
}
