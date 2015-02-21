using System;
using System.IO;

namespace CodeEval
{
    class Program
    {
        static void Main(string[] args)
        {

            string line = null;
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    if (line.Length <= 55)
                    {
                        Console.WriteLine(line);
                    }
                    else
                    {
                        line = line.Substring(0, 40);
                        if (line.Contains(" "))
                        {
                            line = line.Substring(0, line.LastIndexOf(' '));
                        }

                        Console.WriteLine(line + "... <Read More>");


                    }
                }
                    
                    
               
        }
    }
}
