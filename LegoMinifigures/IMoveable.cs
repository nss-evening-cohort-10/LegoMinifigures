using System;
using System.Collections.Generic;
using System.Text;
using LegoMinifigures.Composition.Heads;

namespace LegoMinifigures
{
    interface IMoveable
    {
        void Move(int howFar);
    }

    interface ILegoPiece : IMoveable, IColorful
    {

    }
}
