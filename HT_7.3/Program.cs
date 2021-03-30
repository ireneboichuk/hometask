using System;
using System.IO;

/*
7.3.
Write into file ‘DirectoryC.txt’ information (name, type, size) about all directories and files 
from disc C on your computer. Catch appropriative exceptions.
*/

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = "/Users/mac/Desktop/DirectoryC.txt";
                string pathDownloads = "/Users/mac/Downloads";


                using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("Директорії:");
                        string[] dirs = Directory.GetDirectories(pathDownloads);
                        foreach (string s in dirs)
                        {
                            sw.WriteLine(s);
                        }

                        Console.WriteLine();

                        sw.WriteLine("Файли:");
                        string[] files = Directory.GetFiles(pathDownloads);
                        foreach (string s in files)
                        {
                            sw.WriteLine(s);
                        }
                    }
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