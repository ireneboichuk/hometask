using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 7.5 In Main() method declare Dictionary PhoneBook for keeping pairs PersonName-PhoneNumber. 
            1) From file "phones.txt" read 9 pairs into PhoneBook. Write only PhoneNumbers into file "Phones.txt".
            2) Find and print phone number by the given name (name input from console)
            3) Change all phone numbers, which are in format 80######### into new format +380#########.
               The result write into file "New.txt" */

            Dictionary<string, long> PhoneBook = new Dictionary<string, long>(9);
            ArrayList myListRelatedToPhoneBook = new ArrayList();

            try
            {
                string path = "/Users/mac/Desktop/phoneNumbers.txt";
                string path2 = "/Users/mac/Desktop/Phones123.txt";
                string path3 = "/Users/mac/Desktop/PhonesWithCorrectFormat.txt";

                // Читання документу та додавання даних в PhoneBook
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        foreach (var a in line.Split(' '))
                        {
                            myListRelatedToPhoneBook.Add(a);
                        }
                    }

                    Console.WriteLine("Список myListRelatedToPhoneBook: ");
                    foreach (object o in myListRelatedToPhoneBook)
                    {
                        Console.WriteLine(o);
                    }


                    // Додавання значень в PhoneBook Dictionary
                    for (int i = 0; i < myListRelatedToPhoneBook.Count;)
                    {
                        string personName = Convert.ToString(myListRelatedToPhoneBook[i]);
                        i++;
                        long phoneNumber = Convert.ToInt64(myListRelatedToPhoneBook[i]);
                        i++;

                        PhoneBook.Add(personName, phoneNumber);
                    }
                }

                // Вивід вмісту PhoneBook на консоль
                Console.WriteLine("Вивід вмісту PhoneBook на консоль");
                foreach (KeyValuePair<string, long> keyValue in PhoneBook)
                {
                    Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                }

                // Створення і / або додавання тільки телефонних номерів в документ "Phones1.txt"
                Console.WriteLine("Створення або додавання тільки телефонних номерів в документ Phones1.txt");
                FileStream fileStream;
                if (!File.Exists(path2))
                {
                    fileStream = File.Create(path2);
                    fileStream.Close();
                }

                using (StreamWriter sw = new StreamWriter(path2, false, System.Text.Encoding.Default))
                {
                    foreach (int i in PhoneBook.Values)
                    {
                        sw.WriteLine(i);
                        Console.WriteLine(i);
                    }
                }

                // пошук номера телефону за вводом імені людини
                Console.WriteLine("Введіть ім'я: ");
                string personIDValue = Console.ReadLine();
                long phoneValue;
                if (PhoneBook.TryGetValue(personIDValue, out phoneValue))
                {
                    Console.WriteLine("For key = {0}, value = {1}.", personIDValue, phoneValue);
                }
                else
                {
                    Console.WriteLine("Key = {0} is not found.", personIDValue);
                }

                // Перевірка на доступність / створення файлу для оновленого формату номерів
                FileStream fileStream1;
                if (!File.Exists(path2))
                {
                    fileStream1 = File.Create(path3);
                    fileStream1.Close();
                }

                // зміна формату номера телефону на "+380..." і додавання оновлених значень в документ PhonesWithCorrectFormat.txt
                using (StreamWriter sw = new StreamWriter(path3, false, System.Text.Encoding.Default))
                {
                    foreach (string i in PhoneBook.Keys)
                    {
                        var value = "+3" + PhoneBook[i];
                        sw.WriteLine(i + " - " + value);

                        Console.WriteLine(i + " - " + value);
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