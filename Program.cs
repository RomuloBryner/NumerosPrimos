using System;
using System.Collections.Generic;
using System.Linq;

namespace NumerosPri
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese el numero ");
            num = Int32.Parse(Console.ReadLine());

            int NumPrim(int agua)
            {
                int cont = 0;    
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        cont = cont + 1;
                    }

                }
                if (cont > 2)
                {
                    Console.WriteLine("El numero {0} no es primo ", num);
                }
                else
                {
                    Console.WriteLine("El numero {0} es primo ", num);
                }
                return agua;
            }

            Func<int, int> a = (b) =>
            {
                NumPrim(b);
                return b;
            };

            int Primos = a(num);
                                
            Console.ReadKey();
        }
    }
}
