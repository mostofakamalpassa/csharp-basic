using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp.Methods
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        // read-only fields
        public readonly string HomePlanet = "Earth";
        // methods
        public void WriteToConsole()
        {
            Console.WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }

        public string SayHelloTo(string name)
        {
            return $"{Name} says 'Hello, {name}!'";
        }

        public string OptionalParameters(string command = "Run!", double number = 0.0, bool active = true)
        {
            return string.Format(
            format: "command is {0}, number is {1}, active is {2}",
            arg0: command,
            arg1: number,
            arg2: active);
        }
        public void PassingParameters(int x, ref int y, out int z)
        {
            // out parameters cannot have a default
            // AND must be initialized inside the method
            z = 99;
            // increment each parameter
            x++;
            y++;
            z++;
        }

        // a readonly property defined using C# 1 - 5 syntax
        public string Origin
        {
            get
            {
                return string.Format("{0} was born on {1}",
                arg0: Name, arg1: HomePlanet);
            }
        }

        // two readonly properties defined using C# 6+ lambda expression body syntax
        public string Greeting => $"{Name} says 'Hello!'";
        public int Age => DateTime.Today.Year - DateOfBirth.Year;

        // a read-write property defined using C# 3.0 syntax
        public string? FavoriteIceCream { get; set; } // auto-syntax

        // a private field to store the property value
        private string? favoritePrimaryColor;
        // a public property to read and write to the field
        public string? FavoritePrimaryColor
        {
            get
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch (value?.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new ArgumentException(
                        $"{value} is not a primary color. " +
                        "Choose from: red, green, blue.");
                }
            }
        }



    }
}
