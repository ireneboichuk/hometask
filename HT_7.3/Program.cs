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