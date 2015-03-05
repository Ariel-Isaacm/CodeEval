using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodEval
{
    class Program
    {
        public static string[] cero = new string[ 6];
        public static string[] uno = new string[ 6];
        public static string[] dos = new string[ 6];
        public static string[] tres = new string[ 6];
        public static string[] cuatro = new string[ 6];
        public static string[] cinco = new string[ 6];
        public static string[] seis = new string[ 6];
        public static string[] siete = new string[ 6];
        public static string[] ocho = new string[ 6];
        public static string[] nueve = new string[ 6];


        static void Main(string[] args)
        {

            declarar();
            
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string[,] finalOutput = new string[1, 6];
                    int aux;
                    string line = reader.ReadLine();
                    for (int i = 0; i < line.Length; i++)
                    {
                        try
                        {
                            aux = int.Parse(line[i] + "");
                            switch (aux)
                            {
                                case 0:
                                    for (int j = 0; j < 6; j++)
                                    {
                                        finalOutput[0, j] += cero[j];
                                    }
                                    break;
                                case 1:
                                    for (int j = 0; j < 6; j++)
                                    {
                                        finalOutput[0, j] += uno[j] ;
                                    }
                                    break;
                                case 2:
                                    for (int j = 0; j < 6; j++)
                                    {
                                        finalOutput[0, j] += dos[j] ;
                                    }
                                    break;
                                case 3:
                                    for (int j = 0; j < 6; j++)
                                    {
                                        finalOutput[0, j] += tres[j];
                                    }
                                    break;
                                case 4:
                                    for (int j = 0; j < 6; j++)
                                    {
                                        finalOutput[0, j] += cuatro[j];
                                    }
                                    break;
                                case 5:
                                    for (int j = 0; j < 6; j++)
                                    {
                                        finalOutput[0, j] += cinco[j] ;
                                    }
                                    break;
                                case 6:
                                    for (int j = 0; j < 6; j++)
                                    {
                                        finalOutput[0, j] += seis[j] ;
                                    }
                                    break;
                                case 7:
                                    for (int j = 0; j < 6; j++)
                                    {
                                        finalOutput[0, j] += siete[j] ;
                                    }
                                    break;
                                case 8:
                                    for (int j = 0; j < 6; j++)
                                    {
                                        finalOutput[0, j] += ocho[j] ;
                                    }
                                    break;
                                case 9:
                                    for (int j = 0; j < 6; j++)
                                    {
                                        finalOutput[0, j] += nueve[j];
                                    }
                                    break;

                                default:
                                    break;
                            }
                        }
                        catch (Exception e)
                        {

                        }
                    }
                    for (int i = 0; i < 6; i++)
                    {
                        
                        Console.WriteLine(finalOutput[0, i]);
                    }

                }
        }
        public static void declarar()
        {

            // para 0
            cero[0] = "-**--";
            cero[1] = "*--*-";
            cero[2] = "*--*-";
            cero[3] = "*--*-";
            cero[4] = "-**--";
            cero[5] = "----";

            uno[0] = "--*--";
            uno[1] = "-**--";
            uno[2] = "--*--";
            uno[3] = "--*--";
            uno[4] = "-***-";
            uno[5] = "-----";

            dos[0] = "***--";
            dos[1] = "---*-";
            dos[2] = "-**--";
            dos[3] = "*----";
            dos[4] = "****-";
            dos[5] = "-----";
            
            tres[0] = "***--";
            tres[1] = "---*-";
            tres[2] = "-**--";
            tres[3] = "---*-";
            tres[4] = "***--";
            tres[5] = "-----";
           
            cuatro[0] = "-*---";
            cuatro[1] = "*--*-";
            cuatro[2] = "****-";
            cuatro[3] = "---*-";
            cuatro[4] = "---*-";
            cuatro[5] = "-----";

            cinco[0] = "****-";
            cinco[1] = "*----";
            cinco[2] = "***--";
            cinco[3] = "---*-";
            cinco[4] = "***--";
            cinco[5] = "-----";
           
            seis[0] = "-**--";
            seis[1] = "*----";
            seis[2] = "***--";
            seis[3] = "*--*-";
            seis[4] = "-**--";
            seis[5] = "-----";

            siete[0] = "****-";
            siete[1] = "---*-";
            siete[2] = "--*--";
            siete[3] = "-*---";
            siete[4] = "-*---";
            siete[5] = "-----";
            
            ocho[0] = "-**--";
            ocho[1] = "*--*-";
            ocho[2] = "-**--";
            ocho[3] = "*--*-";
            ocho[4] = "-**--";
            ocho[5] = "-----";

            nueve[0] = "-**--";
            nueve[1] = "*--*-";
            nueve[2] = "-***-";
            nueve[3] = "---*-";
            nueve[4] = "-**--";
            nueve[5] = "-----";

        }
    }
}