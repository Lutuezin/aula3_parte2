using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3_parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, d, e, z, x;

            Console.WriteLine("Digite o valor do primeiro produto:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo produto:");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do terceiro produto:");
            c = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do quarto produto:");
            d = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do quinto produto:");
            e = float.Parse(Console.ReadLine());
            
           
            z = a + b + c + d + e;
            Console.WriteLine("Valor total dos produtos: " + String.Format("{0:C2}", z));
            Console.WriteLine("Preço pago pelo cliente: ");
            x = float.Parse(Console.ReadLine());
               if ( z == x )
            {
                Console.WriteLine("Não precisa de troco");
            }
            
               else if ( z != x )
            {
                float troco = x - z;
                Console.WriteLine("Troco: " + String.Format("{0:C2}", troco));
            }

          Console.ReadKey();
        }
    }
}
