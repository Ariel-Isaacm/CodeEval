using System;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    
                    string line = reader.ReadLine();
                    string[] numeros = line.Split(',');
                    int i = 0;
                    p P1 = new p(int.Parse(numeros[0]), int.Parse(numeros[1]));
                    p P2 = new p(int.Parse(numeros[2]), int.Parse(numeros[3]));
                    p P3 = new p(int.Parse(numeros[4]), int.Parse(numeros[5]));
                    p P4 = new p(int.Parse(numeros[6]), int.Parse(numeros[7]));

                    if (P2.y <= P3.y && P1.y >= P4.y && P2.x >= P3.x && P1.x <= P4.x)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                    
                }


        }

    }
    class p
    {
         public int x, y;
        public p(int x,int y)
        {
            this.x = x;
            this.y = y;

        }
    }
}
