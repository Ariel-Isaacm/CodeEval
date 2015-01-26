using System;

namespace SumOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int veces = 0;
            int veces2 = 0;
            int i = 0;
                while (veces2 <= 1001)
                {


                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            veces++;
                        }
                    }
                    if (veces <= 2)
                    {
                        suma += i;
                        veces2++;
                    }
                    veces = 0;
                    i++;
               }
            
            Console.WriteLine(suma-1);
            
        }
    }
}
