using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, max, mult;

            Console.WriteLine("Digite o n°");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o n° múltiplo");
            mult = Convert.ToInt32(Console.ReadLine());

            for (i=mult;i<=max;i=i+max)
            {
                if (i% mult==0) 
                Console.WriteLine(i);
            }
        }
    }
}

