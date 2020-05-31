using OOP_lab_6_25_1;
using System;
using System.IO;

namespace OOP_lab_6_25_1
{
    class Program : IWork
    {
        static void Main(string[] args)
        {
            new Program().Work();
        }

        public void Work()
        {
            StreamReader file = new StreamReader("base.txt");

            string[] baseElements = file.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

            Book[] library = new Book[baseElements.Length / 5];

            for (int i = 0; i < baseElements.Length; i += 5)
            {
                library[i / 5] = new Book(baseElements[i], baseElements[i + 1], baseElements[i + 2], DateTime.Parse(baseElements[i + 3]), int.Parse(baseElements[i + 4]));
            }

            string format = "{0,-25}{1,-15}{2,-15}{3,-15}{4,-15}";

            Console.WriteLine(format, "Автор", "Назва", "Видавництво", "Рiк видання", "Кiлькiсть");

            for (int i = 0; i < library.Length; ++i)
            {
                Console.WriteLine(format, library[i].Author, library[i].Title, library[i].PublishingHouse, library[i].PublishingYear.ToShortDateString(), library[i].Count);
            }

            int k = 0;

            Console.WriteLine();

            Console.WriteLine(format, "Автор", "Назва", "Видавництво", "Рiк видання", "Кiлькiсть");

            for (int i = 0; i < library.Length; ++i)
            {
                if (library[i].PublishingYear >= DateTime.Parse("01.01.2000"))
                {
                    Console.WriteLine(format, library[i].Author, library[i].Title, library[i].PublishingHouse, library[i].PublishingYear.ToShortDateString(), library[i].Count);
                    ++k;
                }
            }

            Console.WriteLine("Кiлькiсть книг, що були виданi пiсля 2000го року: {0}.", k);
        }
    }
}
