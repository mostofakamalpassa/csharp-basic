using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibTest.Shared
{
    public record ImmutableVehicle
    {
        public int Wheels { get; init; }
        public string? Color { get; init; }
        public string? Brand { get; init; }
    }
}
