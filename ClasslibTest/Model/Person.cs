using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibTest.Model
{
    public class Person : object
    {
        // constants
        public const string Species = "Homo Sapiens";
        // read-only fields
        public readonly string HomePlanet = "Earth";

        public readonly DateTime Instantiated;
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person()
        {

        }

        public Person(string initialName, string homePlanet)
        {
            //218 Building Your Own Types with Object-Oriented Programming
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

    }
}
