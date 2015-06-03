using System;
using System.IO;

namespace SwapCase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string nuevo = "";
                    foreach (char item in line)
                    {
                        if ((int)item > 64 && (int)item < 91)
                        {
                            nuevo += (char)(item + 32);
                            continue;
                        }
                        if ((int)item > 96 && (int)item < 123)
                        {
                            nuevo += (char)(item - 32);

                        }
                        else
                        {
                            nuevo += item;
                        }
                    }
                    Console.WriteLine(nuevo);
                }
        }
    }
}
