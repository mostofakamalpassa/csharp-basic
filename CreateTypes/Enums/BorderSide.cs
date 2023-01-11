using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Enums
{

    /**
     * 
     * = == != < > <= >= + - ^ & | ˜ += -= ++ -- sizeof
     * 
     */
    public enum BorderSide
    {
        Left, Right, Top, Bottom
    }

    public enum BorderSides : byte { Left, Right, Top, Bottom }

    public enum BorderSides1 : byte { Left = 1, Right = 2, Top = 10, Bottom = 11 }

    public enum HorizontalAlignment
    {
        Left = BorderSide.Left,
        Right = BorderSide.Right,
        Center
    }

    [Flags]
    enum BorderSidess { None = 0, Left = 1, Right = 2, Top = 4, Bottom = 8 }
}
