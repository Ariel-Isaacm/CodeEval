using System.IO;
using System;
using System.Collections;

namespace UniqueElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            string[] numeros;
            ArrayList final;
            string salida;
            using (StreamReader reader = File.OpenText("C:/Users/Admin/Desktop/texto.txt"))
            
                while (!reader.EndOfStream)
                {
                    salida = null;
                    final = new ArrayList();
                    line = reader.ReadLine();
                    numeros=line.Split(',');
                    
                    foreach (var item in numeros)
                    {
                        if (!final.Contains(item))
                        {
                            final.Add(item);
                        }
                    }
                    foreach (var item in final)
                    {
                        salida += item+",";
                        
                    }

                    Console.WriteLine(salida.Substring(0,salida.Length-1));
                }
            Console.ReadKey();
            
        }
    }
}
