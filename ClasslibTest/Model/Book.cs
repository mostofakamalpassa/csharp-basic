using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibTest.Model
{
    public class Book
    {
        // Needs .NET 7 or later as well as C# 11 or later.
        public required string? Isbn { get; set; }
        public required string? Title { get; set; }
        public string? Author { get; set; }
        public int PageCount { get; set; }

        public Book() { } // For use with initialization syntax.
        public Book(string? isbn, string? title)
        {
            Isbn = isbn;
            Title = title;
        }

        // indexers
        public List<Person> Children { get; set; }
        public Person this[int index]
        {
            get
            {
                return Children[index]; // pass on to the List<T> indexer
            }
            set
            {
                Children[index] = value;
            }
        }

        public Person this[string name]
        {
            get
            {
                return Children.Find(p => p.Name == name);
            }
            set
            {
                Person found = Children.Find(p => p.Name == name);
                if (found is not null) found = value;
            }
        }

        private bool married = false;
        public bool Married => married;
        private Person? spouse = null;
        public Person? Spouse => spouse;

        // static method to marry
        public static void Marry(Person p1, Person p2)
        {
           // p1.Marry(p2);
        }
        // instance method to marry
        public void Marry(Person partner)
        {
            if (married) return;
            spouse = partner;
            married = true;
           // partner.Marry(this); // this is the current object
        }


    }
}
