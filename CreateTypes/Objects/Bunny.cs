using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Objects
{
    public class Bunny
    {
        public string Name;
        public bool LikesCarrots;
        public bool LikesHumans;
        public Bunny() { }
        public Bunny(string n) { Name = n; }

        public Bunny(string name,
            bool likesCarrots = false,
            bool likesHumans = false)
        {
            Name = name;
            LikesCarrots = likesCarrots;
            LikesHumans = likesHumans;
        }
    }
}
