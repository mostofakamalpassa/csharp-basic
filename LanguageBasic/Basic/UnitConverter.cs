using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageBasic.Basic
{
    public class UnitConverter
    {
        int ratio; // Field
        public UnitConverter(int unitRatio) // Constructor
        {
            ratio = unitRatio;
        }
        public int Convert(int unit) // Method
        {
            return unit * ratio;
        }
    }
}
