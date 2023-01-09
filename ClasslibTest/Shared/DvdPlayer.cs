using ClasslibTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibTest.Shared
{
    public class DvdPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("DVD player is pausing.");
        }
       public void Pause()
        {
            Console.WriteLine("DVD player is playing.");
        }
    }
}
