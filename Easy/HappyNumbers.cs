using System;
using System.IO;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {

        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string happy_Number = reader.ReadLine();
                if (null == happy_Number)
                {
                    continue;

                }
                ArrayList historial = new ArrayList();

                int resultado = 0;
                int aux = 0;
                do
                {
                    for (int i = 0; i < happy_Number.Length; i++)
                    {
                        aux = int.Parse(happy_Number[i].ToString());
                        resultado = resultado + (aux * aux);

                    }
                    
                    if (resultado == 1)
                    {
                        Console.WriteLine(1);
                        break;
                    }
                    else
                    {
                        if (!historial.Contains(resultado))
                        {
                            historial.Add(resultado);
                        }
                        else
                        {
                            Console.WriteLine(0);
                            break;
                        }
                    }
                    happy_Number = resultado.ToString();
                    resultado = 0;

                } while (true);

                

            }
        Console.ReadKey();
    }
}