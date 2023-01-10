using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Structers
{
    public struct WebOptions
    {
        string protocol;
        public string Protocol
        {
            get => protocol ?? "https";
            set => protocol = value;
        }
    }
}
