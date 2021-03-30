using System;
using System.IO;

/*
7.4.
Select from directory D only .txt files and print the text from it into console. 
Catch appropriative exceptions.
*/

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string pathDownloads = "/Users/mac/Downloads";

                string[] files = Directory.GetFiles(pathDownloads, "*.txt", SearchOption.AllDirectories);

                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}