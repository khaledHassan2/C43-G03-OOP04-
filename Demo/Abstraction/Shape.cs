using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    abstract class Shape
    {
        public decimal Dim1 { get; set; }
        public decimal Dim2 { get; set; }
        public abstract decimal perimeter { get;}
        public abstract decimal CalcArea();
    }
}
