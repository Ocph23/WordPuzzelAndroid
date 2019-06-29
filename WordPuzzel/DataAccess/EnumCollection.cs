using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public enum Arah
    {
        Horizontal, Vertical, Diagonal
    }

    public enum ArahPanah
    {
        HorizontalToRight, HorizontalToLeft, VerticalToTop, VerticalToBottom, DiagonalToDownRight, DiagonalToDownLeft, DiagonalToUpRight, DiagonalToUpLeft,
        None
    }

    public enum Level
    {
        Easy, Middle, Advance
    }
}
