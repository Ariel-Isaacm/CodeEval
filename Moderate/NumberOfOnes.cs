using System;
using System.IO;

namespace NumberOfOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            string bina = null;
            string line;
            using (StreamReader reader = File.OpenText(args[0]))
            
            while (!reader.EndOfStream)
            {
            line = reader.ReadLine();
            bina = Convert.ToString(int.Parse(line), 2);
            contador = 0;
            for (int i = 0; i < bina.Length; i++)
            {
                if (bina[i]=='1')
                {
                    contador++;
                }
            }
            Console.WriteLine(contador);
        }
        }
    }
}
