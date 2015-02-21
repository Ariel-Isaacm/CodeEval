using System;
using System.IO;

namespace CodeEval
{
    class Program
    {
        static void Main(string[] args)
        {


            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] palabras = line.Split(' ');
                    foreach (string item in palabras)
                    {
                        if ((int)item[0] > 96 && (int)item[0] < 123)
                        {
                            Console.Write((char)(item[0] - 32) + item.Substring(1) + " ");
                        }
                        else
                        {
                            Console.Write(item + " ");
                        }

                    }
                }                
        }
    }
}
