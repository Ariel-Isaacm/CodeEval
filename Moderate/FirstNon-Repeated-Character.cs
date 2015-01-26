using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace FIRST_NON_REPEATED_CHARACTER
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList NoRepetidos = new ArrayList();
            ArrayList Repetidos = new ArrayList();
            using (StreamReader reader = File.OpenText("C:/Users/Ariel/Desktop/texto.txt"))
                while (!reader.EndOfStream)
                {
                    
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                    foreach (char item in line)
                    {
                        if (!NoRepetidos.Contains(item)&& !Repetidos.Contains(item))
                        {
                            NoRepetidos.Add(item);
                        }
                        else
                        {
                            NoRepetidos.Remove(item);
                            Repetidos.Add(item);
                        }
                    }
                    foreach (var item in NoRepetidos)
                    {
                        Console.WriteLine(item);
                        break;
                    }
                    
                    NoRepetidos.Clear();
                    Repetidos.Clear();
                }
            Console.ReadKey();
        }
    }
}
