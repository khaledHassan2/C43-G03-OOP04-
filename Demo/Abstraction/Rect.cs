using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal class Rect : Shape
    {
        public override decimal perimeter 
        {
            get {return( Dim1 + Dim2 )/ 2; }
        }

      

        public override decimal CalcArea()
        {
            return Dim1 * Dim2;
        }
    }
}
