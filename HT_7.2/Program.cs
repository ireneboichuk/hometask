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
                string path = "/Users/mac/Desktop/phones.txt";
                string writePath = "/Users/mac/Desktop/rez.txt";
                string writePath2 = "/Users/mac/Desktop/rez2.txt";

                // Перший спосіб записати дані у файл
                using (StreamReader sr = new StreamReader(path))
                {
                    using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                    {
                        string line;
                        while((line = sr.ReadLine()) != null)
                        {
                            sw.WriteLine(line);
                        }
                    }
                }

                // Другий спосіб записати дані у файл
                string readText = File.ReadAllText(path);
                File.WriteAllText(writePath2, readText);

                Console.WriteLine("Робота з файлами завершена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}