using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Structers
{
    public struct Point
    {
        int x, y;
        public Point(int x, int y) { this.x = x; this.y = y; } // OK
    }

    readonly struct Points
    {
        public readonly int X, Y; // X and Y must be readonly
    }
}
