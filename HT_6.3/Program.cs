using System;
using System.Collections.Generic;

namespace Test
{
    public class Programmer : IDeveloper
    {
        private string _language;

        public string Tool { get => _language; }


        public Programmer(string language)
        {
            _language = language;
        }

        public void Create()
        {
            Console.WriteLine($"Programmer created application");
        }
        public void Destroy()
        {
            Console.WriteLine($"Programmer destroyed application");
        }
    }

    public class Builder : IDeveloper
    {
        private string _tool;

        public string Tool { get => _tool; }
        
        public Builder(string tool)
        {
            _tool = tool;
        }

        public void Create()
        {
            Console.WriteLine($"Builder builds application");
        }

        public void Destroy()
        {
            Console.WriteLine($"Builder reverts application");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var developerList = new List<IDeveloper>();

            var sharpDeveloper = new Programmer("c#");
            var phpDeveloper = new Programmer("php");
            var pythonDeveloper = new Programmer("python");

            var desktopBuilder = new Builder("Desktop");
            var webBuilder = new Builder("Web");

            developerList.Add(sharpDeveloper);
            developerList.Add(phpDeveloper);
            developerList.Add(pythonDeveloper);

            developerList.Add(desktopBuilder);
            developerList.Add(webBuilder);

            foreach(var developer in developerList)
            {
                developer.Create();
                Console.WriteLine(developer.Tool);
                developer.Destroy();

                Console.WriteLine("-----");
            }

            Console.ReadLine();
        }
    }
}