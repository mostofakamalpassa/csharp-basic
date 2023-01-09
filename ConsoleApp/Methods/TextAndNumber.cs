using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp.Methods
{
    public class TextAndNumber
    {
        public string Text;
        public int Number;
    }

    public class LifeTheUniverseAndEverything
    {
        public TextAndNumber GetTheData()
        {
            return new TextAndNumber
            {
                Text = "What's the meaning of life?",
                Number = 42
            };
        }

        public (string, int ) GetFruit()
        {
            return ("kamal passa", 44);
        }

       
    }
}
