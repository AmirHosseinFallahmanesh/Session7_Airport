using System;
using System.IO;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("a.txt",true);
            writer.WriteLine("this is line 3");
            writer.WriteLine("this is line 4");
    
            writer.Flush();
            writer.Close();


            StreamReader reader = new StreamReader("a.txt");
            //string data = reader.ReadToEnd();

            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }

            reader.Close();
        


        }
    }
}
