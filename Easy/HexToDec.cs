using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros;
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {

                string line = reader.ReadLine();

                numeros = new int[line.Length];
                int numerico = 0;
                long valor = 0;
                for (int i = 0; i < line.Length; i++)
                {
                    if ((int)line[i] > 96 && (int)line[i] < 103)
                    {
                        numerico = convertToNum(line[i]);

                    }
                    else
                    {

                        numerico = int.Parse(line[i] + "");
                    }

                    valor += (long)(numerico * Math.Pow(16, (line.Length - i - 1)));
                }
                Console.WriteLine(valor);


            }
    }
    public static int convertToNum(char letter)
    {
        int num;
        switch (letter)
        {
            case 'a':
                num = 10;
                break;
            case 'b':
                num = 11;
                break;
            case 'c':
                num = 12;
                break;
            case 'd':
                num = 13;
                break;
            case 'e':
                num = 14;
                break;
            case 'f':
                num = 15;
                break;
            default:
                num = 0;
                break;
        }
        return num;
    }
}