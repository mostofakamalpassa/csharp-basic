using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Inheritance
{
    public class Assets
    {
        public string Name;

        public virtual decimal Liability => 0; // Expression-bodied property
        public virtual Assets Clone() => new Assets { Name = Name };
    }
}
