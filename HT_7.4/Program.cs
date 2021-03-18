using System;
using System.IO;

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