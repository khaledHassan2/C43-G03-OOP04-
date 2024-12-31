﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imge { get; set; }
        public override string ToString()
        {
            return $"Real: {Real} , Imge :{Imge}";
        }
        #region Binary Operators
        // Overloding Operators: Must be Non -Private Class Member Mthod
        public static Complex operator +(Complex l, Complex r)
        {
            return new Complex() { Real = (l?.Real??0 + r?.Real??0), Imge=(l?.Imge??0+r?.Imge??0)};
        }
        //------
        public static Complex operator -(Complex l, Complex r)
        {
            return new Complex() { Real = (l?.Real ?? 0 - r?.Real ?? 0), Imge = (l?.Imge ?? 0 - r?.Imge ?? 0) };
        }
        #endregion
        #region Unary Operators
        public static Complex operator ++(Complex C)
        {
            return new Complex()
            { 
                Real = (C?.Real ?? 0 )+1,
                Imge= (C?.Imge ?? 0) 

            };
        }
        public static Complex operator --(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) - 1,
                Imge = (C?.Imge ?? 0)

            };
        }
        #endregion
        #region Relational Operators
        public static bool operator >(Complex l,Complex r)
        {
           
            {
               if(l?.Real==r?.Real)
                return l.Imge > r.Imge;
               else 
                return l.Real > r.Real;

            };
        }
    public static bool operator <(Complex l, Complex r)
    {
       
        {
               if (l?.Real == r?.Real)
            return l.Imge < r.Imge;
        else
            return l.Real < r.Real;

    };
}
        #endregion
        #region Casting Operator
        public static explicit operator int (Complex C)
        {
            return C?.Real??0;
        }
        // implicit
        public static implicit operator string(Complex C)
        {
            return C?.ToString() ?? string.Empty;
        }
        #endregion
    }
}