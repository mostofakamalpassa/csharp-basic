using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Interfaces
{
    public interface ILogger
    {
        void Log(string text) =>Console.WriteLine(Prefix + text);
        static string Prefix = "";
    }
}
