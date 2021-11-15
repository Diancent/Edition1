using System;
using System.Collections.Generic;

namespace laboratorna2OOPmain
{

    class Edition
    {
        public string nameOfPublication;
        public string lastNameOfAuthor;
        public Edition(string nameOfPublication, string lastNameOfAuthor)
        {
            this.nameOfPublication = nameOfPublication;
            this.lastNameOfAuthor = lastNameOfAuthor;
        }
        public void getInformation()
        {
            Console.WriteLine("Information: {0},{1}", nameOfPublication, lastNameOfAuthor);
        }
    }
    class Book : Edition
    {
        public string yearOfPublication;
        public string nameOfEdition;
        public Book(string nameOfPublication, string lastNameOfAuthor, string yearOfPublication, string nameOfEdition) : base(nameOfPublication, lastNameOfAuthor)
        {
            this.yearOfPublication = yearOfPublication;
            this.nameOfEdition = nameOfEdition;
        }
        public new void getInformation()
        {
            Console.WriteLine("Information: {0},{1},{2},{3}", nameOfPublication, lastNameOfAuthor, yearOfPublication, nameOfEdition);
        }
    }
    class Article : Edition
    {
        public string nameOfMagazine;
        public int number;
        public string yearOfPublication;
        public Article(string nameOfPublication, string lastNameOfAuthor, string yearOfPublication, string nameOfMagazine, int number) : base(nameOfPublication, lastNameOfAuthor)
        {
            this.nameOfMagazine = nameOfMagazine;
            this.number = number;
            this.yearOfPublication = yearOfPublication;
        }
        public new void getInformation()
        {
            Console.WriteLine("Information: {0},{1},{2},{3},{4}", nameOfPublication, lastNameOfAuthor, nameOfMagazine, number, yearOfPublication);
        }
    }
    class InternetEdition : Edition
    {
        public string link;
        public string annotation;
        public InternetEdition(string nameOfPublication, string lastNameOfAuthor, string link, string annotation) : base(nameOfPublication, lastNameOfAuthor)
        {
            this.link = link;
            this.annotation = annotation;
        }
        public new void getInformation()
        {
            Console.WriteLine("Information: {0},{1},{2},{3}", nameOfPublication, lastNameOfAuthor, link, annotation);
        }
    }
    class Catalog
    {
        public List<Edition> list = new List<Edition>();
        public void AddEdition(Edition edit)
        {
            list.Add(edit);
        }
        public void FindEdition(string lastNameOfAuthor)
        {
            foreach (var p in list)
                if (p.lastNameOfAuthor == lastNameOfAuthor)
                {
                    p.getInformation();
                }

        }


    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Catalog c = new Catalog();
            c.AddEdition(new Book("Book", "Artem", "2005", "Star"));
            c.AddEdition(new Article("Article", "Maxim", "2012", "Super", 12));
            c.AddEdition(new InternetEdition("Internet", "Vlad", "http", "Annotation"));
            foreach (var p in c.list)
            {
                p.getInformation();
            }
            Console.WriteLine();
            c.FindEdition("Artem");
            Console.ReadLine();
        }
    }
}

