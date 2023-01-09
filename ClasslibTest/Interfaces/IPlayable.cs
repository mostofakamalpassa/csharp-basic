using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibTest.Interfaces
{
    public interface IPlayable
    {
        void Play();
        void Pause();

        void Stop() // default interface implementation
        {
            Console.WriteLine("Default implementation of Stop.");
        }
    }
}
