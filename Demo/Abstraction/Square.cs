using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal class Square : Shape
    {
        public Square(decimal dim) { Dim1 = Dim2 = dim; }
        public override decimal perimeter
        {
            get { return Dim1 * 4; }
        }

        public override decimal CalcArea()
        {
            return Dim1 * Dim2;
        }
    }
}
