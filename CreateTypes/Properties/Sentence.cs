using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Properties
{
    public class Sentence
    {
        string[] words = "The quick brown fox".Split();

        public string this[int nunWords]
        {
            get => words[nunWords];
            set => words[nunWords] = value;
        }
    }
}
