using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab_4_25_2
{
    class Book
    {
        private string _author;
        private string _title;
        private string _publishingHouse;
        private DateTime _publishingYear;
        private int _count;

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }
        public string PublishingHouse
        {
            get => _publishingHouse;
            set => _publishingHouse = value;
        }
        public DateTime PublishingYear
        {
            get => _publishingYear;
            set => _publishingYear = value;
        }
        public int Count
        {
            get => _count;
            set => _count = value;
        }

        public Book()
        {
            _author = "Не вказано";
            _title = "Не вказано";
            _publishingHouse = "Не вказано";
            _publishingYear = DateTime.Parse("01.01.01");
            _count = 0;
        }

        public Book(string author, string title, string publishingHouse, DateTime date, int count)
        {
            _author = author;
            _title = title;
            _publishingHouse = publishingHouse;
            _publishingYear = date;
            _count = count;
        }
    }
}
