using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClasslibTest.Shared
{
    public class PersonException:Exception
    {
        public PersonException() : base() { }
        public PersonException(string message) : base(message) { }
        public PersonException(string message, Exception innerException) : base(message, innerException) { }

        public DateTime DateOfBirth { get; set; }

        public void TimeTravel(DateTime when)
        {
            if (when <= DateOfBirth)
            {
                throw new PersonException("If you travel back in time to a date earlier than your own birth, then the universe will explode!");
            }
            else
            {
                Console.WriteLine($"Welcome to {when:yyyy}!");
            }
        }
    }
}
