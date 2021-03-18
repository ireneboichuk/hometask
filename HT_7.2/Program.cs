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
                string path = "/Users/mac/Desktop/data.txt";
                string writePath = "/Users/mac/Desktop/rez.txt";
                string writePath2 = "/Users/mac/Desktop/rez2.txt";

                using (StreamReader sr = new StreamReader(path))
                {
                    using (StreamWriter sw = new StreamWriter(writePath2, false, System.Text.Encoding.Default))
                    {
                        // Перший спосіб записати дані у файл
                        Console.WriteLine(sr.ReadToEnd());
                        string readText = File.ReadAllText(path);

                        File.WriteAllText(writePath, readText);


                        // Другий спосіб записати дані у файл
                        sw.Write(sr.ReadToEnd());
                        sw.Close();
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