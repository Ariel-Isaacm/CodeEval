using System;
using System.IO;


namespace Spiral
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            
            using (StreamReader reader = File.OpenText(args[0]))
            
                while (!reader.EndOfStream)
                {
                    Boolean derecha = true, abajo = false, izquierda = false, arriba = false;
                    string[,] arreglo;
                    int maxx = 0, maxy = 0;
                    
                    int i = 0;
                    string line = reader.ReadLine();
                    string[] comandos = line.Split(';');
                    maxy = int.Parse(comandos[0]);
                    maxx = int.Parse(comandos[1]);
                    arreglo = null;
                    arreglo=new string[maxx,maxy];
                    Boolean[,] checar = new Boolean[maxx, maxy];
                    string[] numeros=comandos[2].Split(' ');
                    for (int m = 0; m < maxy; m++)
                    {
                        for (int j = 0; j < maxx; j++)
                        {
                            arreglo[j, m] = numeros[i];
                            checar[j, m] = false;
                            i++;
                        }
                    
                    }
                    i = 0;
                    int x = 0, y = 0;
                    do{
                        Console.Write(arreglo[x, y] + " ");
                        checar[x, y] = true;
                        //Console.WriteLine(arreglo[x,y]+" "+x+" "+y);
                        i++;
                        if (i == maxx * maxy)
                        {
                            break;
                        }
                        if (derecha)
                        {
                            
                            if (((x + 1) == maxx) || checar[x+1, y])
                            {
                                
                                derecha = false;
                                abajo = true;
                                y++;
                                continue;
                            }
                            else
                            {
                                x++;

                                continue;
                            }
                        }
                        if (abajo)
                        {
                            
                            if (((y + 1) == maxy) || checar[x, y+1])
                            {
                                abajo = false;
                                izquierda = true;
                                x--;
                                continue;
                            }
                            else
                            {
                                y++;
                                continue;
                            }
                        }
                        if (izquierda)
                        {
                            if (((x) == 0) || checar[x-1, y])
                            {

                                izquierda = false;
                                arriba = true;
                                y--;
                                continue;
                            }
                            else
                            {
                                x--;
                                continue;
                            }
                        }
                        if (arriba)
                        {
                            if (checar[x, y-1])
                            {
                                
                                derecha = true;
                                arriba = false;
                                x++;
                                continue;
                            }
                            else
                            {
                                y--;
                                continue;
                            }
                        }
                        
                        
                    }while(true);
                    
                    Console.WriteLine();
                   
                }
        }
        
    }
}
